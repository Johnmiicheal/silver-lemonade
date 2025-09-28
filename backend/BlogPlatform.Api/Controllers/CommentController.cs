using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController : ControllerBase
{
    // TODO: Implement comment CRUD operations
    
    [HttpGet("post/{postId}")]
    public IActionResult GetCommentsByPost(int postId)
    {
        return Ok($"Get comments for post {postId}");
    }
    
    [HttpGet("{id}")]
    public IActionResult GetComment(int id)
    {
        return Ok($"Get comment {id}");
    }
    
    [HttpPost]
    public IActionResult CreateComment()
    {
        return Ok("Create comment");
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateComment(int id)
    {
        return Ok($"Update comment {id}");
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteComment(int id)
    {
        return Ok($"Delete comment {id}");
    }
}
