using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIdemoone.Model
{
    public class StudentViewModel: BaseRequest
    {

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string TelePhone { get; set; }

        /// <summary>
        /// 学号
        /// </summary>

        public string StudentNo { get; set; }

        /// <summary>
        /// 班级
        /// </summary>

        public string Class { get; set; }

    }
}
