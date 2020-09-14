using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace WebAPIdemoone.Model.Models
{
    /// <summary>
    /// 学生表
    /// </summary>
    public  class Student
    {   
        /// <summary>
        /// 自增ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [SugarColumn(ColumnDataType ="nvarchar",Length =50,IsNullable =false,ColumnDescription ="学号")]
        public string StuNo { get; set; }


        /// <summary>
        /// 姓名
        /// </summary>
        [SugarColumn(ColumnDataType ="varchar",Length =20,IsNullable =false,ColumnDescription ="学生姓名")]
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
       public int Age { get; set; }
       
      /// <summary>
      /// 班级
      /// </summary>
      [SugarColumn(ColumnDataType="nvarchar",Length =10,IsNullable =false)]
       public string Class { get; set; }

      
        /// <summary>
        /// 学生宿舍
        /// </summary>
       [SugarColumn(ColumnDataType ="nvarchar",Length =10,IsNullable =false)]
       public string Dormitory { get; set; }
       
        /// <summary>
        /// 身份证
        /// </summary>
       [SugarColumn(ColumnDataType ="nvarchar",Length =50,IsNullable =false)]
       public string IDCard { get; set; }
       

        /// <summary>
        /// 家庭住址
        /// </summary>
       [SugarColumn(ColumnDataType = "varchar", Length = 100, IsNullable = false)]
       public string Address { get; set; }

    }
}
