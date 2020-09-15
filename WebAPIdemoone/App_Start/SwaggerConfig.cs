using System.Web.Http;
using WebActivatorEx;
using WebAPIdemoone;
using Swashbuckle.Application;
using System.Reflection;
using System.IO;
using System.Linq;
using API.FrameWork.Filter;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebAPIdemoone
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
     

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {

                        c.IncludeXmlComments(string.Format("{0}/bin/WebAPIdemoone.XML", System.AppDomain.CurrentDomain.BaseDirectory));

                        c.IncludeXmlComments(string.Format("{0}/bin/WebAPIdemoone.Model.XML", System.AppDomain.CurrentDomain.BaseDirectory));

                        c.SingleApiVersion("v1", "WEBAPITEST");
                        c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                        c.CustomProvider((defaultProvider) => new By56.API.TransitReport.APIBehand.Common.swagger.CachingSwaggerProvider(defaultProvider));
                        c.OperationFilter<SwaggerHttpHeaderFilter>();
                    })
                .EnableSwaggerUi(c =>
                    {
                        
                        c.InjectJavaScript(thisAssembly, "WebAPIdemoone.Common.swagger.swagger_lang.js");
                    });
        }
    }
}
