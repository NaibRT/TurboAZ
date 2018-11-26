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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        private bool Check()
        {
            bool result=true;
            if (String.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Length<2)
            {
                nameValid.Text = "Name is short";
                result= false;
            }
            if (String.IsNullOrEmpty(textBox2.Text) || !textBox2.Text.StartsWith("+994"))
            {
                NumberValid.Text = "Number does not contains +994";
                result= false;
            }
            if (String.IsNullOrEmpty(textBox3.Text) || !textBox3.Text.Contains("@"))
            {
                emailValid.Text = "Email does not contains @-simvol";
                result= false;
            }
            if (String.IsNullOrEmpty(textBox4.Text) || textBox4.Text.Length<6)
            {
                passwordValid.Text = "password is short";
                result= false;
            }

            return result;
        }
        private void ResetTextBoxs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            nameValid.Text = "";
            emailValid.Text = "";
            passwordValid.Text = "";
            NumberValid.Text = "";
        }

       private void AddUser()
        {
            User newUser = new User(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text);
            DB.Users.Add(newUser);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool c = Check();
            if (c)
            {
                AddUser();
            }
           
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignInForm newForm = new SignInForm();
            newForm.ShowDialog();
        }
    }
}
