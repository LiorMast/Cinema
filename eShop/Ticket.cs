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

        public string ScreeningTimeToString(ScreeningTime screeningTime)
        {
            if(screeningTime == ScreeningTime._10AM)
            {
                return "10:00";
            }
            else if(screeningTime == ScreeningTime._13PM)
            {
                return "13:00";
            }
            else if(screeningTime == ScreeningTime._16PM)
            {
                return "16:00";
            }
            else if(screeningTime == ScreeningTime._19PM)
            {
                return "19:00";
            }
            else if(screeningTime == ScreeningTime._22PM)
            {
                return "22:00";
            }
            else
            {
                return "Invalid screening time.";
            }

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
            return $"{movie.GetTitle()} - {ScreeningTimeToString(screeningTime)} Seat {seatNumber} Price: {GetPrice()}";
        }
    }

}
