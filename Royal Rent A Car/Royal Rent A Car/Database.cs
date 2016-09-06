using MetroFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Rent_A_Car
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public Database()
        {
            con = new SqlConnection();
            con.ConnectionString = " ";

        }

        //public void openCon()
        //{
        //    con.Open();
        //}

        public void closeCon()
        {
            con.Close();
        }

        public int Save_Del_Update(string query)
        {
            int rows;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = " ";
                con.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connection");
            }
            cmd = new SqlCommand(query, con);
            rows = cmd.ExecuteNonQuery();
            cmd.Dispose();
            closeCon();
            return rows;
        }

        public DataTable GetData(string query1)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "";
                con.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connection");
            }
            SqlDataAdapter da = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeCon();
            return dt;
        }

        public SqlDataReader showdata(string query2)
        {
            con = new SqlConnection();
            con.ConnectionString = "";
            con.Open();
            SqlDataReader myReader;
            SqlCommand myCommand = new SqlCommand(query2, con);
            myReader = myCommand.ExecuteReader();

            return myReader;
        }
    }
}
