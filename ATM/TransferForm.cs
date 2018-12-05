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
    public partial class TransferForm : Form
    {
        DBConnection connection = new DBConnection();
        Show show = new Show();
        public TransferForm()
        {
            InitializeComponent();
            textTransferNum.MaxLength = 4;
        }

        private void btnToWelcome_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome= new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;

            try
            {
                con.Open();
                int account = show.AccNum;
                int transferBalance = int.Parse(textAmountTransfer.Text);
                int transferAccount= int.Parse(textTransferNum.Text);
                int balance = 0;
                int balanceRecipient = 0;
                cmd.CommandText = "SELECT accBalance FROM [Accounts] WHERE accNumber = '" + account + "'";
                readdata = cmd.ExecuteReader();
                readdata.Read();
                balance = int.Parse(readdata["accBalance"].ToString());
                con.Close();
                con = new SqlConnection(connection.Con);
                SqlCommand cmdTransfer = new SqlCommand("Command String", con);
                SqlDataReader readdataTransfer;
                con.Open();
                cmdTransfer.CommandText = "SELECT accBalance FROM [Accounts] WHERE accNumber = '" + transferAccount + "'";
                readdataTransfer = cmdTransfer.ExecuteReader();
                readdataTransfer.Read();
                balanceRecipient = int.Parse(readdataTransfer["accBalance"].ToString());
                con.Close();

                if (transferBalance <= balance)
                {
                    MessageBox.Show("Выполнено успешно!");
                    WelcomeForm Welcome = new WelcomeForm();
                    con = new SqlConnection(connection.Con);
                    SqlCommand cmda = new SqlCommand("Command String", con);
                    con.Open();
                    int balanceDB = balance - transferBalance;
                    cmda.CommandText = "UPDATE [Accounts] SET accBalance = '" + balanceDB + "' WHERE accNumber = '" + account + "'";
                    cmda.ExecuteNonQuery();

                    con = new SqlConnection(connection.Con);
                    SqlCommand cmdaTransfer = new SqlCommand("Command String", con);
                    con.Open();
                    int balanceDBRecipient = balanceRecipient + transferBalance;
                    cmdaTransfer.CommandText = "UPDATE [Accounts] SET accBalance = '" + balanceDBRecipient + "' WHERE accNumber = '" + transferAccount + "'";
                    cmdaTransfer.ExecuteNonQuery();
                    con.Close();

                    con = new SqlConnection(connection.Con);
                    SqlCommand cmdHistory = new SqlCommand("Command String", con);
                    con.Open();
                    DateTime date = DateTime.Now;
                    String des = "Перевод на карту " + textTransferNum.Text + ". Сумма перевода: " + textAmountTransfer.Text;
                    cmdHistory.CommandText = "INSERT INTO [History] (accNumber, currentBalance, description, accBalance, date) " +
                        //"VALUES('" + account + "', '" + balance + "','" + des + "','" + balanceDB + "');";
                        "VALUES(@account,@balance,@des,@balanceDB, @date);";
                    cmdHistory.Parameters.AddWithValue("@account", account);
                    cmdHistory.Parameters.AddWithValue("@balance", balance);
                    cmdHistory.Parameters.AddWithValue("@des", des);
                    cmdHistory.Parameters.AddWithValue("@balanceDB", balanceDB);
                    cmdHistory.Parameters.AddWithValue("@date", date);
                    cmdHistory.ExecuteNonQuery();
                    con.Close();


                    con = new SqlConnection(connection.Con);
                    SqlCommand cmdHistory1 = new SqlCommand("Command String", con);
                    con.Open();
                    DateTime date1 = DateTime.Now;
                    String des1 = "Начисление от " + account + ". Сумма начисления: " + textAmountTransfer.Text;
                    cmdHistory1.CommandText = "INSERT INTO [History] (accNumber, currentBalance, description, accBalance, date) " +
                        //"VALUES('" + account + "', '" + balance + "','" + des + "','" + balanceDB + "');";
                        "VALUES(@account,@balance,@des,@balanceDB, @date);";
                    cmdHistory1.Parameters.AddWithValue("@account", transferAccount);
                    cmdHistory1.Parameters.AddWithValue("@balance", balanceRecipient);
                    cmdHistory1.Parameters.AddWithValue("@des", des1);
                    cmdHistory1.Parameters.AddWithValue("@balanceDB", balanceDBRecipient);
                    cmdHistory1.Parameters.AddWithValue("@date", date);
                    cmdHistory1.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    Welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Недостаточно денежных средств! Пожалуйста, попробуйте еще раз!");
                    textTransferNum.Clear();
                    textAmountTransfer.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
