using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIdemoone.Model.Models;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "Data Source=.;Initial Catalog=Student;Integrated Security=SSPI; ",
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
            db.CodeFirst.BackupTable().InitTables(typeof(Pay),typeof(Student),typeof(StudentPay));
        }
    }
}
