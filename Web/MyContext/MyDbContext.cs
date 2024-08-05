using Microsoft.EntityFrameworkCore;
using Model;

namespace Web.MyContext
{
	public class MyDbContext: DbContext
	{
        public MyDbContext()
        {
            
        }

		public MyDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Staff> Staff { get; set; }
		
	}
}
