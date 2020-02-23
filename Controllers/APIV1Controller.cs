using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace opencosmos.Controllers
{
    [Route("api/v1")]
    public class APIv1Controller : Controller
    {
        [HttpGet]
        public string Index(string query)
        {
            return query;
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult Post(string id)
        {
            return Ok(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(id);
        }
    }
}
