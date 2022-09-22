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
}
