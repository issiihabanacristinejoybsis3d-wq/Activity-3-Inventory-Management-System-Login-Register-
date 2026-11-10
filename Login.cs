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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetRoundedCorners(pnlLoginBox1, 20);
            SetRoundedCorners(btnSignIn, 10);
            SetRoundedCorners(btnRegisterAcc, 10);
            SetRoundedCorners(button2, 10);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLoginTitle2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a username.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (!Database.ValidateUser(textBox1.Text.Trim(), textBox2.Text))
            {
                MessageBox.Show(
                    "Invalid username or password. Please register an account first.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Hide();

            using Inventory_Management_System mainForm = new();
            mainForm.ShowDialog(this);

            if (mainForm.DialogResult == DialogResult.Retry)
            {
                Show();
                textBox1.Clear();
                textBox2.Clear();
                return;
            }

            Close();
        }

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            Hide();

            using Register registerForm = new();
            registerForm.ShowDialog(this);

            Show();
        }

    }
}
