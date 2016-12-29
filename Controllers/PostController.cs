using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Service.Interfaces;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostData _repo;
        public PostController (IPostData repo)
        {
          _repo = repo;
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetPost()
        {
            return Ok(_repo.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            
                var cm = _repo.Get(id);

            return Ok(cm) ;
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
