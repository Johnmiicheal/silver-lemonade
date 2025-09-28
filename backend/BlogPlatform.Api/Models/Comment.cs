namespace BlogPlatform.Api.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    // Navigation properties
    public int PostId { get; set; }
    public Post Post { get; set; } = null!;
    public string AuthorId { get; set; } = string.Empty;
    public User Author { get; set; } = null!;
}
