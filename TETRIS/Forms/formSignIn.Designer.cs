namespace Tetris.Forms
{
    partial class frmSignIn
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
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(198, 160);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(506, 38);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(198, 211);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(506, 38);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Goldenrod;
            this.button_WOC1.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.White;
            this.button_WOC1.Location = new System.Drawing.Point(198, 352);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Khaki;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Khaki;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC1.Size = new System.Drawing.Size(506, 70);
            this.button_WOC1.TabIndex = 9;
            this.button_WOC1.Text = "BACK TO MENU";
            this.button_WOC1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.ButtonColor = System.Drawing.Color.SeaGreen;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC2.Location = new System.Drawing.Point(198, 271);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.DarkSeaGreen;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.DarkSeaGreen;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(251, 75);
            this.button_WOC2.TabIndex = 10;
            this.button_WOC2.Text = "SIGN UP";
            this.button_WOC2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = false;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // button_WOC3
            // 
            this.button_WOC3.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC3.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Brown;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC3.Location = new System.Drawing.Point(455, 271);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.IndianRed;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC3.Size = new System.Drawing.Size(249, 75);
            this.button_WOC3.TabIndex = 11;
            this.button_WOC3.Text = "SIGN IN";
            this.button_WOC3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = false;
            this.button_WOC3.Click += new System.EventHandler(this.button_WOC3_Click);
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Tetris.Properties.Resources.Picture5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 517);
            this.ControlBox = false;
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtPassword;
    }
}