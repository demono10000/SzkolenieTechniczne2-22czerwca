using Microsoft.EntityFrameworkCore;
using St2DoKolokwium.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St2DoKolokwium.Storage
{
	public class UserContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<CompetitionType> CompetitionTypes { get; set; }
		public UserContext(DbContextOptions options) : base(options) { }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseInMemoryDatabase("UserDb");
			}
		}
	}
}
