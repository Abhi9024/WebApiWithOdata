using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using WebApiWithOdata.Data;

namespace WebApiWithOdata.Controllers
{
    [Route("api/[controller]")]
    [EnableQuery]
    public class ValuesController : Controller
    {
        private ISampleData _sampleData;

        public ValuesController(ISampleData sampleData)
        {
            _sampleData = sampleData;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _sampleData.GetPersonsList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
