using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public abstract class DataAccess
    {
        protected DataAccess(string version)
        {
            DataBaseVersion = version;
        }
        protected DataAccess()
        {
        }
        private string DataBaseVersion;
        public string LoadConfiguration()
        {
            return "This is my Generic Data connection";
        }

        public virtual string LoadAdvanceConfiguration()
        {
            return "This is an advanced version of connection";
        }

        public abstract void SaveConfiguration();
        public abstract string DeleteConfiguration();
    }
}
