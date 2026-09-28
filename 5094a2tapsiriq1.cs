using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace _5094a2
{
    public partial class back : Form
    {
        private string registeredUsername = "";
        private string registeredPassword = "";

        public back()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        // Qeydiyyatda Şifrəni Göstər / Gizlət (Sizin dizayndakı checkBox-a uyğun)
        private void chkRegShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Qeydiyyat şifrə qutunuzun adı əgər fərqlidirsə, dizayndakı adla eyni olun
                txtRegPassword.PasswordChar = '\0';
            }
            else
            {
                txtRegPassword.PasswordChar = '*';
            }
        }

        // Qeydiyyatdan Keç (Sign Up)
        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            registeredUsername = txtRegUsername.Text;
            registeredPassword = txtRegPassword.Text;

            MessageBox.Show(
                "Qeydiyyatdan ugurla kecdiniz!",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtRegUsername.Clear();
            txtRegPassword.Clear();
        }

        // Girişdə Şifrəni Göstər / Gizlət
        private void chkLoginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtLoginPassword.PasswordChar = '\0';
            }
            else
            {
                txtLoginPassword.PasswordChar = '*';
            }
        }

        // Sistemə Daxil Ol (Sign In)
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtLoginUsername.Text == registeredUsername &&
                txtLoginPassword.Text == registeredPassword)
            {
                MessageBox.Show(
                    "Ugurla daxil oldunuz!",
                    "Sign In",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Istifadeci adi ve ya sifre yanlisdir!",
                    "Sign In",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}