using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VR3GUI
{ 

    public partial class Form2 : Form
    {
        private readonly Form1 frm1; //readonly is optional (For safety purposes)

        public Form2(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
    }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updatePresetTable();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
            
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "INSERT INTO dbo.CarListSpaceRight (CarListSpaceRight) VALUES (@CarListSpaceRight)";
            //WIPE TABLE ---- String query = "DELETE FROM dbo.CarListSpaceDIRECTION";
            string prev = textBox1.Text;
            if(radioButton4.Checked == true && textBox1.TextLength != 0)
            {
                float value = float.Parse(textBox1.Text) * (float.Parse(txtContinuousCarSpeed.Text) * float.Parse("0.277778")) ;
                textBox1.Text = value.ToString("0.00"); //Convert.ToString(value);
            }

            SqlCommand cmd = new SqlCommand(query, con);
            textBox1.Text = float.Parse(textBox1.Text).ToString("0.00");
            Console.WriteLine("YUYU" + float.Parse(textBox1.Text).ToString("0.00"));
            cmd.Parameters.AddWithValue("@CarListSpaceRight", textBox1.Text);
            textBox1.Text = prev;
            cmd.ExecuteNonQuery();

            textBox2.Text = Data.printString("CarListSpaceRight", "CarListSpaceRight");
            
            //textBox1.Text = "";
        }
        string previousInput = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* Regex r = new Regex("^-{0,1}\d+\.{0,1}\d*$"); // This is the main part, can be altered to match any desired form or limitations
            Match m = r.Match(textBox1.Text);
            if (m.Success)
            {
                previousInput = textBox1.Text;
            }
            else
            {
                textBox1.Text = previousInput;
            }*/

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("NEW KEYYY");
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
           
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "DELETE FROM CarListSpaceRight WHERE ID=(SELECT MAX(Id) FROM CarListSpaceRight)";
            //WIPE TABLE ---- String query = "DELETE FROM dbo.CarListSpaceDIRECTION";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@CarListSpaceRight", textBox1.Text);
            cmd.ExecuteNonQuery();
            //Data.closeSQLConnection(con);
            textBox2.Text = Data.printString("CarListSpaceRight", "CarListSpaceRight");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            /*bool Flag = false;
            int i = 0;
            foreach (char c in textBox6.Text)
            {
                if (c < '0' || c > '9' || i > 3)
                {
                    Flag = true;
                    break;
                }
                i++;
            }
            if (Flag == true)
            {
                textBox6.Text = textBox6.Text.Substring(0, i);
                textBox6.SelectionStart = i;
            }*/
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("NEW KEYYY");
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "INSERT INTO dbo.CarListSpaceLeft (CarListSpaceLeft) VALUES (@CarListSpaceLeft)";
            //WIPE TABLE ---- String query = "DELETE FROM dbo.CarListSpaceDIRECTION";
            string prev = textBox6.Text;
            SqlCommand cmd = new SqlCommand(query, con);
            if (radioButton4.Checked == true && textBox6.TextLength != 0)
            {
                float value = float.Parse(textBox6.Text) * (float.Parse(txtContinuousCarSpeed.Text) * float.Parse("0.277778") );
                textBox6.Text = value.ToString("0.00");
            }

            cmd.Parameters.AddWithValue("@CarListSpaceLeft", textBox6.Text);
            textBox6.Text = prev;
            cmd.ExecuteNonQuery();
            //Data.closeSQLConnection(con);
            textBox5.Text = Data.printString("CarListSpaceLeft", "CarListSpaceLeft");
           // textBox6.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "DELETE FROM CarListSpaceLeft WHERE ID=(SELECT MAX(Id) FROM CarListSpaceLeft)";
            
            SqlCommand cmd = new SqlCommand(query, con);
          
            cmd.ExecuteNonQuery();
           
            textBox5.Text = Data.printString("CarListSpaceLeft", "CarListSpaceLeft");
            textBox6.Text = "";
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
            String farLaneSpace = Data.printString("CarListSpaceLeft", "CarListSpaceLeft") ;
            String closeLaneSpace = Data.printString("CarListSpaceRight", "CarListSpaceRight");

     
            Int32 count = 210;
            String final = "";
            String[] strlist = new String[210];
            String[] strlist1 = new String[210];
            char[] spearator = { ' ' };

            
            // DCP is Array 27
            strlist = farLaneSpace.Split(spearator, count, StringSplitOptions.None);
            strlist1 = closeLaneSpace.Split(spearator, count, StringSplitOptions.None);
            string prev = textBox7.Text;
            if (textBox7.Text != "None") {
                Console.WriteLine("HERE");
               
                if(radioButton4.Checked == true) {
                    textBox7.Text = Convert.ToString(float.Parse(textBox7.Text) * (float.Parse(txtContinuousCarSpeed.Text) * float.Parse("0.277778")));
                }
                if (Math.Abs(float.Parse(strlist[1]) - float.Parse(strlist1[1])) != float.Parse(textBox7.Text)) {
                    strlist[1] = (float.Parse(strlist1[1]) + float.Parse(textBox7.Text)).ToString();
                }
            }
            textBox7.Text = prev;

            String prepost = "None";
            if (radioButton5.Checked == true)
            {
                prepost = "pre";
            }
            else if(radioButton9.Checked == true)
            {
                prepost = "stand";
            }
            else
            {
                prepost = "post";
            }

            String CLSR = Data.printString("CarListSpaceRight", "CarListSpaceRight");
            String trialcond = textBox8.Text ;
            float temp = float.Parse(txtContinuousCarSpeed.Text) * float.Parse("0.277778");
            ///int inter = (int)Math.Routemp);
            String Speed = temp.ToString("0.00");
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO trialList (trialType, trialBehav,CarSpaceRight,CarSpaceLeft,speed,trialCond,prepost) VALUES (@trialType, @trialBehav,@CarSpaceRight,@CarSpaceLeft,@speed,@trialCond,@prepost);";
            cmd.Parameters.AddWithValue("@trialType", cbTrialType.Text);
            cmd.Parameters.AddWithValue("@trialBehav", cbCarBehaviour.Text);
            cmd.Parameters.AddWithValue("@CarSpaceRight", Data.printString("CarListSpaceRight", "CarListSpaceRight"));
            cmd.Parameters.AddWithValue("@CarSpaceLeft", string.Join(" ", strlist));
            cmd.Parameters.AddWithValue("@speed", Speed );
            cmd.Parameters.AddWithValue("@trialCond", trialcond);
            cmd.Parameters.AddWithValue("@prepost", prepost);
            cmd.ExecuteNonQuery();


            if (radioButton7.Checked == true)
            {
                SqlConnection con2 = Data.openSQLConnection(); // Open SQL Connection
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "INSERT INTO trialPresets (trialType, trialBehav,CarSpaceRight,CarSpaceLeft,speed,trialCond,prepost) VALUES (@trialType, @trialBehav,@CarSpaceRight,@CarSpaceLeft,@speed,@trialCond,@prepost);";
                cmd2.Parameters.AddWithValue("@trialType", cbTrialType.Text);
                cmd2.Parameters.AddWithValue("@trialBehav", cbCarBehaviour.Text);
                cmd2.Parameters.AddWithValue("@CarSpaceRight", Data.printString("CarListSpaceRight", "CarListSpaceRight"));
                cmd2.Parameters.AddWithValue("@CarSpaceLeft", string.Join(" ", strlist));
                cmd2.Parameters.AddWithValue("@speed", Speed);
                cmd2.Parameters.AddWithValue("@trialCond", trialcond);
                cmd2.Parameters.AddWithValue("@prepost", prepost);
                cmd2.ExecuteNonQuery();
            }




            String query = "DELETE FROM dbo.CarListSpaceRight";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM dbo.CarListSpaceLeft";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            // cmd.Connection = con;
            this.Hide();

            frm1.updateDataTable();
            this.Close();

        }

        private void cbTrialType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCarBehaviour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtContinuousCarSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void updatePresetTable()
        {
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();

            // cmd.Connection = con;

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Id, trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft  FROM trialPresets", con);
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
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string index  = "-1" ;
    
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

            String query = "DELETE FROM trialPresets WHERE ID= " + index;

            Console.WriteLine(query);
            //WIPE TABLE ---- String query = "DELETE FROM dbo.CarListSpaceDIRECTION";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            updatePresetTable();

        }

        private void Button6_Click(object sender, EventArgs e)
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
            Console.WriteLine(index);
            String query = "insert into trialList(trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft) select trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft from trialPresets where ID=" + index + ";";
            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            frm1.updateDataTable();
            this.Close();

        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
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


            cbTrialType.SelectedIndex = 0;
            cbCarBehaviour.Text = "";
            textBox8.Text = "";
            SQLfx DataC = new SQLfx();
            SqlConnection conC = DataC.openSQLConnection(); // Open SQL Connection

            String queryC = "DELETE FROM CarListSpaceRight; DELETE FROM CarListSpaceLeft";

            SqlCommand cmdC = new SqlCommand(queryC, conC);

            cmdC.ExecuteNonQuery();


            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "SELECT * FROM trialPresets WHERE ID= " + index;

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
            cbTrialType.Text = TrialType;
            cbCarBehaviour.Text = TrialBehav;
            textBox8.Text = trialcond;
            float temp = float.Parse(trialSpeed) / float.Parse("0.277778");
            Console.WriteLine(txtContinuousCarSpeed.Text);
            int inter = (int)Math.Round(temp);
            txtContinuousCarSpeed.Text = Convert.ToString(inter);
            if (prepost.Contains("pre"))
            {
                radioButton5.Checked = true;

            }
            else if (prepost.Contains("stand"))
            {
                radioButton9.Checked = true;

            }
            else
            {
                radioButton6.Checked = true;
            }
            textBox2.Text = CSR1;
            textBox5.Text = CSL1;


            SQLfx Data1 = new SQLfx();

            SqlConnection con1 = Data1.openSQLConnection(); // Open SQL Connection
          
            String[] CSR = new String[200];
            char[] spearator = { ' ' };
            CSR = CSR1.Split(spearator, count1, StringSplitOptions.None);

            for(int i = 1; i < CSR.Length; i++)
            {
                Console.WriteLine("WE " + CSR[i]);
                CSR[i] = "(" + CSR[i] + ")";
            }

            String yourString = String.Join(" , ", CSR);
            if (yourString.Length > 0)
            {
                yourString = yourString.Substring(1, yourString.Length - 1);
                Console.WriteLine("OKAY " + yourString.Substring(1, yourString.Length - 1));
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
            textBox2.Text = Data.printString("CarListSpaceRight", "CarListSpaceRight");
            textBox5.Text = Data.printString("CarListSpaceLeft", "CarListSpaceLeft");

            Console.WriteLine(CSR.GetLength(0));
            Console.WriteLine("RWRTWTW " + CSL.GetLength(0));
            if (CSL.Length -1  > 0)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }







        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
            String farLaneSpace = Data.printString("CarListSpaceLeft", "CarListSpaceLeft");
            String closeLaneSpace = Data.printString("CarListSpaceRight", "CarListSpaceRight");


            Int32 count = 210;
            String final = "";
            String[] strlist = new String[210];
            String[] strlist1 = new String[210];
            char[] spearator = { ' ' };


            // DCP is Array 27
            strlist = farLaneSpace.Split(spearator, count, StringSplitOptions.None);
            strlist1 = closeLaneSpace.Split(spearator, count, StringSplitOptions.None);
            string prev = textBox7.Text;
            if (textBox7.Text != "None")
            {
                Console.WriteLine("HERE");

                if (radioButton4.Checked == true)
                {
                    textBox7.Text = Convert.ToString(float.Parse(textBox7.Text) * (float.Parse(txtContinuousCarSpeed.Text) * float.Parse("0.277778")));
                }
                if (Math.Abs(float.Parse(strlist[1]) - float.Parse(strlist1[1])) != float.Parse(textBox7.Text))
                {
                    strlist[1] = (float.Parse(strlist1[1]) + float.Parse(textBox7.Text)).ToString();
                }
            }
            textBox7.Text = prev;
            

            String prepost = "None";
            if (radioButton5.Checked == true)
            {
                prepost = "pre";
            }
            else if(radioButton9.Checked ==  true)
            {
                prepost = "stand";
            }
            else
            {
                prepost = "post";
            }

            String CLSR = Data.printString("CarListSpaceRight", "CarListSpaceRight");
            String trialcond = textBox8.Text ;
            String Speed = Convert.ToString(float.Parse(txtContinuousCarSpeed.Text) * float.Parse("0.277778"));

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String trialtype = "trialType = '" + cbTrialType.Text + "',";
            String trialBehav = "trialBehav = '" + cbCarBehaviour.Text + "',";
            String CarSpaceRight = "CarSpaceRight = '" + Data.printString("CarListSpaceRight", "CarListSpaceRight") + "',";
            String CarSpaceLeft = "CarSpaceLeft = '" + string.Join(" ", strlist) + "',";
            String speed = "speed = '" + Speed + "',";
            String trialCond = "trialCond = '" + trialcond + "',";
            String pre_post = "prepost = '" + prepost + "'";

            String query1 = "UPDATE trialList SET " + trialtype + trialBehav + CarSpaceRight + CarSpaceLeft + speed + trialCond + pre_post + " WHERE ID=" + ID.Text;
            Console.WriteLine(query1);
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();


            if (radioButton7.Checked == true)
            {
                SqlConnection con2 = Data.openSQLConnection(); // Open SQL Connection
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "INSERT INTO trialPresets (trialType, trialBehav,CarSpaceRight,CarSpaceLeft,speed,trialCond,prepost) VALUES (@trialType, @trialBehav,@CarSpaceRight,@CarSpaceLeft,@speed,@trialCond,@prepost);";
                cmd2.Parameters.AddWithValue("@trialType", cbTrialType.Text);
                cmd2.Parameters.AddWithValue("@trialBehav", cbCarBehaviour.Text);
                cmd2.Parameters.AddWithValue("@CarSpaceRight", Data.printString("CarListSpaceRight", "CarListSpaceRight"));
                cmd2.Parameters.AddWithValue("@CarSpaceLeft", string.Join(" ", strlist));
                cmd2.Parameters.AddWithValue("@speed", Speed);
                cmd2.Parameters.AddWithValue("@trialCond", trialcond);
                cmd2.Parameters.AddWithValue("@prepost", prepost);
                cmd2.ExecuteNonQuery();
            }




            String query = "DELETE FROM dbo.CarListSpaceRight";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM dbo.CarListSpaceLeft";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            this.Hide();

            frm1.updateDataTable();
            this.Close();
        }

        private void Label9_Click_1(object sender, EventArgs e)
        {

        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
