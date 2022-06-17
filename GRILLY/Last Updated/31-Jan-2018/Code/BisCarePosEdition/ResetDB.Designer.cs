namespace BisCarePosEdition
{
    partial class ResetDB
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
            this.Txt_Passwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Passwd
            // 
            this.Txt_Passwd.Location = new System.Drawing.Point(128, 26);
            this.Txt_Passwd.MaxLength = 50;
            this.Txt_Passwd.Name = "Txt_Passwd";
            this.Txt_Passwd.PasswordChar = '*';
            this.Txt_Passwd.Size = new System.Drawing.Size(307, 23);
            this.Txt_Passwd.TabIndex = 1;
            this.Txt_Passwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Passwd_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Close);
            this.groupBox1.Controls.Add(this.Btn_Reset);
            this.groupBox1.Controls.Add(this.Txt_Passwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Close.Location = new System.Drawing.Point(325, 66);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(110, 32);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            this.Btn_Close.MouseEnter += new System.EventHandler(this.Btn_Reset_MouseEnter);
            this.Btn_Close.MouseLeave += new System.EventHandler(this.Btn_Reset_MouseLeave);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.Image = global::BisCarePosEdition.Properties.Resources.reset1;
            this.Btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reset.Location = new System.Drawing.Point(200, 66);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(110, 32);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            this.Btn_Reset.MouseEnter += new System.EventHandler(this.Btn_Reset_MouseEnter);
            this.Btn_Reset.MouseLeave += new System.EventHandler(this.Btn_Reset_MouseLeave);
            // 
            // ResetDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(456, 116);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Database";
            this.Load += new System.EventHandler(this.ResetDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.TextBox Txt_Passwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}