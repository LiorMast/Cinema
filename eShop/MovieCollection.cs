using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    internal class MovieCollection
    {
        private Movie[] movies;
        private int currentIndex;

        public MovieCollection()
        {
            movies = new Movie[10]; // Initial capacity of 10
            currentIndex = 0;
        }

        
        public Movie[] GetMovies()
        {
            return movies;
        }

        public int GetCurrentIndex()
        {
            return currentIndex;
        }

        public void AddMovie(Movie movie)
        {
            if (currentIndex == movies.Length)
            {
                // Array is full, resize it
                Array.Resize(ref movies, movies.Length + 10);
            }

            movies[currentIndex] = movie;
            currentIndex++;
        }

        public void DeleteMovie(string movieName)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (movies[i].GetTitle().Equals(movieName, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < currentIndex - 1; j++)
                    {
                        movies[j] = movies[j + 1];
                    }

                    movies[currentIndex - 1] = null;
                    currentIndex--;
                    return;
                }
            }
        }

        public Movie[] GetMoviesByGenre(string genre)
        {

            MovieCollection moviesByGenre = new MovieCollection();

            foreach (Movie movie in movies)
            {
                if (movie != null && movie.GetGenre().ToString().ToLower().Equals(genre.ToString().ToLower()))
                {
                    moviesByGenre.AddMovie(movie);
                }
            }

            return moviesByGenre.GetMovies();
        }

        public Movie SearchMovieByName(string movieName)
        {
            foreach (Movie movie in movies)
            {
                if (movie != null && movie.GetTitle().ToString().ToLower().Contains(movieName.ToString().ToLower()))
                {
                    return movie;
                }
            }

            return null;
        }
    }

}
