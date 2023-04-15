using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace sampleMVC
{
    [Route("api/[controller]")]
    [ApiController]
    public class wasController : ControllerBase
    {
        // GET: api/was
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/was/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/was
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/was/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/was/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
