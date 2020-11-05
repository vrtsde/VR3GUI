using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace VR3GUI 
{
    public partial class Form1 : Form
    {
        Boolean newbuttonclicked = false;
        Button newButton = new Button();
        String label;
        public Form1()
        {
            InitializeComponent();
            updateDataTable();
            toGlobal tG = new toGlobal();
            StringBuilder output = new StringBuilder();
            int numEntries = 0;
            if (!tG.checkEmptyTable("condPresets"))
            {
                SQLfx Data = new SQLfx();
                SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
                SqlCommand cmd = new SqlCommand("SELECT condLabel FROM condPresets", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        output.AppendFormat("{0},", dr[col]);

                    }
                    numEntries++;
                    output.AppendLine();
                }
                if (numEntries == 0)
                {
                    return;
                }
            }
       

            foreach (string s in output.Replace("\n", "").Replace("\r", "").ToString().Split(',').Distinct())
            {
                Console.WriteLine(s);
                if(s.Length > 0)
                {
                    cbPreset.Items.Add(s);
                }
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHeight.Text = textBox5.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double feet;
            double meters = 0;
            try
            {
                feet = double.Parse(textBox6.Text);
                meters = feet / 3.2808 + meters;
            }
            catch (Exception eq)
            {
                feet = 0;
                meters = 0;
            }

            double inches = 0;
            try
            {
                inches = double.Parse(textBox4.Text);
                meters = meters + ((inches / 12) / 3.2808);
            }
            catch (Exception eq)
            {
                meters = meters; //Dont do anything 
            }
            meters = Math.Round(meters, 2);
            textBox5.Text = System.Convert.ToString(meters);
        }

        private void btnAddTrial_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            //this.Hide();
            frm.button8.Visible = false;
            frm.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            double feet;
            double meters = 0;
            try
            {
                feet = double.Parse(textBox6.Text);
                meters = feet / 3.2808 + meters;
            }
            catch (Exception eq)
            {
                feet = 0;
                meters = 0;
            }

            double inches = 0;
            try
            {
                inches = double.Parse(textBox4.Text);
                meters = meters + ((inches / 12) / 3.2808);
            }
            catch (Exception eq)
            {
                meters = meters; //Dont do anything 
            }
   
            textBox5.Text = System.Convert.ToString(Math.Round(meters, 2));
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double ms, km = 0;
            try
            {
                km = double.Parse(textBox10.Text);
                ms = km / 3.6;
            }
            catch (Exception eq)
            {
                ms = 0;
            }
            ms = Math.Round(ms, 2);
            textBox9.Text = System.Convert.ToString(ms);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataCollectionPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO properties (DCP, NMD, RSD, RND, FCA, PCA, MPA, IST) VALUES (@DCP, @NMD, @RSD, @RND, @FCA, @PCA, @MPA, @IST);";
            cmd.Parameters.AddWithValue("@DCP", Convert.ToString(txtDataCollectionPeriod.Text));
            cmd.Parameters.AddWithValue("@NMD", txtNearMissDistance.Text);
            cmd.Parameters.AddWithValue("@RSD", txtRespawnStartDistance.Text);
            cmd.Parameters.AddWithValue("@RND", txtRespawnEndDistance.Text);
            cmd.Parameters.AddWithValue("@FCA", txtFullCheckAngle.Text);
            cmd.Parameters.AddWithValue("@PCA", txtPartialCheckAngle.Text);
            cmd.Parameters.AddWithValue("@MPA", txtMaxPitchAngle.Text);
            cmd.Parameters.AddWithValue("@IST", iST.Text);
            cmd.ExecuteNonQuery();

            toGlobal fileStuff = new toGlobal();
            if(txtID.Text.Length == 0)
            {
                txtID.Text = "ID";
            }
            fileStuff.ee(txtID.Text, txtAge.Text, Sex.Text, txtHeight.Text, txtPath.Text,textBox7.Text);
            cmd.ExecuteNonQuery();
            String query = "DELETE FROM dbo.properties";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            Process.Start(@"C:\vr\vr3\main.py");

            //txtID.Text = "";


        }

        private void txtNearMissDistance_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnVisualTest_Click(object sender, EventArgs e)
        {
            toGlobal fileStuff = new toGlobal();
            //`fileStuff.ee();

            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();

            // cmd.Connection = con;

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM trialList", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;

        }
        public void updateDataTable(){
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();

            // cmd.Connection = con;

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Id, trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft  FROM trialList", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Trial Type";
            dataGridView1.Columns[2].HeaderText = "Pre/Post";
            dataGridView1.Columns[3].HeaderText = "Trial Condition";
            dataGridView1.Columns[4].HeaderText = "Trial Behaviour";
            dataGridView1.Columns[5].HeaderText = "Car Speed";
            dataGridView1.Columns[6].HeaderText = "Right Facing Car Space";
            dataGridView1.Columns[7].HeaderText = "Left Facing Car Space";


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.ReadOnly = true;
           
            int index;
            if (dataGridView1.Rows.Count > 1)
            {
                index = dataGridView1.Rows.Count - 2;
            }
            else
            {
                index = 0;
            }
            dataGridView1.Rows[index].Selected = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemoveTrial_Click(object sender, EventArgs e)
        {

            string index = "-1";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value == null)
                {
                    return;
                }
                index = Convert.ToString(row.Cells[0].Value.ToString());


            }
            if (index == "-1")
            {
                return;
            }


            SQLfx Data = new SQLfx();
           
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "DELETE FROM trialList WHERE ID= " + index;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            updateDataTable();
           
        }

        private void btnCopyTrial_Click(object sender, EventArgs e)
        {
           // Needs defensive programming -- What if no entires in DataTable?? Should be working now 
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            string index = "-1";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value == null)
                {
                    return;
                }
                index = Convert.ToString(row.Cells[0].Value.ToString());


            }
            if (index == "-1")
            {
                return;
            }


            String query = "SELECT * FROM trialList WHERE ID= " + index;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StringBuilder output = new StringBuilder();
            int checker = 0;
            foreach (DataRow dr in dt.Rows)
            { 
                foreach (DataColumn col in dt.Columns)
                {
                    output.AppendFormat("{0},", dr[col]);
                }

                checker = 1;
            }
            if (checker == 1)
            {
                Console.WriteLine(output);
                String[] strlist = new String[1000];
                Int32 count = 200;
                char[] spearator = { ',', '\0', '\n' };
                string newoutput = output.ToString();

                strlist = newoutput.Split(spearator, count, StringSplitOptions.None);
                Console.WriteLine("COPYUNG" + newoutput + strlist[8]);
                String TrialType = strlist[1];
                String TrialBehav = strlist[2];
                String CSR = strlist[3];
                String CSL = strlist[4];
                String trialspeed = strlist[6];
                String trialcond = strlist[7];
                String prepost = strlist[8];

                String replace = Regex.Replace(CSL, @"\t|\n|\r|,", "");
                //CSL[CSL.Length -1] = "/0";
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO trialList (trialType, trialBehav,CarSpaceRight,CarSpaceLeft,speed,trialCond,prepost) VALUES (@trialType, @trialBehav,@CarSpaceRight,@CarSpaceLeft,@speed,@trialCond,@prepost);";
                cmd.Parameters.AddWithValue("@trialType", TrialType);
                cmd.Parameters.AddWithValue("@trialBehav", TrialBehav);
                cmd.Parameters.AddWithValue("@CarSpaceRight", CSR);
                cmd.Parameters.AddWithValue("@CarSpaceLeft", replace);
                cmd.Parameters.AddWithValue("@speed", trialspeed);
                cmd.Parameters.AddWithValue("@trialCond", trialcond);
                cmd.Parameters.AddWithValue("@prepost", prepost);
                cmd.ExecuteNonQuery();
                updateDataTable();
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtRespawnStartDistance_TextChanged(object sender, EventArgs e)
        {

        }
        static void ExecuteBashCommand()
        {
            // full path of python interpreter 
            string python = @"C:\Program Files\WorldViz\Vizard6\bin\python.exe";

            // python app to call 
            Directory.SetCurrentDirectory(@"C:\vr\vr3");
            string myPythonApp = "main.py";

            // dummy parameters to send Python script 
            int x = 2;
            int y = 5;

            // Create new process start info 
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // make sure we can read the output from stdout 
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            // start python app with 3 arguments  
            // 1st arguments is pointer to itself,  
            // 2nd and 3rd are actual arguments we want to send 
            myProcessStartInfo.Arguments = myPythonApp + " " + x + " " + y;

            Process myProcess = new Process();
            // assign start information to the process 
            myProcess.StartInfo = myProcessStartInfo;

            Console.WriteLine("Calling Python script with arguments {0} and {1}", x, y);
            // start the process 
            myProcess.Start();

            // Read the standard output of the app we called.  
            // in order to avoid deadlock we will read output first 
            // and then wait for process terminate: 
            StreamReader myStreamReader = myProcess.StandardOutput;
            string myString = myStreamReader.ReadLine();

            /*if you need to read multiple lines, you might use: 
                string myString = myStreamReader.ReadToEnd() */

            // wait exit signal from the app we called and then close it. 
            myProcess.WaitForExit();
            myProcess.Close();

            // write the output we got from python app 
            Console.WriteLine("Value received from script: " + myString);
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void DatabaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BtnEditTrial_Click(object sender, EventArgs e)
        {
            string index = "-1";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value == null)
                {
                    return;
                }
                index = Convert.ToString(row.Cells[0].Value.ToString());


            }
            if (index == "-1")
            {
                return;
            }
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "SELECT * FROM trialList WHERE ID= " + index;

            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, con);
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
            Console.WriteLine(output);

            String[] strlist1 = new String[200];
            Int32 count1 = 200;
            char[] spearator1 = { ',', '\0' };
            string newoutput = output.ToString();
            Console.WriteLine(output.ToString().Split('\n')[0]);
            Console.WriteLine(output.ToString().Split('\n')[0].Split(',')[0]);
            Console.WriteLine(output.ToString().Split('\n')[0].Split(',')[1]);
            Console.WriteLine(numEntries);

            strlist1 = newoutput.Split(spearator1, count1, StringSplitOptions.None);
            String TrialType = strlist1[1];
            String TrialBehav = strlist1[2];
            String trialSpeed = strlist1[6];
            String trialcond = strlist1[7];
            String prepost = strlist1[8];
            String CSR1 = strlist1[3];
            String CSL1 = strlist1[4];

            Console.WriteLine(TrialType + TrialBehav + trialSpeed + trialcond + prepost + CSR1 + CSL1);
            Form2 frm = new Form2(this);
            frm.Editing.Visible = true;
            frm.btnOk.Visible = false;
            frm.button6.Visible = false;
            frm.ID.Text = index;
            frm.Show();
            frm.cbTrialType.Text = TrialType;
            frm.cbCarBehaviour.Text = TrialBehav;
            frm.textBox8.Text = trialcond;
            float temp = float.Parse(trialSpeed) / float.Parse("0.277778");
            // Console.WriteLine(txtContinuousCarSpeed.Text);
            int inter = (int)Math.Round(temp);
            frm.txtContinuousCarSpeed.Text = Convert.ToString(inter);


            if (prepost.Contains("pre"))
            {
                frm.radioButton5.Checked = true;

            }
            else if (prepost.Contains("stand"))
            {
                frm.radioButton9.Checked = true;

            }
            else
            {
                frm.radioButton6.Checked = true;
            }
            frm.textBox2.Text = CSR1;
            frm.textBox5.Text = CSL1;


            SQLfx Data1 = new SQLfx();

            SqlConnection con1 = Data1.openSQLConnection(); // Open SQL Connection

            String[] CSR = new String[200];
            char[] spearator = { ' ' };
            CSR = CSR1.Split(spearator, count1, StringSplitOptions.None);

            for (int i = 1; i < CSR.Length; i++)
            {
                Console.WriteLine("WE " + CSR[i]);
                CSR[i] = "(" + CSR[i] + ")";
            }

            String yourString = String.Join(" , ", CSR);
            if (yourString.Length == 0)
            {
                yourString = yourString; // Dont do anything
            }
            else
            {
                yourString = yourString.Substring(1, yourString.Length - 1);
            }
            //Console.WriteLine("OKAY " + yourString.Substring(1, yourString.Length - 1));
            if (yourString.Length > 0)
            {
                CSR1 = yourString.Substring(1, yourString.Length - 1);
                String query1 = "INSERT INTO dbo.CarListSpaceRight (CarListSpaceRight) VALUES " + CSR1;

                SqlCommand cmd1 = new SqlCommand(query1, con1);

                cmd1.ExecuteNonQuery();
            }


            SQLfx Data2 = new SQLfx();

            SqlConnection con2 = Data2.openSQLConnection(); // Open SQL Connection

            String[] CSL = new String[200];
            CSL = CSL1.Split(spearator, count1, StringSplitOptions.None);

            for (int i = 1; i < CSL.Length; i++)
            {
                Console.WriteLine("WE " + CSL[i]);
                CSL[i] = "(" + CSL[i] + ")";
            }
            yourString = String.Join(" , ", CSL);
            if (yourString.Length > 0)
            {
                
                yourString = yourString.Substring(1, yourString.Length - 1);
                CSL1 = yourString.Substring(1, yourString.Length - 1);
                String query2 = "INSERT INTO dbo.CarListSpaceLeft (CarListSpaceLeft) VALUES " + CSL1;

                SqlCommand cmd2 = new SqlCommand(query2, con2);
                cmd2.ExecuteNonQuery();
            }

            frm.textBox2.Text = Data.printString("CarListSpaceRight", "CarListSpaceRight");
            frm.textBox5.Text = Data.printString("CarListSpaceLeft", "CarListSpaceLeft");

            Console.WriteLine(CSR.GetLength(0));

            if (CSL.Length - 1 > 0)
            {
                frm.radioButton2.Checked = true;
            }
            else
            {
                frm.radioButton1.Checked = true;
            }


        }

        private void BtnAddPreset_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);
            
            frm.Show();
            frm.button2.Visible = false;

           



        }

        private void BtnSetPreset_Click(object sender, EventArgs e)
        {
            SQLfx Data1 = new SQLfx();
            SqlConnection con1 = Data1.openSQLConnection(); // Open SQL Connection

            String query1 = "DELETE FROM trialList";
            SqlCommand cmd1 = new SqlCommand(query1, con1);
            cmd1.ExecuteNonQuery();




            SQLfx Data = new SQLfx();
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            String query = "insert into trialList(trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft) select trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft from condPresets where CONVERT(VARCHAR, condLabel)='" + cbPreset.Text + "';";

            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            updateDataTable();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SQLfx Data1 = new SQLfx();
            SqlConnection con1 = Data1.openSQLConnection(); // Open SQL Connection
            String query1 = "DELETE FROM trialList";
            SqlCommand cmd1 = new SqlCommand(query1, con1);
            cmd1.ExecuteNonQuery(); 
            updateDataTable();
        }

        private void BtnRemovePreset_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "DELETE FROM condPresets WHERE CONVERT(VARCHAR, condLabel)='" + cbPreset.Text + "'";

            Console.WriteLine(query);
            cbPreset.Items.Remove(cbPreset.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            button2.PerformClick();
        }

        private void BtnRenamePreset_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);

            frm.Show();
            frm.button1.Visible = false;


        }

        private void BtnBrowsePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdlg  = new FolderBrowserDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fdlg.SelectedPath + @"\";
                txtPath.Text = txtPath.Text.Replace(@"\", @"\\");
                
            }
        }

        private void TxtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            String query = "insert into temptrialList(condLabel, trialType, prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft) select condLabel, trialType, prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft from trialList order by NEWID()";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            button2.PerformClick();

            query = "insert into trialList(condLabel, trialType, prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft) select condLabel, trialType, prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft from temptrialList order by NEWID()";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            updateDataTable();

            query = "DELETE FROM temptrialList";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

        }
    }
}
