using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElevenNote.WebMVC
{
    public class WebApiConfig
    {
        public static void Register()
        {
            GlobalConfiguration
                .Configure(
                x =>
                {
                    x
                    .Formatters
                    .JsonFormatter
                    .SupportedMediaTypes
                    .Add(new MediaTypeHeaderValue("text/html"));

                    x.MapHttpAttributeRoutes();
                }
            );
        }
    }
}