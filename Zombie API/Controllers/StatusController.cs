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
        StatusRepository repository;

        
        // GET api/values
        [HttpGet]
        public IEnumerable<Status> Get()
        {
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
        public void Post([FromBody]Status Status)
        {
            repository.Insert(Status);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put ([FromBody] Status Status)
        {
             repository.Update(Status);
        }
        
         // DELETE api/values/5
        public void Delete(int id)
        {
            repository.Delete(id);
        }

    }
}

