using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace opencosmos.Controllers
{
    [ApiController]
    [Route("api/")]
    public class V1Controller : Controller
    {
        public readonly ILogger<V1Controller> _logger;

        public V1Controller(ILogger<V1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("v1")]
        public string Get(string id)
        {
            _logger.LogInformation($"{id}");
            return id;
        }

        [HttpPost]
        [Route("v1")]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("v1")]
        public IActionResult Delete(string id)
        {
            return Ok(id);
        }
    }
}
