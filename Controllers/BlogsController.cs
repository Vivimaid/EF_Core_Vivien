using EF_Core_Vivien.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Reflection.Metadata;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF_Core_Vivien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        public BloggingContext db { get; set; }
        public BlogsController() {

            db = new BloggingContext();
            
        }
        // GET: api/<BlogsController>
        [HttpGet]
        public List<Blog> Get()
        {
            List<Blog> blogs = db.Blogs.ToList();

            return blogs;
        }

        // GET api/<BlogsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var blog = db.Blogs
                .Where(b => b.BlogId == id);
            return blog.ToJson();
        }

        // POST api/<BlogsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlogsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            
        }
    }
}
