﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VideoGamesClub.Models
{
    public class VideoGamesClubDb : DbContext
    {
        public VideoGamesClubDb()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}