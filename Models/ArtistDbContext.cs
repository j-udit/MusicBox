using Microsoft.EntityFrameworkCore;

namespace MusicBox.Models{
public class ArtistDbContext : DbContext{
    public ArtistDbContext(DbContextOptions<ArtistDbContext> options)
        : base(options){

        }
        public DbSet<Artist> Artist{get;set;}
        public DbSet<Album> Albums{get;set;}

    }
}