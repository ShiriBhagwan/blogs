using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostAndBlogging.Api.Models;
using PostAndBlogging.Api.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAndBlogging.Api.Controllers
{
    [Route("api/blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        private readonly IDataRepository<Blogs> _dataRepository;

        public BlogController(IDataRepository<Blogs> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Blog
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            IEnumerable<Blogs> blogs = _dataRepository.GetAll();
            return Ok(blogs);
        }

        // GET: api/Blog/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Blogs blog = _dataRepository.Get(id);

            if (blog == null)
            {
                return NotFound("The Blog record couldn't be found.");
            }

            return Ok(blog);
        }

        // POST: api/Blog
        [HttpPost]
        public IActionResult Post([FromBody] Blogs blog)
        {
            if (blog == null)
            {
                return BadRequest("blog is null.");
            }

            _dataRepository.Add(blog);
            return CreatedAtRoute(
                  "Get",
                  new { Id = blog.ID },
                  blog);
        }

        // PUT: api/Blog/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Blogs blog)
        {
            if (blog == null)
            {
                return BadRequest("blog is null.");
            }

            Blogs blogToUpdate = _dataRepository.Get(id);
            if (blogToUpdate == null)
            {
                return NotFound("The Blog record couldn't be found.");
            }

            _dataRepository.Update(blogToUpdate, blog);
            return NoContent();
        }

        // DELETE: api/Blog/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Blogs blog = _dataRepository.Get(id);
            if (blog == null)
            {
                return NotFound("The Blog record couldn't be found.");
            }

            _dataRepository.Delete(blog);
            return NoContent();
        }
    }
}