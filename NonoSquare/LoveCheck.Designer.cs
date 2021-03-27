namespace NonoSquare
{
    partial class LoveCheck
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.thanksButton = new System.Windows.Forms.PictureBox();
            this.generateButton = new System.Windows.Forms.PictureBox();
            this.ResetSpread = new System.Windows.Forms.Timer(this.components);
            this.userInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanksButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::NonoSquare.Properties.Resources.back;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(5, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 30);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.clickBack);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.unhoverBack);
            this.pictureBox3.MouseHover += new System.EventHandler(this.hoverBack);
            // 
            // thanksButton
            // 
            this.thanksButton.BackColor = System.Drawing.Color.Transparent;
            this.thanksButton.BackgroundImage = global::NonoSquare.Properties.Resources.thanks_unhover;
            this.thanksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thanksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thanksButton.Location = new System.Drawing.Point(99, 287);
            this.thanksButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thanksButton.Name = "thanksButton";
            this.thanksButton.Size = new System.Drawing.Size(231, 68);
            this.thanksButton.TabIndex = 10;
            this.thanksButton.TabStop = false;
            this.thanksButton.Visible = false;
            this.thanksButton.Click += new System.EventHandler(this.thanksButton_Click);
            this.thanksButton.MouseLeave += new System.EventHandler(this.thanksButton_MouseLeave);
            this.thanksButton.MouseHover += new System.EventHandler(this.thanksButton_MouseHover);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.Transparent;
            this.generateButton.BackgroundImage = global::NonoSquare.Properties.Resources.receive_unhover;
            this.generateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton.Location = new System.Drawing.Point(99, 287);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(231, 68);
            this.generateButton.TabIndex = 11;
            this.generateButton.TabStop = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            this.generateButton.MouseLeave += new System.EventHandler(this.generateButton_MouseLeave);
            this.generateButton.MouseHover += new System.EventHandler(this.generateButton_MouseHover);
            // 
            // ResetSpread
            // 
            this.ResetSpread.Tick += new System.EventHandler(this.ResetSpread_Tick);
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userInput.Location = new System.Drawing.Point(525, 295);
            this.userInput.Margin = new System.Windows.Forms.Padding(4);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(237, 30);
            this.userInput.TabIndex = 12;
            this.userInput.Text = "Spread the word.";
            this.userInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            this.userInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userInput_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Location = new System.Drawing.Point(45, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 30);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Generated message will be displayed ";
            // 
            // LoveCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NonoSquare.Properties.Resources.LoveCheck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 443);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.thanksButton);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoveCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VibeCheck";
            this.Load += new System.EventHandler(this.loadLoveCheck);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanksButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox thanksButton;
        private System.Windows.Forms.PictureBox generateButton;
        private System.Windows.Forms.Timer ResetSpread;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox textBox1;
    }
}