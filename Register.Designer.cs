namespace habana_sample
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pnlLoginBox2 = new Panel();
            pictureBox1 = new PictureBox();
            btnCreate = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            lblEmail = new Label();
            lblPassWord = new Label();
            lblRegisterSub = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblConfirmPass = new Label();
            lblRegisterTitle = new Label();
            lblUser = new Label();
            btnLogInAcc = new Button();
            lblRegister = new Label();
            pnlLoginBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLoginBox2
            // 
            pnlLoginBox2.BackColor = Color.White;
            pnlLoginBox2.BorderStyle = BorderStyle.FixedSingle;
            pnlLoginBox2.Controls.Add(pictureBox1);
            pnlLoginBox2.Controls.Add(btnCreate);
            pnlLoginBox2.Controls.Add(textBox4);
            pnlLoginBox2.Controls.Add(textBox3);
            pnlLoginBox2.Controls.Add(lblEmail);
            pnlLoginBox2.Controls.Add(lblPassWord);
            pnlLoginBox2.Controls.Add(lblRegisterSub);
            pnlLoginBox2.Controls.Add(textBox2);
            pnlLoginBox2.Controls.Add(textBox1);
            pnlLoginBox2.Controls.Add(lblConfirmPass);
            pnlLoginBox2.Controls.Add(lblRegisterTitle);
            pnlLoginBox2.Controls.Add(lblUser);
            pnlLoginBox2.Controls.Add(btnLogInAcc);
            pnlLoginBox2.Controls.Add(lblRegister);
            pnlLoginBox2.Location = new Point(271, 34);
            pnlLoginBox2.Name = "pnlLoginBox2";
            pnlLoginBox2.Size = new Size(410, 565);
            pnlLoginBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Green;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(130, 454);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(144, 40);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Register ⟶";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(40, 319);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter password";
            textBox4.Size = new Size(321, 31);
            textBox4.TabIndex = 13;
            textBox4.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 251);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter email address";
            textBox3.Size = new Size(321, 31);
            textBox3.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(36, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            lblEmail.Click += label3_Click;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Font = new Font("Segoe UI", 9F);
            lblPassWord.ForeColor = Color.Black;
            lblPassWord.Location = new Point(36, 291);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(87, 25);
            lblPassWord.TabIndex = 10;
            lblPassWord.Text = "Password";
            // 
            // lblRegisterSub
            // 
            lblRegisterSub.AutoSize = true;
            lblRegisterSub.Font = new Font("Segoe UI", 7F);
            lblRegisterSub.ForeColor = Color.Black;
            lblRegisterSub.Location = new Point(77, 509);
            lblRegisterSub.Name = "lblRegisterSub";
            lblRegisterSub.Size = new Size(165, 19);
            lblRegisterSub.TabIndex = 6;
            lblRegisterSub.Text = "Already have an account?";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 385);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Confirm password";
            textBox2.Size = new Size(321, 31);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 185);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter username";
            textBox1.Size = new Size(321, 31);
            textBox1.TabIndex = 4;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Segoe UI", 9F);
            lblConfirmPass.ForeColor = Color.Black;
            lblConfirmPass.Location = new Point(36, 357);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(156, 25);
            lblConfirmPass.TabIndex = 3;
            lblConfirmPass.Text = "Confirm Password";
            lblConfirmPass.Click += lblPass_Click;
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.AutoSize = true;
            lblRegisterTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRegisterTitle.ForeColor = Color.DarkGreen;
            lblRegisterTitle.Location = new Point(83, 81);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(232, 41);
            lblRegisterTitle.TabIndex = 1;
            lblRegisterTitle.Text = "Create Account";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(36, 160);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(91, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // btnLogInAcc
            // 
            btnLogInAcc.FlatAppearance.BorderSize = 0;
            btnLogInAcc.FlatStyle = FlatStyle.Flat;
            btnLogInAcc.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogInAcc.ForeColor = Color.DarkGreen;
            btnLogInAcc.Location = new Point(196, 501);
            btnLogInAcc.Name = "btnLogInAcc";
            btnLogInAcc.Size = new Size(144, 34);
            btnLogInAcc.TabIndex = 7;
            btnLogInAcc.Text = "Log In";
            btnLogInAcc.UseVisualStyleBackColor = true;
            btnLogInAcc.Click += btnLogInAcc_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 7F);
            lblRegister.ForeColor = Color.Black;
            lblRegister.Location = new Point(113, 121);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(181, 19);
            lblRegister.TabIndex = 9;
            lblRegister.Text = "Create an account to sign in";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(955, 638);
            Controls.Add(pnlLoginBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register ⟶";
            pnlLoginBox2.ResumeLayout(false);
            pnlLoginBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoginBox2;
        private Label lblRegisterSub;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblUser;
        private Button btnLogInAcc;
        private Label lblRegister;
        private Label lblPassWord;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button btnCreate;
        private Label lblConfirmPass;
        private Label lblRegisterTitle;
        private Label lblEmail;
        private PictureBox pictureBox1;
    }
}