using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Review.Controllers
{
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
       ReviewController respository;

       public ReviewController()
       {
           respository = new ReviewController();
       }
        // GET api/values
        [HttpGet]
        public IEnumerable<ReviewController> GetAll()
        {
            return respository.GetAll();
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
