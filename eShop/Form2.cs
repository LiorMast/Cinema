using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShop
{
    public partial class Form2 : Form
    {
        private User activeUser;
        private MovieCollection movies;



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

        }
    }
}
