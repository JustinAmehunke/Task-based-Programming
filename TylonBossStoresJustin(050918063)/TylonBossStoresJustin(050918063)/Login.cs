using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TylonBossStores
{
    public partial class Login : Form1
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                this.Hide();
                Dashboard db = new Dashboard();
                db.Show();
            }
            else 
            {
                MessageBox.Show("Something Went Wrong");
            }
        }
    }
}
