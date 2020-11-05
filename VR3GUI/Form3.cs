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

namespace VR3GUI
{
    public partial class Form3 : Form
    {
        Form1 frm = new Form1();
        public Form3(Form1 frm1)
        {
            InitializeComponent();
            frm = frm1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String label = textBox1.Text;
            if (label.Length == 0)
            {
                return;
            }
            

            SQLfx Data1 = new SQLfx();


            SqlConnection con1 = Data1.openSQLConnection(); // Open SQL Connection
            String Uquery = "UPDATE trialList SET condLabel=('" + label + "')" ;
            Console.WriteLine(Uquery);
            SqlCommand cmd1 = new SqlCommand(Uquery, con1);
            cmd1.ExecuteNonQuery();



            SQLfx Data = new SQLfx();
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            String query = "insert into condPresets(condLabel, trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft) select condLabel ,trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft from trialList";
            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            Console.WriteLine(query);
            //Form1 frm = new Form1();


            frm.cbPreset.Items.Add(label);
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            //frm1.updateDataTable();

            this.Close();


        }

        public void Button2_Click(object sender, EventArgs e)
        {
            String label = textBox1.Text;
            if (label.Length == 0)
            {
                return;
            }
            SQLfx Data1 = new SQLfx();
            SqlConnection con1 = Data1.openSQLConnection(); // Open SQL Connection
            //String Uquery = "DELETE from condPresets WHERE condLabel=('" + label + "')";
            String Uquery = "DELETE FROM condPresets WHERE CONVERT(VARCHAR, condLabel)='" + frm.cbPreset.Text + "'";
            Console.WriteLine(Uquery);
            SqlCommand cmd1 = new SqlCommand(Uquery, con1);
            cmd1.ExecuteNonQuery();
            frm.cbPreset.Items.Remove(frm.cbPreset.Text);




            SQLfx Data = new SQLfx();
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection


            Uquery = "UPDATE trialList SET condLabel=('" + label + "')";
            Console.WriteLine(Uquery);
            cmd1 = new SqlCommand(Uquery, con1);
            cmd1.ExecuteNonQuery();


            String query = "insert into condPresets(condLabel, trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft) select condLabel ,trialType,prepost, trialCond, trialBehav, speed, CarSpaceRight, CarSpaceLeft from trialList";
            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            Console.WriteLine(query);
            frm.cbPreset.Items.Add(label);
            this.Close();


        }
    }
}
