namespace BisCarePosEdition
{
    partial class PasswordChange
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
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Newpassword = new System.Windows.Forms.TextBox();
            this.txt_Currentpassword = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.lbl_currentpassword = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.Location = new System.Drawing.Point(137, 107);
            this.txt_confirmpassword.MaxLength = 25;
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.Size = new System.Drawing.Size(160, 23);
            this.txt_confirmpassword.TabIndex = 5;
            this.txt_confirmpassword.UseSystemPasswordChar = true;
            this.txt_confirmpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_confirmpassword_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_confirmpassword);
            this.groupBox1.Controls.Add(this.txt_Newpassword);
            this.groupBox1.Controls.Add(this.txt_Currentpassword);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.lbl_ConfirmPassword);
            this.groupBox1.Controls.Add(this.lbl_NewPassword);
            this.groupBox1.Controls.Add(this.lbl_currentpassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_Newpassword
            // 
            this.txt_Newpassword.Location = new System.Drawing.Point(137, 67);
            this.txt_Newpassword.MaxLength = 25;
            this.txt_Newpassword.Name = "txt_Newpassword";
            this.txt_Newpassword.Size = new System.Drawing.Size(160, 23);
            this.txt_Newpassword.TabIndex = 4;
            this.txt_Newpassword.UseSystemPasswordChar = true;
            this.txt_Newpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Newpassword_KeyDown);
            // 
            // txt_Currentpassword
            // 
            this.txt_Currentpassword.Location = new System.Drawing.Point(137, 30);
            this.txt_Currentpassword.MaxLength = 25;
            this.txt_Currentpassword.Name = "txt_Currentpassword";
            this.txt_Currentpassword.Size = new System.Drawing.Size(160, 23);
            this.txt_Currentpassword.TabIndex = 3;
            this.txt_Currentpassword.UseSystemPasswordChar = true;
            this.txt_Currentpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Currentpassword_KeyDown);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(159, 147);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "      Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseEnter += new System.EventHandler(this.btn_Update_MouseEnter);
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_Update_MouseLeave);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Image = global::BisCarePosEdition.Properties.Resources.Update4;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(43, 147);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 32);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "      Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            this.btn_Update.MouseEnter += new System.EventHandler(this.btn_Update_MouseEnter);
            this.btn_Update.MouseLeave += new System.EventHandler(this.btn_Update_MouseLeave);
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(12, 109);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(121, 17);
            this.lbl_ConfirmPassword.TabIndex = 2;
            this.lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Location = new System.Drawing.Point(34, 70);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(100, 17);
            this.lbl_NewPassword.TabIndex = 1;
            this.lbl_NewPassword.Text = "New Password";
            // 
            // lbl_currentpassword
            // 
            this.lbl_currentpassword.AutoSize = true;
            this.lbl_currentpassword.Location = new System.Drawing.Point(13, 33);
            this.lbl_currentpassword.Name = "lbl_currentpassword";
            this.lbl_currentpassword.Size = new System.Drawing.Size(120, 17);
            this.lbl_currentpassword.TabIndex = 0;
            this.lbl_currentpassword.Text = "Current Password";
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(322, 199);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Change";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Newpassword;
        private System.Windows.Forms.TextBox txt_Currentpassword;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Label lbl_currentpassword;
    }
}