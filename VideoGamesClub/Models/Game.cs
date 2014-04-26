using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGamesClub.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; }
        public DateTime IntroduceDate { get; set; }
    }
}