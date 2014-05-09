using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGamesClub.Models
{
    public class News
    {
        public int Id { get; set; }
        public Boolean isCollapsed { get; set; }
        public String HeadTitle { get; set; }
        public String ShortText { get; set; }
        public String FullText { get; set; }
        public String Source { get; set; }
        public String Author { get; set; }
    }
}