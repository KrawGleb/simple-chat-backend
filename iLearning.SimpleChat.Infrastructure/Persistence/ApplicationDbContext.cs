using iLearning.SimpleChat.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace iLearning.SimpleChat.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{ }

	public DbSet<User> Users { get; set; }
	public DbSet<Message> Messages { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder
			.Entity<Message>()
			.HasOne(m => m.From)
			.WithMany()
			.OnDelete(DeleteBehavior.NoAction);
			
		modelBuilder
			.Entity<Message>()
			.HasOne(m => m.To)
			.WithMany()
			.OnDelete(DeleteBehavior.NoAction);

		base.OnModelCreating(modelBuilder);
	}
}
