
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Filters;

namespace API.FrameWork.Filter
{
    /// <summary>
    /// 通过参数的方式传入Authorization头文件
    /// </summary>
    public class SwaggerHttpHeaderFilter : IOperationFilter
    {
        /// <summary>
        /// 生成token输入框
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiDescription"></param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null) operation.parameters = new List<Parameter>();
            var filterPipeline = apiDescription.ActionDescriptor.GetFilterPipeline();//过滤器
            var isAuthorized = filterPipeline.Select(filterInfo => filterInfo.Instance).Any(filter => filter is APIAuthorizeAttribute);//判断是否添加权限过滤器   
            var allowAnonymous = apiDescription.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any() ||
                                 apiDescription.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any(); //判断是否允许匿名方法 
            //if (isAuthorized && !allowAnonymous)
            {
                //operation.parameters.Add(new Parameter { name = "Authorization", @in = "header", description = "Token", required = false, type = "string" });
                operation.parameters.Add(new Parameter { name = "X-JWT-TOKEN", @in = "header", description = "Token", required = false, type = "string" });
            }

            //operation.parameters.Add(new Parameter { name = "X-USER-LOGINNAME", @in = "header", description = "Token", required = false, type = "string" });
        }
    }

    /// <summary>
    /// 通过参数的方式传入Authorization头文件
    /// </summary>
    public class SwaggerHttpHeaderBehandFilter : IOperationFilter
    {
        /// <summary>
        /// 生成token输入框
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiDescription"></param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null) operation.parameters = new List<Parameter>();
            var filterPipeline = apiDescription.ActionDescriptor.GetFilterPipeline();//过滤器
            var isAuthorized = filterPipeline.Select(filterInfo => filterInfo.Instance).Any(filter => filter is APIAuthorizeAttribute);//判断是否添加权限过滤器   
            var allowAnonymous = apiDescription.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any() ||
                                 apiDescription.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any(); //判断是否允许匿名方法 
            if (isAuthorized && !allowAnonymous)
            {
                operation.parameters.Add(new Parameter { name = "X-USER-LOGINNAME", @in = "header", description = "Token", required = false, type = "string" });
            }
        }
    }


    /// <summary>
    /// 通过参数的方式传入Authorization头文件
    /// </summary>
    public class SwaggerHttpHeaderSupFilter : IOperationFilter
    {
        /// <summary>
        /// 生成token输入框
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiDescription"></param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null) operation.parameters = new List<Parameter>();
            var filterPipeline = apiDescription.ActionDescriptor.GetFilterPipeline();//过滤器
            var isAuthorized = filterPipeline.Select(filterInfo => filterInfo.Instance).Any(filter => filter is APIAuthorizeAttribute);//判断是否添加权限过滤器   
            var allowAnonymous = apiDescription.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any() ||
                                 apiDescription.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any(); //判断是否允许匿名方法 
            if (isAuthorized && !allowAnonymous)
            {
                operation.parameters.Add(new Parameter { name = "X-JWT-TOKEN", @in = "header", description = "Token", required = false, type = "string" });
                operation.parameters.Add(new Parameter { name = "X-SUPPLIERID", @in = "header", description = "Token", required = false, type = "string" });
            }
        }
    }
}
