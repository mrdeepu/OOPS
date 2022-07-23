using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public class SqlConnection : DataAccess
    {
        public SqlConnection()
        {

        }
        public SqlConnection(string version) : base("1.0") { }
        public override string LoadAdvanceConfiguration()
        {
            string config = base.LoadAdvanceConfiguration();
            return $"{config} + customize version";
        }
        public override string DeleteConfiguration()
        {
            throw new NotImplementedException();
        }

        public override void SaveConfiguration()
        {
            throw new NotImplementedException();
        }
    }
}
