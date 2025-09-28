using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
    // TODO: Implement blog post CRUD operations
    
    [HttpGet]
    public IActionResult GetPosts()
    {
        return Ok("Get all posts");
    }
    
    [HttpGet("{id}")]
    public IActionResult GetPost(int id)
    {
        return Ok($"Get post {id}");
    }
    
    [HttpPost]
    public IActionResult CreatePost()
    {
        return Ok("Create post");
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdatePost(int id)
    {
        return Ok($"Update post {id}");
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeletePost(int id)
    {
        return Ok($"Delete post {id}");
    }
}
