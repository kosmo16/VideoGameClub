using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGamesClub.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Adress { get; set; }
    }
}