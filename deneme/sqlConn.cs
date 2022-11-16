using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    public class sqlConn
    {
        public SqlConnection con;
        public SqlCommand comm;

        public void runSP(string str)
        {
            con = new SqlConnection(str);
            comm = new SqlCommand("exec dbo.DataSynchronizer", con); //SP to run is defined here
            con.Open();
            comm.ExecuteNonQuery();
            string dosya_yolu = @"C:\Users\Desktop\Debug\logs.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            DateTime dt = DateTime.Now;
            sw.WriteLine(dt+ "The service was ran.");
            sw.Flush();
            sw.Close();
            fs.Close();
            con.Close();
        }




    }
}
