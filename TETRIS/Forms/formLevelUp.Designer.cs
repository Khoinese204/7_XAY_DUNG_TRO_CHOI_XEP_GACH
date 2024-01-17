namespace Tetris.Forms
{
    partial class frmLevelUp
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelLevelUp = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(70, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Congratulations for your level-up !\r\n";
            // 
            // labelLevelUp
            // 
            this.labelLevelUp.AutoSize = true;
            this.labelLevelUp.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelUp.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevelUp.ForeColor = System.Drawing.Color.Yellow;
            this.labelLevelUp.Location = new System.Drawing.Point(349, 104);
            this.labelLevelUp.Name = "labelLevelUp";
            this.labelLevelUp.Size = new System.Drawing.Size(0, 93);
            this.labelLevelUp.TabIndex = 8;
            // 
            // btnClick
            // 
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(246, 308);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(252, 82);
            this.btnClick.TabIndex = 10;
            this.btnClick.Text = "Click here to continue";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click_1);
            // 
            // frmLevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.peakpx__16_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 415);
            this.ControlBox = false;
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.labelLevelUp);
            this.Controls.Add(this.label2);
            this.Name = "frmLevelUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Up!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLevelUp;
        private System.Windows.Forms.Button btnClick;
    }
}