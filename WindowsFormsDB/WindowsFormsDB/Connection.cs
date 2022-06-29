using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsDB
{
    internal static class Connection
    {
        private static string dbstring = "Data Source=DUDZ;Initial Catalog=master;Integrated Security=True";
        private static readonly SqlConnection db = new SqlConnection(dbstring);

        public static SqlConnection DB
        {
            get { return db; }
        }
    }
}
