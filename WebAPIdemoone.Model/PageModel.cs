using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIdemoone.Model
{
    public class PageModel<T>
    {

        /// <summary>
        /// 当前页标
        /// </summary>
        public int pgae { get; set; } = 1;

        /// <summary>
        /// 总页数
        /// </summary>
        public int pageCount { get; set; } = 0;

        /// <summary>
        /// 数据总数
        /// </summary>
        public int dataCount { get; set; } = 0;

        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { get; set; } = 20;


        /// <summary>
        /// 返回数据集合
        /// </summary>
        public List<T> data { get; set; }
    }
}
