using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIdemoone.DAL
{
    public class DbContext<T> where T : class, new()
    {

        public DbContext()
        {

            Db = new SqlSugarClient(new ConnectionConfig()
            {

                ConnectionString = "DataSource=.;Integrated  Security=true; Initial CataLog=Student",
                DbType = DbType.SqlServer,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,
              
        });



        }

        public SqlSugarClient Db;
        public SimpleClient<T> CurrentDb { get { return new SimpleClient<T>(Db); } }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public virtual List<T> GetList()
        {

            return CurrentDb.GetList();
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        public virtual bool Delete(dynamic id)
        {

            return CurrentDb.DeleteById(id);

        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public virtual bool Update(T obj)
        {
            return CurrentDb.Update(obj);

        }

        /// <summary>
        /// 分页
        /// </summary>
        public List<T> GetPageList(Expression<Func<T, bool>> whereExpression, PageModel page=null, Expression<Func<T, object>> orderByExpression = null, OrderByType orderByType = OrderByType.Asc)
        {
            PageModel pageModel = new PageModel();
            if (page==null)
            {
                 pageModel = new PageModel() { PageIndex = 1, PageSize = 20, PageCount = 0 };
            }
          
            return CurrentDb.GetPageList(whereExpression, pageModel, orderByExpression, orderByType);

        }
    }
}
