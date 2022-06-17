namespace BisCarePosEdition
{
    partial class UserAccountType
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_new = new System.Windows.Forms.RadioButton();
            this.rb_edit = new System.Windows.Forms.RadioButton();
            this.cmb_usertype = new System.Windows.Forms.ComboBox();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.txt_usertype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_new);
            this.groupBox2.Controls.Add(this.rb_edit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(105, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(179, 60);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // rb_new
            // 
            this.rb_new.AutoSize = true;
            this.rb_new.Checked = true;
            this.rb_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_new.Location = new System.Drawing.Point(23, 22);
            this.rb_new.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_new.Name = "rb_new";
            this.rb_new.Size = new System.Drawing.Size(53, 21);
            this.rb_new.TabIndex = 0;
            this.rb_new.TabStop = true;
            this.rb_new.Text = "New";
            this.rb_new.UseVisualStyleBackColor = true;
            this.rb_new.CheckedChanged += new System.EventHandler(this.rb_new_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_edit.Location = new System.Drawing.Point(112, 22);
            this.rb_edit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(50, 21);
            this.rb_edit.TabIndex = 1;
            this.rb_edit.Text = "Edit";
            this.rb_edit.UseVisualStyleBackColor = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_edit_CheckedChanged);
            // 
            // cmb_usertype
            // 
            this.cmb_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_usertype.FormattingEnabled = true;
            this.cmb_usertype.Location = new System.Drawing.Point(139, 99);
            this.cmb_usertype.Name = "cmb_usertype";
            this.cmb_usertype.Size = new System.Drawing.Size(230, 24);
            this.cmb_usertype.TabIndex = 1;
            this.cmb_usertype.SelectedIndexChanged += new System.EventHandler(this.cmb_usertype_SelectedIndexChanged);
            this.cmb_usertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_usertype_KeyDown);
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(139, 176);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(230, 47);
            this.txt_remarks.TabIndex = 3;
            this.txt_remarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_remarks_KeyDown);
            // 
            // txt_usertype
            // 
            this.txt_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usertype.Location = new System.Drawing.Point(139, 136);
            this.txt_usertype.Name = "txt_usertype";
            this.txt_usertype.Size = new System.Drawing.Size(230, 23);
            this.txt_usertype.TabIndex = 2;
            this.txt_usertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usertype_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remarks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bttn_cancel);
            this.groupBox1.Controls.Add(this.bttn_save);
            this.groupBox1.Controls.Add(this.cmb_usertype);
            this.groupBox1.Controls.Add(this.txt_remarks);
            this.groupBox1.Controls.Add(this.txt_usertype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(198, 244);
            this.bttn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(110, 32);
            this.bttn_cancel.TabIndex = 5;
            this.bttn_cancel.Text = " Close";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            this.bttn_cancel.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_cancel.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.bttn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_save.Location = new System.Drawing.Point(79, 244);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(110, 32);
            this.bttn_save.TabIndex = 4;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            this.bttn_save.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_save.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Account Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Type";
            // 
            // UserAccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(399, 292);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccountType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account Type";
            this.Load += new System.EventHandler(this.UserAccountType_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_new;
        private System.Windows.Forms.RadioButton rb_edit;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.ComboBox cmb_usertype;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.TextBox txt_usertype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}