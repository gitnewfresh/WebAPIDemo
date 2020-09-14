using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIdemoone.Common;
using WebAPIdemoone.DAL;
using WebAPIdemoone.Model;
using WebAPIdemoone.Model.Models;

namespace WebAPIdemoone.BLL
{
    public class StudentBLL
    {

        StudentDAL dAL = new StudentDAL();
        /// <summary>
        /// 添加学生
        /// </summary>
        public void AddStudent()
        {


        }

        
        /// <summary>
        /// 缴费表
        /// </summary>
        /// <param name="cost">费用项</param>
        /// <param name="costId">费用项ID</param>
        /// <param name="stuNo">学号</param>
        /// <returns></returns>
        public bool PayTuition(int cost,int costId, string stuNo)
        {

            return dAL.PayTuition(cost, costId, stuNo);
           

        }

        /// <summary>
        /// 查询学生信息表
        /// </summary>
        /// <param name="studentViewModel"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Student> QueyPageList(StudentViewModel studentViewModel,   int count,int pageIndex,  int pageSize)
        {
            
            return  dAL.QueyPageList(studentViewModel, ref count, pageIndex, pageSize);

        }
    }
}
