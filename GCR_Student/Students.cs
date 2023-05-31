using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCR_Student
{
    class Students
    {
        public string Sname { get; set; }
        public string Spassword { get; set; }

        public void Insert(Students s)
        {

            SqlCommand cmd = new SqlCommand(string.Format(
                "insert into Students values ('{0}','{1}')", s.Sname, s.Spassword),
            Connection.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public bool Find(string _name, string _pass)
        {
            Students s = new Students();
            SqlCommand cmd = new SqlCommand(string.Format(
                "select * from Students where name = '{0}' and password = '{1}'", _name, _pass),
                Connection.GetConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            bool check = dr.HasRows;
            dr.Close();
            return check;
        }
    }
}
