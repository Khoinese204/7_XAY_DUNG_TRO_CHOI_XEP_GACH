
namespace Tetris.Forms
{
    partial class formLeaderBoard
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRank = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(192, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "labelName";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(420, 10);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(116, 23);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "labelScore";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Impact", 15F);
            this.btnBackToMenu.Location = new System.Drawing.Point(275, 565);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(293, 60);
            this.btnBackToMenu.TabIndex = 2;
            this.btnBackToMenu.Text = "Back To Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Best Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(647, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Level";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelLevel.ForeColor = System.Drawing.Color.Black;
            this.labelLevel.Location = new System.Drawing.Point(618, 10);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(114, 23);
            this.labelLevel.TabIndex = 6;
            this.labelLevel.Text = "labelLevel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(173, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(521, 98);
            this.label4.TabIndex = 7;
            this.label4.Text = "LEADERBOARDS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 53);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rank";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.labelRank);
            this.panel2.Controls.Add(this.labelScore);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelLevel);
            this.panel2.Location = new System.Drawing.Point(43, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 379);
            this.panel2.TabIndex = 9;
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.BackColor = System.Drawing.Color.Transparent;
            this.labelRank.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelRank.ForeColor = System.Drawing.Color.Black;
            this.labelRank.Location = new System.Drawing.Point(19, 10);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(109, 23);
            this.labelRank.TabIndex = 7;
            this.labelRank.Text = "labelRank";
            // 
            // formLeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Tetris.Properties.Resources.HD_wallpaper_underwater_world_ocean_corals_light;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 667);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackToMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLeaderBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Label label5;
    }
}