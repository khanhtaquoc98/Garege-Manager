using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gara_DAL
{
    public class DBConnection
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Gara;Integrated Security=True");
    }
}
