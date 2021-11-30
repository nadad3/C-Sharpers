using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class Movies
    {
        public static List<string> genres = new List<string>
        {
         "",
         "Animation",
         "Action",
         "Comedy",
         "Drama",
         "Horror",
         "Mystery",
         "Romance",
         "Science Fiction",
         "Western",
        };
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public int Genre { get; set; }
        public int Score { get; set; }
        public double TotalEarned { get; set; }
        public Movies()
        {
            Id = -1;
            Title = "";
            Year = 0;
            Director = "";
            Genre = 0;
            Score = -1;
            TotalEarned = -1;
        }
        public string GenreText
        {
            get { if ((Genre >= 0) && (Genre < genres.Count)) return genres[Genre]; else return ""; }

        }
        public string ScoreText
        {
            get { if (Score >= 0) return $"{Score:n0}"; else return ""; }

        }
        public string TotalEarnedText
        {
            get { if (TotalEarned >= 0) return $"{TotalEarned:c}"; else return ""; }

        }

    }
}
