using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboAZ.Model;

namespace TurboAZ
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = DB.Users.Find(u => u.Email == textBox1.Text && u.Password == textBox2.Text);
            MessageBox.Show(newUser.Name);
        }
    }
}
