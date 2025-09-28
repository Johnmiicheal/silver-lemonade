using Microsoft.AspNetCore.Identity;

namespace BlogPlatform.Api.Models;

public class User : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string ProfileImageUrl { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    // Navigation properties
    public ICollection<Post> Posts { get; set; } = new List<Post>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
