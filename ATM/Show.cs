using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Show
    {
        private static int accNum;
        public int AccNum
        {
            set
            {
                accNum = value;
            }
            get
            {
                return accNum;
            }
        }
    }
}
