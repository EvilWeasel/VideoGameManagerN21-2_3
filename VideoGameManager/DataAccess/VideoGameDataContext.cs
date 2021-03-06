using Microsoft.EntityFrameworkCore;

namespace VideoGameManager.DataAccess
{
    public class VideoGameDataContext : DbContext
    {
        public VideoGameDataContext(DbContextOptions<VideoGameDataContext> options) 
            : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameGenre> Genres { get; set; }
    }
}
