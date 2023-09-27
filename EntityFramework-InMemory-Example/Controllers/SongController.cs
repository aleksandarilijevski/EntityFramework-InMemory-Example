using EntityFramework.Models;
using EntityFramework_InMemory_Example.Services;
using EntityFramework_InMemory_Example.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework_InMemory_Example.Controllers
{
    [Route("api/song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private IDatabaseService _databaseService;

        public SongController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateSong(Song song)
        {
            await _databaseService.CreateSong(song);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllSongs()
        {
            List<Song> songs = await _databaseService.GetAllSongs();
            return Ok(songs);
        }
    }
}
