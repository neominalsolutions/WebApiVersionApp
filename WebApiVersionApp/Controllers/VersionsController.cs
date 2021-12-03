using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiVersionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    // Default 1.0
    public class VersionsController : ControllerBase
    {
        [HttpGet("test")]
        [MapToApiVersion("1.0")]
        public string Get()
        {
            return "V1 Result";
        }

        [HttpGet("test")]
        [MapToApiVersion("2.0")]
        public string GetVersion2()
        {
            return "V2 Result";
        }

        [HttpGet("products/{id}")]
        [MapToApiVersion("3.0")]
        public string GetProducts(string id)
        {
            return "Products";
        }

    }


    //[Route("api/versions")]
    //[ApiController]

    //public class Versions2Controller : ControllerBase
    //{
        
    //}
}
