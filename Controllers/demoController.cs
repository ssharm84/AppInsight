using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myAppInsight.Models;
using System.Net.Http;
namespace myAppInsight.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class demoController:ControllerBase
    {
        private readonly string url = "https://appinsightfunction.azurewebsites.net/api/HttpTrigger1?code=78JN8r5Qe5yZA7Vn223PZWIjPL0ww9fTP8v1aojL6TRfNbDrGPSw5A==";

        public demoController()
        {}

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var text = await response.Content.ReadAsStringAsync();

            return new OkObjectResult(text);
        }
    }
}