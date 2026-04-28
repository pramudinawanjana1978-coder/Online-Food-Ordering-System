namespace Resturent
{
    partial class Customer
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
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBoxname = new TextBox();
            textBoxnum = new TextBox();
            textBoxmail = new TextBox();
            textBoxaddres = new TextBox();
            buttonsave = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Harrington", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(127, 30);
            label1.Name = "label1";
            label1.Size = new Size(543, 71);
            label1.TabIndex = 0;
            label1.Text = "Add New Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(32, 153);
            label3.Name = "label3";
            label3.Size = new Size(268, 46);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(27, 221);
            label5.Name = "label5";
            label5.Size = new Size(273, 46);
            label5.TabIndex = 4;
            label5.Text = "Contact Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(32, 288);
            label2.Name = "label2";
            label2.Size = new Size(119, 46);
            label2.TabIndex = 5;
            label2.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(32, 359);
            label4.Name = "label4";
            label4.Size = new Size(139, 46);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // textBoxname
            // 
            textBoxname.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxname.Location = new Point(357, 156);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(355, 44);
            textBoxname.TabIndex = 7;
            // 
            // textBoxnum
            // 
            textBoxnum.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxnum.Location = new Point(357, 224);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(355, 44);
            textBoxnum.TabIndex = 8;
            // 
            // textBoxmail
            // 
            textBoxmail.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxmail.Location = new Point(357, 291);
            textBoxmail.Name = "textBoxmail";
            textBoxmail.Size = new Size(355, 44);
            textBoxmail.TabIndex = 9;
            // 
            // textBoxaddres
            // 
            textBoxaddres.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxaddres.Location = new Point(357, 362);
            textBoxaddres.Multiline = true;
            textBoxaddres.Name = "textBoxaddres";
            textBoxaddres.Size = new Size(355, 43);
            textBoxaddres.TabIndex = 10;
            // 
            // buttonsave
            // 
            buttonsave.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonsave.Location = new Point(91, 464);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(114, 40);
            buttonsave.TabIndex = 11;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = true;
            buttonsave.Click += buttonsave_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(357, 464);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 12;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(598, 464);
            button2.Name = "button2";
            button2.Size = new Size(114, 40);
            button2.TabIndex = 13;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ai_generated_beautuful_fast_food_background_with_copy_space_free_photo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(836, 536);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonsave);
            Controls.Add(textBoxaddres);
            Controls.Add(textBoxmail);
            Controls.Add(textBoxnum);
            Controls.Add(textBoxname);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            Text = "Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label4;
        private TextBox textBoxname;
        private TextBox textBoxnum;
        private TextBox textBoxmail;
        private TextBox textBoxaddres;
        private Button buttonsave;
        private Button button1;
        private Button button2;
    }
}