using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class Ticket : Item
    {
        private Movie movie;
        private string seatNumber;
        private ScreeningTime screeningTime;

        public enum ScreeningTime
        {
            _10AM = 10,
            _13PM = 13,
            _16PM = 16,
            _19PM = 19,
            _22PM = 22
        }

        public Ticket(Movie movie, string seatNumber, ScreeningTime screeningTime, double price) : base(price)
        {
            this.movie = movie;
            SetSeatNumber(seatNumber);
            SetScreeningTime(screeningTime);
        }

        public Movie GetMovie()
        {
            return movie;
        }

        public void SetMovie(Movie newMovie)
        {
            movie = newMovie;
        }

        public string GetSeatNumber()
        {
            return seatNumber;
        }

        public void SetSeatNumber(string newSeatNumber)
        {
            if (string.IsNullOrEmpty(newSeatNumber))
            {
                throw new Exception("Seat number cannot be empty.");
            }

            seatNumber = newSeatNumber;
        }

        public ScreeningTime GetScreeningTime()
        {
            return screeningTime;
        }

        public string ScreeningTimeToString()
        {
            
        }

        public void SetScreeningTime(ScreeningTime screeningTime)
        {
            // Check if the provided screening time is valid
            if (Enum.IsDefined(typeof(ScreeningTime), screeningTime))
            {
                this.screeningTime = screeningTime;
            }
            else
            {
                throw new ArgumentException("Invalid screening time.");
            }
        }

        public override string ToString()
        {
            return $"{movie.GetTitle()} - {screeningTime.ToString("dd/MM/yyyy")} Seat {seatNumber} Price: {GetPrice()}";
        }
    }

}
