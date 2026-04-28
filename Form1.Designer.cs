namespace Resturent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            login = new Button();
            textBoxuser = new TextBox();
            textBoxpass = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            buttonclose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 67);
            label1.TabIndex = 0;
            label1.Text = "FAST FOOD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(346, 76);
            label2.Name = "label2";
            label2.Size = new Size(375, 67);
            label2.TabIndex = 1;
            label2.Text = "RESRAURANT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(175, 143);
            label3.Name = "label3";
            label3.Size = new Size(608, 67);
            label3.TabIndex = 2;
            label3.Text = "MANAGEMENT SYSTEM";
            // 
            // login
            // 
            login.BackColor = Color.Maroon;
            login.BackgroundImageLayout = ImageLayout.None;
            login.FlatAppearance.BorderColor = Color.Maroon;
            login.FlatAppearance.BorderSize = 0;
            login.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(165, 470);
            login.Name = "login";
            login.Size = new Size(425, 65);
            login.TabIndex = 3;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // textBoxuser
            // 
            textBoxuser.Location = new Point(277, 317);
            textBoxuser.Name = "textBoxuser";
            textBoxuser.Size = new Size(323, 43);
            textBoxuser.TabIndex = 5;
            // 
            // textBoxpass
            // 
            textBoxpass.Location = new Point(277, 400);
            textBoxpass.Name = "textBoxpass";
            textBoxpass.Size = new Size(323, 43);
            textBoxpass.TabIndex = 6;
            textBoxpass.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.download__2_;
            pictureBox1.Location = new Point(175, 400);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, 317);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 10);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxpass);
            panel1.Controls.Add(textBoxuser);
            panel1.Controls.Add(buttonclose);
            panel1.Controls.Add(login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 700);
            panel1.TabIndex = 0;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = Color.Transparent;
            buttonclose.FlatAppearance.BorderSize = 0;
            buttonclose.Image = (Image)resources.GetObject("buttonclose.Image");
            buttonclose.Location = new Point(953, 3);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(37, 39);
            buttonclose.TabIndex = 4;
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 700);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button login;
        private TextBox textBoxuser;
        private TextBox textBoxpass;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel1;
        private Button buttonclose;
    }
}
