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

namespace ATM
{
    public partial class ChangePINForm : Form
    {
        DBConnection connection = new DBConnection();
        Show show = new Show();
        public ChangePINForm()
        {
            InitializeComponent();
            textOldPIN.MaxLength = 4;
            textNewPIN.MaxLength = 4;
        }

        private void btnToWelcome_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        private void btnChangePIN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;

            try
            {
                con.Open();
                int account = show.AccNum;
                int oldPIN = int.Parse(textOldPIN.Text);
                int newPIN = int.Parse(textNewPIN.Text);
                int oldPINDB = 0;
                cmd.CommandText = "SELECT accPIN FROM [Accounts] WHERE accNumber = '" + account + "'";
                cmd.ExecuteNonQuery();
                readdata = cmd.ExecuteReader();
                readdata.Read();
                oldPINDB = int.Parse(readdata["accPIN"].ToString());
                con.Close();

                if (oldPIN==oldPINDB)
                {
                    MessageBox.Show("Выполнено успешно!");
                    WelcomeForm Welcome = new WelcomeForm();
                    con = new SqlConnection(connection.Con);
                    SqlCommand cmda = new SqlCommand("Command String", con);
                    con.Open();
                    cmda.CommandText = "UPDATE [Accounts] SET accPIN = '" + newPIN + "' WHERE accNumber = '" + account + "'";
                    cmda.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    Welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный PIN код! Пожалуйста, попробуйте еще раз!");
                    textOldPIN.Clear();
                    textNewPIN.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
