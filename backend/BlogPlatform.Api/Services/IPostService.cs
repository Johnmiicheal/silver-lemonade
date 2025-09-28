using BlogPlatform.Api.Models;

namespace BlogPlatform.Api.Services;

public interface IPostService
{
    Task<IEnumerable<Post>> GetAllPostsAsync();
    Task<Post?> GetPostByIdAsync(int id);
    Task<Post> CreatePostAsync(Post post);
    Task<Post?> UpdatePostAsync(int id, Post post);
    Task<bool> DeletePostAsync(int id);
    Task<IEnumerable<Post>> GetPostsByAuthorAsync(string authorId);
    Task<IEnumerable<Post>> GetPostsByTagAsync(string tagSlug);
}
