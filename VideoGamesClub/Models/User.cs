using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGamesClub.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public int PasswordHash { get; set; }
    }
}