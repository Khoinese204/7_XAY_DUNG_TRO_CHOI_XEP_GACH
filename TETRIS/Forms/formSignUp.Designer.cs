namespace Tetris.Forms
{
    partial class frmSignUp
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUserName.Location = new System.Drawing.Point(610, 98);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(267, 36);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassword.Location = new System.Drawing.Point(610, 149);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(267, 36);
            this.txtPassword.TabIndex = 5;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRePassword.Location = new System.Drawing.Point(610, 205);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(267, 36);
            this.txtRePassword.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFullName.Location = new System.Drawing.Point(610, 257);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(267, 36);
            this.txtFullName.TabIndex = 7;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(617, 328);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(178, 84);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.LightBlue;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(365, 328);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(235, 84);
            this.btnBackToMenu.TabIndex = 9;
            this.btnBackToMenu.Text = "BACK TO SIGN IN";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tetris.Properties.Resources.Picture3;
            this.pictureBox1.Location = new System.Drawing.Point(33, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.Picture1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}