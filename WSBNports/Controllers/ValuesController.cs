using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSBNports.Infrastructure;
using WSBNports.Models;

namespace WSBNports.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //private NportRepository<Nport> _repository { get; set; }

        
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nport>>> Get()
        {
            var all = await NportRepository<Nport>.GetItemsAsync(d => d != null);
            var allList = all.ToList();
            return all.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
