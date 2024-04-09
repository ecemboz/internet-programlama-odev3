using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication2.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Domain.TblAlbum> Tbl_Album2 { get; set; }
    }
}
