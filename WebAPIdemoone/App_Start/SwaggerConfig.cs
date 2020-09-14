using System.Web.Http;
using WebActivatorEx;
using WebAPIdemoone;
using Swashbuckle.Application;
using System.Reflection;
using System.IO;

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
                        
                        c.IncludeXmlComments(@"D:\MyCode\WebAPIdemoone\WebAPIdemoone\App_Data\WebAPIdemoone.xml");
                      
                     
                        c.SingleApiVersion("v1", "WebAPIdemoone");

                     
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.InjectJavaScript(thisAssembly, @" D:\MyCode\WebAPIdemoone\WebAPIdemoone\Common\swagger\swagger_lang.js");
                    });
        }
    }
}
