using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace VR3GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /////////Clear Databases on Start Up -- Can Remove This To Keep Data
            SQLfx Data = new SQLfx();
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            String query = "DELETE FROM dbo.CarListSpaceRight";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM dbo.CarListSpaceLeft";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM dbo.properties";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM dbo.trialProperties";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM dbo.trialList";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            ///////

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
                        
        }

    }
    public class SQLfx
    {
        public SqlConnection openSQLConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\vr\vr3\VRTSGUI\VRTSGUI\Database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            return con;
        }
        public void closeSQLConnection(SqlConnection con)
        {
            con.Close();

        }
        public void printColumn(String tableName, String Column)
        {
            SqlConnection con = openSQLConnection();
            String str = "select " + Column + " from "+ tableName;
            DataTable Table = new DataTable("TestTable");
            using (SqlCommand _cmd = new SqlCommand(str, con))
            {
                SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
                _dap.Fill(Table);
                con.Close();
                //
            }
            Console.WriteLine(Table.Rows.Count);
            foreach (DataRow dataRow in Table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }

        }
        public String printString(String tableName, String Column)
        {
            SqlConnection con = openSQLConnection();
            String str = "select " + Column + " from "+ tableName;
            String columnToString = "";
            DataTable Table = new DataTable("TestTable");
            using (SqlCommand _cmd = new SqlCommand(str, con))
            {
                SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
                _dap.Fill(Table);
                con.Close();

            }
            //Console.WriteLine(Table.Rows.Count);
            foreach (DataRow dataRow in Table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    //Console.WriteLine(item);
                    columnToString += " " + item;
                }
            }
            return columnToString;

        }public String printCS(String tableName, String Column)
        {
            SqlConnection con = openSQLConnection();
            String str = "select " + Column + " from "+ tableName;
            String columnToString = "";
            DataTable Table = new DataTable("TestTable");
            using (SqlCommand _cmd = new SqlCommand(str, con))
            {
                SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
                _dap.Fill(Table);
                con.Close();

            }
            //Console.WriteLine(Table.Rows.Count);
            foreach (DataRow dataRow in Table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    //Console.WriteLine(item);
                    columnToString += ":" + item;
                }
            }
            return columnToString;

        }
    }

    
}
