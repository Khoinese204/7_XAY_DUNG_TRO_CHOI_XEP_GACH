using System.Drawing;

namespace Tetris.Forms
{
    partial class formHighScore
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
            this.labelHighScores = new System.Windows.Forms.Label();
            this.labelInitials = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHighScores
            // 
            this.labelHighScores.AutoSize = true;
            this.labelHighScores.BackColor = System.Drawing.Color.Transparent;
            this.labelHighScores.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScores.ForeColor = System.Drawing.Color.White;
            this.labelHighScores.Location = new System.Drawing.Point(145, 16);
            this.labelHighScores.Name = "labelHighScores";
            this.labelHighScores.Size = new System.Drawing.Size(333, 75);
            this.labelHighScores.TabIndex = 8;
            this.labelHighScores.Text = "HIGHSCORES";
            // 
            // labelInitials
            // 
            this.labelInitials.AutoSize = true;
            this.labelInitials.BackColor = System.Drawing.Color.Transparent;
            this.labelInitials.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitials.ForeColor = System.Drawing.Color.Black;
            this.labelInitials.Location = new System.Drawing.Point(22, 30);
            this.labelInitials.Name = "labelInitials";
            this.labelInitials.Size = new System.Drawing.Size(120, 23);
            this.labelInitials.TabIndex = 10;
            this.labelInitials.Text = "labelInitials";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(180, 30);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(114, 23);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "labelScore";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.Black;
            this.labelTotalTime.Location = new System.Drawing.Point(313, 30);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(149, 23);
            this.labelTotalTime.TabIndex = 12;
            this.labelTotalTime.Text = "labelTotalTime";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelInitials);
            this.panel1.Controls.Add(this.labelTotalTime);
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(49, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 480);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Tetris.Properties.Resources.Picture10;
            this.pictureBox1.Location = new System.Drawing.Point(63, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.White;
            this.button_WOC1.ButtonColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(188, 609);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(244, 63);
            this.button_WOC1.TabIndex = 13;
            this.button_WOC1.Text = "BACK TO MENU";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // formHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(595, 709);
            this.ControlBox = false;
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHighScores);
            this.Name = "formHighScore";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHighScores;
        private System.Windows.Forms.Label labelInitials;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}