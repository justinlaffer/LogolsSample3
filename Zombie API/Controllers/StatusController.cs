using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zombie_API.Controllers
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        // GET api/values
        [HttpGet]
        public List<Status> Get()
        {
            StatusRepository repository = new StatusRepository();

            return repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Status value)
        {
            StatusRepository repository = new StatusRepository();
            repository.Insert(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put ([FromBody] Status value)
        {
            StatusRepository repository = new StatusRepository();
            repository.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete([FromBody] Status value)
        {
             StatusRepository repository = new StatusRepository();
              repository.Delete(value)
        }
    }
}
