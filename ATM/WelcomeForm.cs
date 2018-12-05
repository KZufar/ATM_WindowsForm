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
    public partial class WelcomeForm : Form
    {
        DBConnection connection = new DBConnection();
        Show show = new Show();
        public WelcomeForm()
        {
            InitializeComponent();
            btnWelcomeToLogin.Visible = true;
            btnToWelcome.Visible = false;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnWelcomeToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnBalanceForm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;
            //BalanceForm balanceForm = new BalanceForm();
            //balanceForm.Show();
            //this.Hide();

            try
            {
                con.Open();
                int account = show.AccNum;
                int balance = 0;
                cmd.CommandText = "SELECT * FROM [Accounts] WHERE accNumber = '" + account + "'";
                readdata = cmd.ExecuteReader();
                readdata.Read();
                balance= int.Parse(readdata["accBalance"].ToString());
                labelBalance.Visible = true;
                label1.Visible = true;
                btnBalanceForm.Visible = false;
                btnHistoryForm.Visible = false;
                btnChangePINForm.Visible = false;
                btnTransferForm.Visible = false;
                btnWithdrawForm.Visible = false;
                btnWelcomeToLogin.Visible = false;
                btnToWelcome.Visible = true;
                labelBalance.Text = Convert.ToString(balance)+ " руб.";
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToWelcome_Click(object sender, EventArgs e)
        {
            labelBalance.Visible = false;
            label1.Visible = false;
            btnBalanceForm.Visible = true;
            btnHistoryForm.Visible = true;
            btnChangePINForm.Visible = true;
            btnTransferForm.Visible = true;
            btnWithdrawForm.Visible = true;
            btnWelcomeToLogin.Visible = true;
            btnToWelcome.Visible = false;
        }

        private void btnWithdrawForm_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm();
            withdrawForm.Show();
            this.Hide();
        }

        private void btnLoanForm_Click(object sender, EventArgs e)
        {
            ChangePINForm changeForm = new ChangePINForm();
            changeForm.Show();
            this.Hide();
        }

        private void btnTransferForm_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.Show();
            this.Hide();
        }

        private void btnHistoryForm_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Hide();
        }
    }
}
