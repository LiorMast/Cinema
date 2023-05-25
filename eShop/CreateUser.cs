using Cinema;
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
    public partial class CreateUser : Form
    {
        private User temp;
        public CreateUser()
        {
            InitializeComponent();
        }

        public User GetUser() => temp;

        private void btnUsrCreate_Click(object sender, EventArgs e)
        {
            try
            {
                temp = new User(txtUsrName.Text, txtEmail.Text, txtPassword.Text, 1, 1, 1990);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.Message == "Invalid email format.")
                {
                    txtEmail.Text = "";
                }
            }
            
            
        }
    }
}
