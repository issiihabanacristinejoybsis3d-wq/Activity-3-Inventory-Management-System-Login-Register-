namespace habana_sample
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnlLoginBox1 = new Panel();
            pictureBox1 = new PictureBox();
            lblGoogle = new Label();
            chkRemember = new CheckedListBox();
            lblOr = new Label();
            btnSignIn = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblPass = new Label();
            lblLoginTitle1 = new Label();
            lblUser = new Label();
            btnRegisterAcc = new Button();
            lblSign = new Label();
            button1 = new Button();
            button2 = new Button();
            pnlLoginBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLoginBox1
            // 
            pnlLoginBox1.BackColor = Color.White;
            pnlLoginBox1.BorderStyle = BorderStyle.FixedSingle;
            pnlLoginBox1.Controls.Add(pictureBox1);
            pnlLoginBox1.Controls.Add(lblGoogle);
            pnlLoginBox1.Controls.Add(chkRemember);
            pnlLoginBox1.Controls.Add(lblOr);
            pnlLoginBox1.Controls.Add(btnSignIn);
            pnlLoginBox1.Controls.Add(label1);
            pnlLoginBox1.Controls.Add(textBox2);
            pnlLoginBox1.Controls.Add(textBox1);
            pnlLoginBox1.Controls.Add(lblPass);
            pnlLoginBox1.Controls.Add(lblLoginTitle1);
            pnlLoginBox1.Controls.Add(lblUser);
            pnlLoginBox1.Controls.Add(btnRegisterAcc);
            pnlLoginBox1.Controls.Add(lblSign);
            pnlLoginBox1.Controls.Add(button1);
            pnlLoginBox1.Controls.Add(button2);
            pnlLoginBox1.Location = new Point(320, 41);
            pnlLoginBox1.Name = "pnlLoginBox1";
            pnlLoginBox1.Size = new Size(410, 554);
            pnlLoginBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lblGoogle
            // 
            lblGoogle.AutoSize = true;
            lblGoogle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGoogle.ForeColor = Color.SteelBlue;
            lblGoogle.Location = new Point(95, 447);
            lblGoogle.Name = "lblGoogle";
            lblGoogle.Size = new Size(26, 28);
            lblGoogle.TabIndex = 13;
            lblGoogle.Text = "G";
            // 
            // chkRemember
            // 
            chkRemember.BorderStyle = BorderStyle.None;
            chkRemember.Font = new Font("Segoe UI", 7F);
            chkRemember.FormattingEnabled = true;
            chkRemember.Items.AddRange(new object[] { "Remember me" });
            chkRemember.Location = new Point(40, 323);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(180, 23);
            chkRemember.TabIndex = 11;
            // 
            // lblOr
            // 
            lblOr.AutoSize = true;
            lblOr.Font = new Font("Segoe UI", 7F);
            lblOr.ForeColor = Color.Black;
            lblOr.Location = new Point(188, 431);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(22, 19);
            lblOr.TabIndex = 10;
            lblOr.Text = "or";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Green;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(128, 384);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(144, 40);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "Sign In ⟶";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(68, 484);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 6;
            label1.Text = "Don't Have An Account?";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 289);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter password";
            textBox2.Size = new Size(321, 31);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 211);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter username";
            textBox1.Size = new Size(321, 31);
            textBox1.TabIndex = 4;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F);
            lblPass.ForeColor = Color.Black;
            lblPass.Location = new Point(36, 261);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(87, 25);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password";
            // 
            // lblLoginTitle1
            // 
            lblLoginTitle1.AutoSize = true;
            lblLoginTitle1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLoginTitle1.ForeColor = Color.DarkGreen;
            lblLoginTitle1.Location = new Point(104, 88);
            lblLoginTitle1.Name = "lblLoginTitle1";
            lblLoginTitle1.Size = new Size(231, 41);
            lblLoginTitle1.TabIndex = 1;
            lblLoginTitle1.Text = "Welcome Back!";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(36, 184);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(91, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // btnRegisterAcc
            // 
            btnRegisterAcc.FlatAppearance.BorderSize = 0;
            btnRegisterAcc.FlatStyle = FlatStyle.Flat;
            btnRegisterAcc.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterAcc.ForeColor = Color.DarkGreen;
            btnRegisterAcc.Location = new Point(203, 476);
            btnRegisterAcc.Name = "btnRegisterAcc";
            btnRegisterAcc.Size = new Size(144, 34);
            btnRegisterAcc.TabIndex = 7;
            btnRegisterAcc.Text = "Create Account";
            btnRegisterAcc.UseVisualStyleBackColor = true;
            btnRegisterAcc.Click += btnRegisterAcc_Click;
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.Font = new Font("Segoe UI", 7F);
            lblSign.ForeColor = Color.Black;
            lblSign.Location = new Point(142, 125);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(124, 19);
            lblSign.TabIndex = 9;
            lblSign.Text = "Sign in to continue";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 7F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(239, 317);
            button1.Name = "button1";
            button1.Size = new Size(132, 27);
            button1.TabIndex = 17;
            button1.Text = "Forgot password?";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(68, 442);
            button2.Name = "button2";
            button2.Size = new Size(278, 40);
            button2.TabIndex = 12;
            button2.Text = "         Continue with Google   ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1051, 628);
            Controls.Add(pnlLoginBox1);
            Name = "Login";
            Text = "Login";
            pnlLoginBox1.ResumeLayout(false);
            pnlLoginBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoginBox1;
        private Label lblGoogle;
        private Button button2;
        private CheckedListBox chkRemember;
        private Label lblOr;
        private Button btnSignIn;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblPass;
        private Label lblLoginTitle1;
        private Label lblUser;
        private Button btnRegisterAcc;
        private Label lblSign;
        private PictureBox pictureBox1;
        private Button button1;
    }
}