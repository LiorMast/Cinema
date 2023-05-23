using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    internal class Movie : Item
    {
        private string title;
        private string director;
        private int duration;
        private Genre genre;

        //

        public enum Genre
        {
            Action,
            Comedy,
            Drama,
            Fantasy,
            Horror,
            Romance,
            SciFi,
            Thriller
        }

        public Movie(string title, string director, int duration, Genre genre, double price)
    : base(price)
        {
            SetTitle(title);
            SetDirector(director);
            SetDuration(duration);
            SetGenre(genre);
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

        public Genre GetGenre()
        {
            return genre;
        }

        public void SetGenre(Genre newGenre)
{
    if (Enum.IsDefined(typeof(Genre), newGenre))
    {
        this.genre = newGenre;
    }
    else
    {
        throw new Exception("Invalid genre.");
    }
}

    }

}
