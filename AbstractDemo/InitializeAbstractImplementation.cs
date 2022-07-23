using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public class InitializeAbstractImplementation
    {
        public void CallAbstractMethods()
        {
            SqlConnection sqlConnection = new SqlConnection("1.0");
            string data = sqlConnection.LoadAdvanceConfiguration();
            DataAccess sqlConnectio1 = new SqlConnection();


        }
    }
}
