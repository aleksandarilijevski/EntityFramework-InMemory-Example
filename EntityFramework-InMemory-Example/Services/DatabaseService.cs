using EntityFramework.Models;
using EntityFramework_InMemory_Example.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_InMemory_Example.Services
{
    public class DatabaseService : IDatabaseService
    {
        public async Task CreateSong(Song song)
        {
            using (EFContext efContext = new EFContext())
            {
                efContext.Songs.Add(song);
                await efContext.SaveChangesAsync();
            }
        }

        public async Task<List<Song>> GetAllSongs()
        {
            using(EFContext efContext = new EFContext())
            {
                List<Song> songs = await efContext.Songs.ToListAsync();
                return songs;
            }
        }
    }
}
