using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Rent_A_Car
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        Database db = new Database();
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            
            string username, password;
            //try
            //{

                //if (Txt_Username.Text.Length > 0)
                //{
                //    errorProvider1.Clear();
                //    username = Txt_Username.Text;
                //}
                //else
                //{
                //    errorProvider1.SetError(Txt_Username, "Username is required");
                //}


                //if (Txt_Password.Text.Length > 3)
                //{
                //    errorProvider2.Clear();
                //    password = Txt_Password.Text;
                //}
                //else if (Txt_Password.Text.Length == 0)
                //{
                //    errorProvider2.SetError(Txt_Password, "Password is required");
                //}
                //    username = Txt_Username.Text;
                //    password = Txt_Password.Text;
                //    String query1 = ("select * from Login_Table where User_Name='" + username + "'and Password='" + password + "'");
                //    DataTable dt = db.GetData(query1);


                //    if (dt.Rows.Count > 0)
                //    {
                //        Main_Menu mn = new Main_Menu();
                //        mn.Show();
                //        Close();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Invalid Login please check your username and password");
                //    }
                //}

                //catch (Exception)
                //{
                //    MessageBox.Show("Exception");
                //}

            
        }
    }
}
