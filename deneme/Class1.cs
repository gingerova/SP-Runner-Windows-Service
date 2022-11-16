using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace deneme
{
    internal class Class1
    {
        string connString = "Data Source=MED-RASYOMED; Initial Catalog=YBDB; User Id=SyncUser1; Password=.sync.user.1.;";
        SqlConnection conn = new SqlConnection(connString);
        
    }
}
