using Swashbuckle.Swagger;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Web.Http.Description;

namespace By56.API.TransitReport.APIBehand.Common.swagger
{
    /// <summary>
    /// 隐藏固定路由的接口文档显示
    /// </summary>
    public class HiddenDocumentFilter : IDocumentFilter
    {
        //public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        //{
        //    foreach (ApiDescription apiDescription in context.ApiDescriptionsGroups.Items.SelectMany(e => e.Items))
        //    {
        //        if (apiDescription.GetControllerAttributes().OfType<HiddenApiAttribute>().Count() == 0
        //            && apiDescription.GetActionAttributes().OfType<HiddenApiAttribute>().Count() == 0) continue;

        //        var key = "/" + apiDescription.RelativePath.TrimEnd('/');
        //        if (!key.Contains("/test/") && swaggerDoc.Paths.ContainsKey(key))
        //            swaggerDoc.Paths.Remove(key);
        //    }
        //}

        /// <summary>
        /// 过滤国定路由的文档
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiExplorer"></param>
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            if (swaggerDoc != null)
            {
                IDictionary<string, PathItem> newPaths = new Dictionary<string, PathItem>();

                foreach (var item in swaggerDoc.paths)
                {
                    if (item.Key.Contains("api/ReportBehand"))
                    {
                        newPaths.Add(item.Key, item.Value);
                    }
                }
                swaggerDoc.paths = newPaths;
            }
        }
    }
}