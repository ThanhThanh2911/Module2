using Microsoft.EntityFrameworkCore;
using News.Core;

namespace News.Data
{
    public class TinTucDataContext : DbContext
    {
        public TinTucDataContext(DbContextOptions<TinTucDataContext> options) : base(options)
        {

        }
        public DbSet<TinTuc> TinTucDatas { get; set; }
    }
}
