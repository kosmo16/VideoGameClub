namespace VideoGamesClub.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using VideoGamesClub.Models;
    using WebMatrix.WebData;
    internal sealed class Configuration : DbMigrationsConfiguration<VideoGamesClubDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VideoGamesClubDb context)
        {
            SeedGames(context);
            SeedNews(context);
            SeedRolesAndMembership();
            SeedUsersInfo(context);
        }

        private void SeedGames(VideoGamesClubDb context)
        {
            context.Games.AddOrUpdate(
                g => g.Name,
                new Game
                {
                    Name = "Watch Dogs",
                    Description = "super",
                    Rating = 5,
                    UserId = 2,
                    IntroduceDate = new DateTime(2014, 1, 1)
                },
                new Game
                {
                    Name = "Game of Thrones",
                    Description = "takiej gry jeszcze nie by³o",
                    Rating = 9,
                    UserId = 3,
                    IntroduceDate = new DateTime(2014, 2, 2)
                },
                new Game
                {
                    Name = "Sunless Sea",
                    Description = "fajna gra, ale nie znam",
                    Rating = 5,
                    UserId = 4,
                    IntroduceDate = new DateTime(2013, 3, 3)
                },
                new Game
                {
                    Name = "Titanfall",
                    Description = " podobno mo¿na przejœæ w 15 minut",
                    Rating = 3,
                    UserId = 1,
                    IntroduceDate = new DateTime(2014, 4, 4)
                },
                new Game
                {
                    Name = "World of Warcraft: Warlords of Draenor",
                    Description = "trudno opisaæ s³owami",
                    Rating = 7,
                    UserId = 7,
                    IntroduceDate = new DateTime(2014, 5, 5)
                }
            );
        }

        private void SeedNews(VideoGamesClubDb context)
        {
            context.News.AddOrUpdate(
                n => n.ShortText,
                new News
                {
                    HeadTitle = "Lorem ipsum",
                    Id = 0,
                    isCollapsed = false,
                    Source = "http://www.google.com",
                    Author = "Józef D¿ugaszwili",
                    ShortText = "Lorem ipsum dolor sit amet, consectetur adipisicing elit 1.",
                    FullText = "Lorem ipsum dolor sit amet, consectetur adipisicing elit." + " Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam. Quisque semper justo at risus. Donec venenatis, turpis vel hendrerit interdum, dui ligula ultricies purus, sed posuere libero dui id orci. Nam congue, pede vitae dapibus aliquet, elit magna vulputate arcu, vel tempus metus leo non est. Etiam sit amet lectus quis est congue mollis. Phasellus congue lacus eget neque. Phasellus ornare, ante vitae consectetuer consequat, purus sapien ultricies dolor, et mollis pede metus eget nisi. Praesent sodales velit quis augue. Cras suscipit, urna at aliquam rhoncus, urna quam viverra nisi, in interdum massa nibh nec erat."
                },
                new News
                {
                    HeadTitle = "Lorem ipsum",
                    Id = 0,
                    isCollapsed = false,
                    Source = "http://www.google.com",
                    Author = "Józef D¿ugaszwili",
                    ShortText = "Lorem ipsum dolor sit amet, consectetur adipisicing elit 2.",
                    FullText = "Lorem ipsum dolor sit amet, consectetur adipisicing elit." + " Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam. Quisque semper justo at risus. Donec venenatis, turpis vel hendrerit interdum, dui ligula ultricies purus, sed posuere libero dui id orci. Nam congue, pede vitae dapibus aliquet, elit magna vulputate arcu, vel tempus metus leo non est. Etiam sit amet lectus quis est congue mollis. Phasellus congue lacus eget neque. Phasellus ornare, ante vitae consectetuer consequat, purus sapien ultricies dolor, et mollis pede metus eget nisi. Praesent sodales velit quis augue. Cras suscipit, urna at aliquam rhoncus, urna quam viverra nisi, in interdum massa nibh nec erat."
                },
                new News
                {
                    HeadTitle = "Lorem ipsum",
                    Id = 0,
                    isCollapsed = false,
                    Source = "http://www.google.com",
                    Author = "Józef D¿ugaszwili",
                    ShortText = "Lorem ipsum dolor sit amet, consectetur adipisicing elit 3.",
                    FullText = "Lorem ipsum dolor sit amet, consectetur adipisicing elit." + " Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam. Quisque semper justo at risus. Donec venenatis, turpis vel hendrerit interdum, dui ligula ultricies purus, sed posuere libero dui id orci. Nam congue, pede vitae dapibus aliquet, elit magna vulputate arcu, vel tempus metus leo non est. Etiam sit amet lectus quis est congue mollis. Phasellus congue lacus eget neque. Phasellus ornare, ante vitae consectetuer consequat, purus sapien ultricies dolor, et mollis pede metus eget nisi. Praesent sodales velit quis augue. Cras suscipit, urna at aliquam rhoncus, urna quam viverra nisi, in interdum massa nibh nec erat."
                }
            );
        }


        private void SeedRolesAndMembership()
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "Users", "Id", "Nick", autoCreateTables: true);

            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;
            string adminRole = "administrator";

            if (!roles.RoleExists(adminRole))
            {
                roles.CreateRole(adminRole);
            }

            if (membership.GetUser("admin", false) == null)
            {
                membership.CreateUserAndAccount("admin", "admin");
            }
            if (!roles.GetRolesForUser("admin").Contains(adminRole))
            {
                roles.AddUsersToRoles(new[] { "admin" }, new[] { adminRole });
            }

            if (membership.GetUser("user", false) == null)
            {
                membership.CreateUserAndAccount("user", "user");
            }

            if (membership.GetUser("janko", false) == null)
            {
                membership.CreateUserAndAccount("janko", "passwordjanko");
            }

            if (membership.GetUser("takijeden", false) == null)
            {
                membership.CreateUserAndAccount("takijeden", "passwordtakijeden");
            }
        }

        private void SeedUsersInfo(VideoGamesClubDb context)
        {
            context.Users.AddOrUpdate(
                u => u.Nick,
                new User
                {
                    Nick = "user",
                    Name = "Adam",
                    Surname = "Kowalski"
                },
                new User
                {
                    Name = "Jan",
                    Surname = "Kowal",
                    Nick = "janko",
                    Email = "jankowal@gmail.com",
                    Sex = "m",
                    BirthDate = new DateTime(1987, 5, 2)
                },
                new User
                {
                    Name = "Adam",
                    Surname = "Madam",
                    Nick = "takijeden",
                    Email = "dwaplusdwa@wp.pl",
                    Sex = "m",
                    BirthDate = new DateTime(1995, 3, 1)
                }
            );
        }
    }
}
