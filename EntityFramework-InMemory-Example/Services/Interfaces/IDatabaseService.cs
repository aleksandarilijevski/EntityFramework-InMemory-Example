using EntityFramework.Models;

namespace EntityFramework_InMemory_Example.Services.Interfaces
{
    public interface IDatabaseService
    {
        public Task CreateSong(Song song);

        public Task<List<Song>> GetAllSongs();
    }
}
