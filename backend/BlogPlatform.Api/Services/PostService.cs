using BlogPlatform.Api.Data;
using BlogPlatform.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPlatform.Api.Services;

public class PostService : IPostService
{
    private readonly BlogDbContext _context;

    public PostService(BlogDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Post>> GetAllPostsAsync()
    {
        return await _context.Posts
            .Include(p => p.Author)
            .Include(p => p.PostTags)
            .ThenInclude(pt => pt.Tag)
            .Where(p => p.IsPublished)
            .OrderByDescending(p => p.CreatedAt)
            .ToListAsync();
    }

    public async Task<Post?> GetPostByIdAsync(int id)
    {
        return await _context.Posts
            .Include(p => p.Author)
            .Include(p => p.Comments)
            .ThenInclude(c => c.Author)
            .Include(p => p.PostTags)
            .ThenInclude(pt => pt.Tag)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Post> CreatePostAsync(Post post)
    {
        post.CreatedAt = DateTime.UtcNow;
        post.UpdatedAt = DateTime.UtcNow;
        
        _context.Posts.Add(post);
        await _context.SaveChangesAsync();
        return post;
    }

    public async Task<Post?> UpdatePostAsync(int id, Post post)
    {
        var existingPost = await _context.Posts.FindAsync(id);
        if (existingPost == null) return null;

        existingPost.Title = post.Title;
        existingPost.Content = post.Content;
        existingPost.Summary = post.Summary;
        existingPost.IsPublished = post.IsPublished;
        existingPost.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return existingPost;
    }

    public async Task<bool> DeletePostAsync(int id)
    {
        var post = await _context.Posts.FindAsync(id);
        if (post == null) return false;

        _context.Posts.Remove(post);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Post>> GetPostsByAuthorAsync(string authorId)
    {
        return await _context.Posts
            .Include(p => p.Author)
            .Include(p => p.PostTags)
            .ThenInclude(pt => pt.Tag)
            .Where(p => p.AuthorId == authorId && p.IsPublished)
            .OrderByDescending(p => p.CreatedAt)
            .ToListAsync();
    }

    public async Task<IEnumerable<Post>> GetPostsByTagAsync(string tagSlug)
    {
        return await _context.Posts
            .Include(p => p.Author)
            .Include(p => p.PostTags)
            .ThenInclude(pt => pt.Tag)
            .Where(p => p.PostTags.Any(pt => pt.Tag.Slug == tagSlug) && p.IsPublished)
            .OrderByDescending(p => p.CreatedAt)
            .ToListAsync();
    }
}
