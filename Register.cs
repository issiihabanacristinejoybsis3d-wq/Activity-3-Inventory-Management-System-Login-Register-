using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace habana_sample
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            SetRoundedCorners(pnlLoginBox2, 20);
            SetRoundedCorners(btnCreate, 10);
            SetRoundedCorners(btnLogInAcc, 10);
        }

        private static void SetRoundedCorners(Control control, int radius)
        {
            using GraphicsPath path = new();
            int diameter = radius * 2;
            Rectangle bounds = new(Point.Empty, control.Size);

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string email = textBox3.Text.Trim();
            string password = textBox4.Text;
            string confirmPassword = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter an email address.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (!Database.RegisterUser(username, email, password))
            {
                MessageBox.Show("That username is already registered.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            MessageBox.Show("Registration completed successfully. You can now sign in.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void btnLogInAcc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
