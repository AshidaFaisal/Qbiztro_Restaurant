namespace BisCarePosEdition
{
    partial class DeletePasswordChange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.txt_Newpassword = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_confirmpassword);
            this.groupBox1.Controls.Add(this.txt_Newpassword);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.lbl_ConfirmPassword);
            this.groupBox1.Controls.Add(this.lbl_NewPassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.Location = new System.Drawing.Point(124, 62);
            this.txt_confirmpassword.MaxLength = 25;
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.Size = new System.Drawing.Size(160, 23);
            this.txt_confirmpassword.TabIndex = 5;
            this.txt_confirmpassword.UseSystemPasswordChar = true;
            // 
            // txt_Newpassword
            // 
            this.txt_Newpassword.Location = new System.Drawing.Point(124, 22);
            this.txt_Newpassword.MaxLength = 25;
            this.txt_Newpassword.Name = "txt_Newpassword";
            this.txt_Newpassword.Size = new System.Drawing.Size(160, 23);
            this.txt_Newpassword.TabIndex = 4;
            this.txt_Newpassword.UseSystemPasswordChar = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(157, 111);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "      Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(41, 111);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 32);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Save";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(4, 64);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(121, 17);
            this.lbl_ConfirmPassword.TabIndex = 2;
            this.lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Location = new System.Drawing.Point(52, 25);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(73, 17);
            this.lbl_NewPassword.TabIndex = 1;
            this.lbl_NewPassword.Text = " Password";
            // 
            // DeletePasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 159);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeletePasswordChange";
            this.Text = "KOT Password Settings";
            this.Load += new System.EventHandler(this.DeletePasswordChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.TextBox txt_Newpassword;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
    }
}