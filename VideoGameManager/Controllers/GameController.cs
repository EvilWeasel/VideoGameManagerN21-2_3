using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameManager.DataAccess;

namespace VideoGameManager.Controllers
{
    /// <summary>
    /// Http-Methods - CRUD
    /// - GET --> Read --> Daten kommen über URL ODER Query-Parameter(?)
    /// - POST --> Create --> Daten kommen über response.body
    /// - DELETE --> Delete --> Daten kommen über URL ODER Query-Parameter(?)
    /// - PUT --> Update --> Daten kommen über response.body
    /// </summary>
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

        [HttpPost]
        public async Task<Game> AddGame([FromBody]Game newGame)
        {
            context.Add(newGame);
            await context.SaveChangesAsync();
            return newGame;
        }

        // Erstellen Sie eine Methode über http-get, die ein einzelnes Game-Objekt zurück gibt
        [HttpGet]
        [Route("{id}")]
        public Game GetGameByID(int id) => context.Games.FirstOrDefault((x) => x.ID == id);


        // public Game GetGameByID(int id)
        // {
        //     return context.Games.FirstOrDefault((x) => x.ID == id);
        // }


        // Edit Route: Bearbeiten / Ändern eines Spiels
        // --> "name" : "Lost Arc" --> "name" : "Lost Ark"
        [HttpDelete]
        [Route("{id}")]
        public async Task<Game> DeleteGameByID(int id)
        {
            // Game mit id finden, löschen, speichern, return Game
            var gameToDelete = context.Games.Find(id);
            context.Games.Remove(gameToDelete);
            await context.SaveChangesAsync();
            return gameToDelete;
        }
    }
}
