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
    public partial class WithdrawForm : Form
    {
        DBConnection connection = new DBConnection();
        Show show = new Show();
        public WithdrawForm()
        {
            InitializeComponent();
           
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;

            try
            {
                con.Open();
                int account = show.AccNum;
                int withdrawBalance = int.Parse(textWithdraw.Text);
                int balance = 0;
                cmd.CommandText = "SELECT accBalance FROM [Accounts] WHERE accNumber = '" + account + "'";
                cmd.ExecuteNonQuery();
                readdata = cmd.ExecuteReader();
                readdata.Read();
                balance = int.Parse(readdata["accBalance"].ToString());
                con.Close();

                if (withdrawBalance<=balance)
                {
                    MessageBox.Show("Выполнено успешно!");
                    WelcomeForm Welcome = new WelcomeForm();
                    con = new SqlConnection(connection.Con);
                    SqlCommand cmda = new SqlCommand("Command String", con);
                    con.Open();
                    int balanceDB = balance - withdrawBalance;
                    cmda.CommandText = "UPDATE [Accounts] SET accBalance = '"+balanceDB+"' WHERE accNumber = '" + account + "'";
                    cmda.ExecuteNonQuery();
                    con.Close();

                    con = new SqlConnection(connection.Con);
                    SqlCommand cmdHistory = new SqlCommand("Command String", con);
                    con.Open();
                    DateTime date = DateTime.Now;
                    String des = "Снятие наличных. Сумма снятия: " + textWithdraw.Text;
                    cmdHistory.CommandText = "INSERT INTO [History] (accNumber, currentBalance, description, accBalance, date) " +
                        "VALUES(@account,@balance,@des,@balanceDB, @date);";
                    cmdHistory.Parameters.AddWithValue("@account", account);
                    cmdHistory.Parameters.AddWithValue("@balance", balance);
                    cmdHistory.Parameters.AddWithValue("@des", des);
                    cmdHistory.Parameters.AddWithValue("@balanceDB", balanceDB);
                    cmdHistory.Parameters.AddWithValue("@date", date);
                    cmdHistory.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    Welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Недостаточно денежных средств! Пожалуйста, попробуйте еще раз!");
                    textWithdraw.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToWelcome_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome= new WelcomeForm();
            welcome.Show();
            this.Hide();
        }
    }
}
