﻿using System;
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
        private DateTime screeningTime;

        public Ticket(Movie movie, string seatNumber, DateTime screeningTime, double price) : base(price)
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

        public DateTime GetScreeningTime()
        {
            return screeningTime;
        }

        public void SetScreeningTime(DateTime newScreeningTime)
        {
            try
            {
                if (newScreeningTime < DateTime.Now)
                {
                    throw new Exception("Screening time cannot be in the past.");
                }

                screeningTime = newScreeningTime;
            }
            catch(Exception)
            {
                throw new Exception("Invalid Screening Date");
            }
        }
        //add a ToString method to print out the ticket information
        public override string ToString()
        {
            return $"{movie.GetTitle()} - {screeningTime.ToString("dd/MM/yyyy")} - {seatNumber} - {GetPrice()}";
        }
    }

}
