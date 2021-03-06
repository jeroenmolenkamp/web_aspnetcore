﻿using System.IO;
using Digipolis.Web.Swagger;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.SwaggerGen.Application;

namespace Digipolis.Web.Startup
{
    public class ApiExtensionSwaggerSettings : SwaggerSettings<SwaggerResponseDefaults>
    {
        protected override void Configuration(SwaggerGenOptions options)
        {
            options.DescribeAllEnumsAsStrings();
        }
    }
}
