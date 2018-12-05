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
    public partial class LoginForm : Form
    {
        DBConnection connection = new DBConnection();
        Show show = new Show();
        public LoginForm()
        {
            InitializeComponent();
            textPIN.PasswordChar = '*';
            textPIN.MaxLength = 4;
            textCardNum.MaxLength = 4;
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;

            try
            {
                con.Open();
                int account = int.Parse(textCardNum.Text);
                int pin = int.Parse(textPIN.Text);
                int accountDB = 0;
                int pinDB = 0;
                string name = null;
                cmd.CommandText = "SELECT * FROM [Accounts] WHERE accNumber = '" + account + "'";
                readdata = cmd.ExecuteReader();
                while (readdata.Read())
                {
                    accountDB = int.Parse(readdata["accNumber"].ToString());
                    pinDB = int.Parse(readdata["accPIN"].ToString());
                    name = readdata["name"].ToString();
                }
                con.Close();
                con.Dispose();

                if ((account == accountDB) && (pin == pinDB))
                {
                    MessageBox.Show("Вы успешно выполнили вход, " + name);
                    show.AccNum = accountDB;

                    WelcomeForm Welcome = new WelcomeForm();
                    Welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Аккаунт не найден! Пожалуйста, попробуйте еще раз!");
                    textCardNum.Clear();
                    textPIN.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
