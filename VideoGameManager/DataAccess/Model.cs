using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoGameManager.DataAccess
{
    public class GameGenre
    {
        // Primary Key - Datenbank
        public int ID { get; set; }
        [MaxLength(150)]
        [Required]
        public string Name { get; set; } = string.Empty;
        public List<Game> Games { get; set; }
    }

    public class Game
    {
        public int ID { get; set; }
        [MaxLength(150)]
        [Required]
        public string Name { get; set; } = string.Empty;
        public int PersonalRating { get; set; }
        // One-to-Many-Relationship
        public GameGenre Genre { get; set; }
    }
}
