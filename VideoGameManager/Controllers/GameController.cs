using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VideoGameManager.DataAccess;

namespace VideoGameManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly VideoGameDataContext context;
        public GameController(VideoGameDataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Game> GetAllGames()
        {
            return context.Games;
        }
    }
}
