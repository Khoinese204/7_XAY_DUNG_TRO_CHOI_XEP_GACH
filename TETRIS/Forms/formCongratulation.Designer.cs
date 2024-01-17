namespace Tetris.Forms
{
    partial class frmCongratulation
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
            this.btnClick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(264, 274);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(252, 82);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "Click here to continue";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(124, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "You have achieved a new high score !";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(357, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 41);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter your initials:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(227, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 212);
            this.label4.TabIndex = 11;
            this.label4.Text = "CONGRATULATIONS !\r\n\r\n\r\n\r\n";
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.BackColor = System.Drawing.Color.Transparent;
            this.labelScores.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScores.Location = new System.Drawing.Point(348, 156);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(0, 51);
            this.labelScores.TabIndex = 12;
            // 
            // frmCongratulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.Picture9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 415);
            this.ControlBox = false;
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Name = "frmCongratulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Congratulation!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelScores;
    }
}