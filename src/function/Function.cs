﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Redpanda.OpenFaaS;
using System.Threading.Tasks;

namespace OpenFaaS
{
    public class Function : HttpFunction
    {
        public override Task<IActionResult> HandleAsync( HttpRequest request )
        {
            var result = new
            {
                Message = "Hello!"
            };

            return Task.FromResult( Ok( result ) );
        }
    }
}