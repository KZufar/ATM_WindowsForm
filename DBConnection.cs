using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class DBConnection
    {
        private string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zufar\OneDrive\Рабочий стол\Telegram\ATM\Accounts.mdf;Integrated Security=True;";
       
        public string Con
        {
            get
            {
                return con;
            }
        }
    }
}
