namespace BlogPlatform.Api.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsPublished { get; set; }
    
    // Navigation properties
    public string AuthorId { get; set; } = string.Empty;
    public User Author { get; set; } = null!;
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
}
