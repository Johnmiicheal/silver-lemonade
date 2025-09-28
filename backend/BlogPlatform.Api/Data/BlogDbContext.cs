using BlogPlatform.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogPlatform.Api.Data;

public class BlogDbContext : IdentityDbContext<User>
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostTag> PostTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Post entity
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Content).IsRequired();
            entity.HasOne(e => e.Author)
                  .WithMany(e => e.Posts)
                  .HasForeignKey(e => e.AuthorId);
        });

        // Configure Comment entity
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Content).IsRequired();
            entity.HasOne(e => e.Post)
                  .WithMany(e => e.Comments)
                  .HasForeignKey(e => e.PostId);
            entity.HasOne(e => e.Author)
                  .WithMany(e => e.Comments)
                  .HasForeignKey(e => e.AuthorId);
        });

        // Configure Tag entity
        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Slug).IsRequired().HasMaxLength(50);
            entity.HasIndex(e => e.Slug).IsUnique();
        });

        // Configure PostTag many-to-many relationship
        modelBuilder.Entity<PostTag>(entity =>
        {
            entity.HasKey(e => new { e.PostId, e.TagId });
            entity.HasOne(e => e.Post)
                  .WithMany(e => e.PostTags)
                  .HasForeignKey(e => e.PostId);
            entity.HasOne(e => e.Tag)
                  .WithMany(e => e.PostTags)
                  .HasForeignKey(e => e.TagId);
        });
    }
}
