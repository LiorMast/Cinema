using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace eShop
{
    public partial class Form2 : Form
    {
        private User activeUser;
        private MovieCollection movies = new MovieCollection();


        public Form2()
        {
            InitializeComponent();
        }
        public Form2(User activeUser)
        {
            this.activeUser = activeUser;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            string[] file = File.ReadAllLines(@"..\..\Data\movies.txt");

            for (int i = 0; i < file.Length; i++)
            {
                file[i] = file[i].Trim().Substring(1, file[i].Length - 2);
            }
            foreach (var item in file)
            {
                string[] temp = item.Split(',');
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = temp[i].Trim();
                }
                Movie.Genre gen;
                Enum.TryParse(temp[3], out gen);
                Movie mov = new Movie(temp[0], temp[1], int.Parse(temp[2]), gen);
                movies.AddMovie(mov);

            }
            rtbInfo.Text = movies.ToString();
        }
    }
}
