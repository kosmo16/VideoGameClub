using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGamesClub.Models
{
    public class Exchange
    {
        public int Id { get; set; }
        public int User1 { get; set; }
        public int User2 { get; set; }
        public int Game1 { get; set; }
        public int Game2 { get; set; }
    }
}