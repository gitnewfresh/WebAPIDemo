using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using WebAPIdemoone.BLL;
using WebAPIdemoone.Model;
using WebAPIdemoone.Model.Models;

namespace WebAPIdemoone.Controllers
{
    /// <summary>
    /// 学生
    /// </summary>
    public class StudentController : ApiController
    {

        StudentBLL StudentBLL = new StudentBLL();
     
        /// <summary>
        /// 缴费
        /// </summary>
        /// <param name="cost">费用</param>
        /// <param name="costId">费用项ID</param>
        /// <param name="stuNo">学号</param>
        /// <returns></returns>
       [HttpPost]
        public MessageModel<bool> Pay(int cost,int costId, string stuNo)
        {

           bool result=  StudentBLL.PayTuition(cost, costId, stuNo);

            return new MessageModel<bool>() { status = 200, msg = "成功",response= result };
        }

        /// <summary>
        /// 根据条件查询学生信息并分页
        /// </summary>
        /// <param name="studentViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public PageModel<Student>Query(StudentViewModel studentViewModel,int page,int size)
        {
            int countCount = 0;
            var list = StudentBLL.QueyPageList(studentViewModel, countCount, page, size);
            return new PageModel<Student>() { data = list, dataCount = countCount };

        }
    }
}