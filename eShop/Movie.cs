﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class Movie
    {
        private string title;
        private string director;
        private int duration;
        private Genre genre;
        private string picturePath;

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

        public Movie(string title, string director, int duration, Genre genre, string picturePath)
        {
            SetTitle(title);
            SetDirector(director);
            SetDuration(duration);
            SetGenre(genre);
            this.picturePath = picturePath;
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

        public string GetPicture() => picturePath;

public override string ToString()
{
    return $"{GetTitle()} - {GetGenre()} film ({GetDuration()} minutes) by {GetDirector()}";
}

    }}
