﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTracker
{
    public class MovieDetails : SearchMovie
    {
        public DateTime release;
        public int runtime { get; set; }
        public List<string> genres;
        public string director { get; set; }
        public string actors { get; set; }
        public string plot { get; set; }
        public string language { get; set; }
        public string awards { get; set; }
        public double imdbRating { get; set; }


        public MovieDetails(string title, int year, string imdbID, string poster, DateTime release, int runtime, List<string> genres, string director, string actors, string plot, string language, string awards, double imdbRating) : base(title, year, imdbID, poster)
        {
            this.release = release;
            this.runtime = runtime;
            this.genres = genres;
            this.director = director;
            this.actors = actors;
            this.plot = plot;
            this.language = language;
            this.awards = awards;
            this.imdbRating = imdbRating;

        }

        public string Rating()
        {
            if (imdbRating == 0)
                return "N/A";
            else return imdbRating.ToString();
        }


        public string Runtime()
        {
            if (runtime == 0)
                return "N/A";
            else return runtime.ToString() + " min";
        }
        public string Release()
        {
            if(release.Year != 1550)
                return release.Month + "." + release.Day + "." + release.Year;
            else
            {
                return "N/A";
            }
        }
                
        public string Genres()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in genres)
            {
                sb.Append(s + " ");
            }
            return sb.ToString();
        }
    }
}
