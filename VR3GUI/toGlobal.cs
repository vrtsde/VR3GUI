using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace VR3GUI
{
    public class toGlobal
    {
        public bool checkEmptyTable(String table)
        {

            SQLfx Data = new SQLfx();
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            String query = "SELECT COUNT(*) from " + table;
            SqlCommand cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();


            int result = int.Parse(cmd.ExecuteScalar().ToString());

            return result == 0; // if result equals zero, then the table is empty

        }
        public void ee(String PartID, String PartAge, String PartSex, String PartHeight, String folderPath, String fileExt)
        {

            Console.WriteLine(checkEmptyTable("trialList"));
            if(checkEmptyTable("trialList") && !checkEmptyTable("condPresets")) // Also check if preset selected
            {
                SQLfx DataQ = new SQLfx();
                SqlConnection conQ = DataQ.openSQLConnection(); // Open SQL Connection
                String queryQ = "insert into trialList(condLabel, trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft) select condLabel ,trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft from condPresets";

                SqlCommand cmdQ = new SqlCommand(queryQ, conQ);
                cmdQ.ExecuteNonQuery();
                Console.WriteLine(queryQ);
            }
            Form1 mainForm = new Form1();
            SQLfx Data = new SQLfx();

            int counter = 0;
            string line;
            string[] array = new String[100];



           ///////// -------- Begin Reading Globals File, Line By Line, Stored In Array ----------------------
            
            //  Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\vr\vr3\VRTSGUI\VRTSGUI\GlobalsBackup.py");
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                array[counter] = line;
                counter++;
            }
            System.Console.WriteLine("\n\nHERE: {0}     ", array[26]);
            file.Close();
            //System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            //System.Console.ReadLine();

            ///////// -------- Get Values From SQL Database, Stored As Local Variables ----------------------

            String DCP = Data.printString("properties", "DCP");
            Console.WriteLine("XXXXXXXXXXXXXXX DCP " + DCP);
            String NMD = Data.printString("properties", "NMD");
            String RSD = Data.printString("properties", "RSD");
            String RND = Data.printString("properties", "RND");
            String FCA = Data.printString("properties", "FCA");
            String PCA = Data.printString("properties", "PCA");
            String MPA = Data.printString("properties", "MPA");
            String ist = Data.printString("properties", "IST");
            String CSR = Data.printCS("trialList", "CarSpaceRight");

            ///////// -------- Line By Line Parse and Modify Values From Array ----------------------
           
            char[] spearator = {'='};
            Int32 count = 2;
            String final = "";
            String[] strlist = new String[2];
            String[] cS = new String[2];

            //strlist = array[26].Split('  ');
            cS = CSR.Split(':');
            Console.WriteLine("CSR: " + cS.Length);


            // DCP is Array 27
            strlist = array[26].Split(spearator, count, StringSplitOptions.None);
            array[26] = strlist[0] + " = " + DCP;

            // NMD is Array 28
            strlist = array[27].Split(spearator, count, StringSplitOptions.None);
            array[27] = strlist[0] + " = " + NMD;

            // RSD is Array 31
            strlist = array[31].Split(spearator, count, StringSplitOptions.None);
            array[31] = strlist[0] + " = " + ist;

            // RSD is Array 33
            strlist = array[32].Split(spearator, count, StringSplitOptions.None);
            array[32] = strlist[0] + " = " + RSD;

            // RND is Array 34
            strlist = array[33].Split(spearator, count, StringSplitOptions.None);
            array[33] = strlist[0] + " = " + RND;

            // folderPath is Array 35
            strlist = array[34].Split(spearator, count, StringSplitOptions.None);
            array[34] = strlist[0] + " = '" + folderPath + "'";

            // folderPath is Array 36
            strlist = array[35].Split(spearator, count, StringSplitOptions.None);
            array[35] = strlist[0] + " = '" + fileExt + "'";

            // ID is Array 41
            strlist = array[40].Split(spearator, count, StringSplitOptions.None);
            array[40] = strlist[0] + " = " + "'" + PartID + "'" ;

            // participantVariableValues is Array 43
            array[42] = "participantVariableValues = "+ "["+ "'" + PartID + "'" +","+ "'" + PartAge + "'" + "," + "'" + PartSex + "'" + "," + "'" + PartHeight + "'" + "]"; 


            // FCA is Array 45
            strlist = array[44].Split(spearator, count, StringSplitOptions.None);
            array[44] = strlist[0] + " = " + FCA;
           
            // PCA is Array 46
            strlist = array[45].Split(spearator, count, StringSplitOptions.None);
            array[45] = strlist[0] + " = " + PCA;

            // MPA is Array 48
            strlist = array[47].Split(spearator, count, StringSplitOptions.None);
            array[47] = strlist[0] + " = " + MPA;


            string[] newArray = new String[array.Length + cS.Length];
            for(int i = 0; i< 53; i++)
            {
                newArray[i] = array[i];
            }
            // Needs defensive programming -- What if no entires in DataTable??
           

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM trialList", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StringBuilder output = new StringBuilder();
            int numEntries = 0;
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    output.AppendFormat("{0},", dr[col]);
                    
                }
                numEntries++;
                output.AppendLine();
            }
            if(numEntries == 0)
            {
                return;
            }
            Console.WriteLine("KO --");
            Console.WriteLine(output);
            Console.WriteLine("--\n\n");
            String[] strlist1 = new String[200];
            Int32 count1 = 200;
            char[] spearator1 = { ',', '\0'};
            string newoutput = output.ToString();
            Console.WriteLine(output.ToString().Split('\n')[0]);
            Console.WriteLine(output.ToString().Split('\n')[0].Split(',')[0]);
            Console.WriteLine(output.ToString().Split('\n')[0].Split(',')[1]);
            Console.WriteLine(numEntries);
            for (int i = 0; i < numEntries; i++)
            {
                newoutput = output.ToString().Split('\n')[i];
                Console.WriteLine("HERE: " , newoutput);
                strlist1 = newoutput.Split(spearator1, count1, StringSplitOptions.None);
                Console.WriteLine(newoutput);
                String TrialType = strlist1[1];
                String TrialBehav = strlist1[2];
                //Console.WriteLine("ANALYSIS"+  strlist1 +  newoutput + "\n"+strlist1[6]);
                string trialSpeed = strlist1[6];
                string trialcond = "'" + strlist1[7] + "'";
                String prepost = "'" + strlist1[8] + "'";
                if (TrialBehav == "Spawn On Enter Road")
                {
                    TrialBehav = "SPAWNONROADENTER";
                }
                else
                {
                    TrialBehav = "SPAWNONSTARTTRIAL";
                }
                String CSR1 = strlist1[3];
                String CSL1 = strlist1[4];
                String replace = Regex.Replace(CSL1, @"\t|\n|\r|,", "");
                string[] CSR12 = Regex.Split(CSR1, @"[^0-9\.]+");
                string[] CSL12 = Regex.Split(replace, @"[^0-9\.]+");
                Console.WriteLine("UIUIOUIOUIOUOI " + CSR1);
                //  Once all values are in array, respective to their lines, then write array element by element to file line by line
                string finalCSR = string.Join(",", CSR12, 1, CSR12.Length - 1);
                string finalCSL = string.Join(",", CSL12, 1, CSL12.Length - 1);
                

                Console.WriteLine("\n\n" + string.Join(",", CSR12, 1, CSR12.Length - 1));
                if (finalCSR.Length > 0)
                {
                    if (finalCSR[finalCSR.Length - 1] == ',')
                    {
                        finalCSR = finalCSR.Substring(0, finalCSR.Length - 1);
                    }
                }
                if(finalCSL.Length > 0)
                {
                    if (finalCSL[finalCSL.Length - 1] == ',')
                    {
                        finalCSL = finalCSL.Substring(0, finalCSL.Length - 1);
                    }
                }


                TrialType = TrialType.Replace("-", "_");
                TrialType = TrialType.ToUpper();
                if (TrialType == "STANDARD_CONSTANTGAP_PRE")
                {
                    TrialType = "STANDARD_ConstantGap_PRE";
                }
                if(numEntries == 1 || i == numEntries-1)
                {
                    newArray[53 + i] = string.Format("(TrialType." + TrialType +", " + trialcond + ", " + "CarBehaviour." + TrialBehav + ", " + "[" + finalCSR + "]" + ", " + "[" + finalCSL + "], " + trialSpeed+ " , " + trialSpeed + ", 1, 1, True, 0, 0, AvatarBehaviour.NONE" + ", " + prepost+ ")");
                }
                else
                {
                    newArray[53 + i] = string.Format("(TrialType." + TrialType + ", " + trialcond + ", " + "CarBehaviour." + TrialBehav + ", " + "[" + finalCSR + "]" + ", " + "[" + finalCSL + "], " + trialSpeed+" , "+ trialSpeed + ", 1, 1, True, 0, 0, AvatarBehaviour.NONE" + ", " + prepost + "),");
                }

            }
            for (int i = 0 ; i<=8; i++)
            {
                newArray[53 + numEntries + i] = array[54 + i];
            }
            // Write the string array to a new file named "WriteLines.txt".--- Will need to be chnaged to Globals.py
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\vr\vr3\Globals.py")))
            {
                for (int i = 0; i < counter + numEntries; i++)
                {
                    outputFile.WriteLine(newArray[i]);
                    Console.WriteLine(newArray[i]);
                }
            }


            Console.WriteLine("Printing to global completed");



        }

    }
   

}
