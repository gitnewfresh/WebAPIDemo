using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIdemoone.Model.Models
{

    /// <summary>
    /// 费用项表
    /// </summary>
    public  class Pay
    {
        /// <summary>
        /// 费用项Id
        /// </summary>
        [SugarColumn(IsIdentity =true,IsPrimaryKey =true,IsNullable =false)]
        public int id{ get; set; }

        /// <summary>
        /// 费用项类型
        /// </summary>
        public int Type { get; set; }


        /// <summary>
        /// 费用项类型说明
        /// </summary>
        [SugarColumn(ColumnDataType ="nvarchar",Length =50,IsNullable =false)]
        public int Explain { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


       

    }
}
