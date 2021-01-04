using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public static class GetData
    {
        [FunctionName("GetData")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            var results = new Data[] {
                new Data { Id = 1, Name = "Sato" },
                new Data { Id = 2, Name = "Suzuki" }
             };

            return new JsonResult(results);
        }
    }

    public class Data {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
