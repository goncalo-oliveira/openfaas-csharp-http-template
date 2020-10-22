﻿using Microsoft.Extensions.DependencyInjection;
using Redpanda.OpenFaaS;
using System;

namespace OpenFaaS
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddTransient<IHttpFunction, Function>();

            // add your services here.
        }
    }
}
