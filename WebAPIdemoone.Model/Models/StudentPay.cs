using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIdemoone.Model.Models
{
    /// <summary>
    /// 学生缴费表
    /// </summary>
    public class StudentPay
    {
        /// <summary>
        /// 费用项id
        /// </summary>
        public int PayId { get; set; }


        /// <summary>
        /// 学号
        /// </summary>
        public string StuNo { get; set; }


        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>

        public DateTime CreateTime { get; set; }
    }
}
