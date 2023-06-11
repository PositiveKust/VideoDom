using System.Data.Entity;

namespace ServerVideoDom
{
    class APContext : DbContext
    {
        public DbSet<DownloadVideo> DownloadVideos { get; set; }
        public APContext() : base("DefaultConnection") { }
    }
}
