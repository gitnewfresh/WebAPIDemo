using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPIdemoone.Common;
using WebAPIdemoone.Model;
using WebAPIdemoone.Model.Models;

namespace WebAPIdemoone.DAL
{
    public class StudentDAL : DbContext<Student>
    {


        /// <summary>
        /// 交学费
        /// </summary>
        /// <param name="cost">费用</param>
        /// <param name="costId">费用项</param>
        /// <param name="stuNo">学号</param>
        /// <returns></returns>
        public bool PayTuition(int cost, int costId, string stuNo)
        {
            StudentPay studentPay = new StudentPay() { Money = cost, PayId = costId, StuNo = stuNo, CreateTime = DateTime.Now.Date };
            return Db.Insertable<StudentPay>(studentPay).ExecuteCommand() > 0;




        }

      /// <summary>
      /// 查询学生信息并分页
      /// </summary>
      /// <param name="studentViewModel"></param>
      /// <param name="totalCount"></param>
      /// <param name="pageIndex"></param>
      /// <param name="pageSize"></param>
      /// <returns></returns>
        public List<Student> QueyPageList(StudentViewModel studentViewModel, ref int totalCount,int pageIndex = 1, int pageSize = 20)
        {
        
            var queryable = Db.Queryable<Student>();
            queryable.WhereIF(!string.IsNullOrEmpty(studentViewModel.Class), it => it.Class == studentViewModel.Class);
            queryable.WhereIF(!string.IsNullOrEmpty(studentViewModel.StudentNo), it => it.StuNo == studentViewModel.StudentNo);
            queryable.WhereIF(!string.IsNullOrEmpty(studentViewModel.Name), it => it.Name.Contains(studentViewModel.Name));
            return queryable.OrderBy(it => it.Class).ToPageList(pageIndex, pageSize, ref totalCount);

        }


    }
}
