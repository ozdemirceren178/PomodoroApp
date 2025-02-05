using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public  class sglbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection connection = new SqlConnection("Data Source=ceren\\SQLEXPRESS;Initial Catalog=pomodoro;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
