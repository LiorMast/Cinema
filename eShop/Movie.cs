using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    internal class Movie
    {
        private string title;
        private string director;
        private int duration;
        private string genre;

        public Movie(string title, string director, int duration, string genre)
        {
            this.title = title;
            this.director = director;
            this.duration = duration;
            this.genre = genre;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string newTitle)
        {
            title = newTitle;
        }

        public string GetDirector()
        {
            return director;
        }

        public void SetDirector(string newDirector)
        {
            director = newDirector;
        }

        public int GetDuration()
        {
            return duration;
        }

        public void SetDuration(int newDuration)
        {
            duration = newDuration;
        }

        public string GetGenre()
        {
            return genre;
        }

        public void SetGenre(string newGenre)
        {
            genre = newGenre;
        }
    }

}
