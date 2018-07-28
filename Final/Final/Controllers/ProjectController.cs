using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    public class FinalController : Controller
    {
       FinalRepository Repository;

        public FinalController()
        {
            Repository = new FinalRepository();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return Repository. GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            return Repository.Get(id);
        }

    }
}

        

