using PC_helper.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace PC_helper.Data
{
  
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Motherboard> Motherboards { get; set;}
        public DbSet<RAM> RAMs { get; set; }
		
	}

    
}
