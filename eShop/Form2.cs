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
        private User temp;
        public Form2()
        {
            InitializeComponent();
        }

        public User GetUser() => this.temp;

        private void btnUsrCreate_Click(object sender, EventArgs e)
        {
            bool isnotvalid = true;
            while (isnotvalid)
            {
                try
                {
                    temp = new User(txtUsrName.Text, txtEmail.Text, txtPassword.Text, 1, 1, 1990);
                    isnotvalid = false;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Close();
        }
    }
}
