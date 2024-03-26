using Microsoft.EntityFrameworkCore;

namespace images.Models
{ 
    public class ImageContext:DbContext
    {
        public ImageContext() : base() { }

        //inject
        public ImageContext(DbContextOptions<ImageContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=OLA;Initial Catalog=imagedb;Integrated Security=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);

        }
        //dbset
        public DbSet<product> Products { get; set; }

    }
}
