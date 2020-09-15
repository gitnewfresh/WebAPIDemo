using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIdemoone.Model
{
    /// <summary>
    /// 请求基类
    /// </summary>
    public class BaseRequest
    {

        public BaseRequest()
        {


        }

        /// <summary>
        /// 页码
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 取的记录条数
        /// </summary>
        public int? Take { get; set; }


        /// <summary>
        /// 排序字段asc
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 排序字段desc
        /// </summary>
        public string OrderByDesc { get; set; }
    }
}
