using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore_01.Data;
using NetCore_01.Models;

namespace NetCore_01.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<Post> posts = new List<Post>();

            using (BlogContext db = new BlogContext())
            {
                posts = db.Posts.ToList<Post>();
            }

            return Ok(posts);
        }
    }
}
