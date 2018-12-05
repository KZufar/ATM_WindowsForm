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
    public partial class HistoryForm : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;
        DBConnection connection = new DBConnection();
        Show show = new Show();

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountsDataSet.History". При необходимости она может быть перемещена или удалена.
            //this.historyTableAdapter.Fill(this.accountsDataSet.History);
            SqlConnection con = new SqlConnection(connection.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            if (con.State == ConnectionState.Closed) con.Open();
            adapter = new SqlDataAdapter("Select * From [History] Where [accNumber] = \'" + show.AccNum + "\'", con);
            adapter.Fill(ds, "History");
            dataGridViewHistory.DataSource = ds.Tables["History"].DefaultView;
            con.Close();
        }

        private void btnToWelcome_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        private void dataGridViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
