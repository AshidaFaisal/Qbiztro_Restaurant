namespace BisCarePosEdition
{
    partial class User
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
            this.label9 = new System.Windows.Forms.Label();
            this.Cmb_username = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.cmb_designation = new System.Windows.Forms.ComboBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_confrmpassword = new System.Windows.Forms.TextBox();
            this.cmb_accounttype = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_newcategory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUserRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "User Name ";
            // 
            // Cmb_username
            // 
            this.Cmb_username.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_username.FormattingEnabled = true;
            this.Cmb_username.Location = new System.Drawing.Point(339, 37);
            this.Cmb_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmb_username.Name = "Cmb_username";
            this.Cmb_username.Size = new System.Drawing.Size(323, 24);
            this.Cmb_username.TabIndex = 1;
            this.Cmb_username.SelectedIndexChanged += new System.EventHandler(this.Cmb_username_SelectedIndexChanged);
            this.Cmb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_username_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_edit);
            this.groupBox2.Controls.Add(this.Rb_new);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(213, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Location = new System.Drawing.Point(127, 23);
            this.Rb_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(50, 21);
            this.Rb_edit.TabIndex = 1;
            this.Rb_edit.TabStop = true;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Location = new System.Drawing.Point(33, 23);
            this.Rb_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(52, 21);
            this.Rb_new.TabIndex = 0;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            // 
            // cmb_designation
            // 
            this.cmb_designation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_designation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_designation.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_designation.FormattingEnabled = true;
            this.cmb_designation.Location = new System.Drawing.Point(461, 198);
            this.cmb_designation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_designation.Name = "cmb_designation";
            this.cmb_designation.Size = new System.Drawing.Size(170, 24);
            this.cmb_designation.TabIndex = 8;
            this.cmb_designation.SelectedIndexChanged += new System.EventHandler(this.cmb_designation_SelectedIndexChanged);
            this.cmb_designation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_designation_KeyDown);
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(461, 148);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_contact.MaxLength = 50;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(201, 24);
            this.txt_contact.TabIndex = 7;
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            this.txt_contact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contact_KeyDown);
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(461, 98);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(201, 24);
            this.txt_name.TabIndex = 6;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // txt_confrmpassword
            // 
            this.txt_confrmpassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confrmpassword.Location = new System.Drawing.Point(143, 223);
            this.txt_confrmpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_confrmpassword.MaxLength = 50;
            this.txt_confrmpassword.Name = "txt_confrmpassword";
            this.txt_confrmpassword.PasswordChar = '*';
            this.txt_confrmpassword.Size = new System.Drawing.Size(201, 24);
            this.txt_confrmpassword.TabIndex = 5;
            this.txt_confrmpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_confrmpassword_KeyDown);
            // 
            // cmb_accounttype
            // 
            this.cmb_accounttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_accounttype.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_accounttype.FormattingEnabled = true;
            this.cmb_accounttype.Location = new System.Drawing.Point(143, 98);
            this.cmb_accounttype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_accounttype.Name = "cmb_accounttype";
            this.cmb_accounttype.Size = new System.Drawing.Size(201, 24);
            this.cmb_accounttype.TabIndex = 2;
            this.cmb_accounttype.SelectedIndexChanged += new System.EventHandler(this.cmb_accounttype_SelectedIndexChanged);
            this.cmb_accounttype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_accounttype_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(143, 183);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(201, 24);
            this.txt_password.TabIndex = 4;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(143, 140);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_username.MaxLength = 50;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(201, 24);
            this.txt_username.TabIndex = 3;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Designation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bttn_newcategory);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnUserRight);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Cmb_username);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bttn_cancel);
            this.groupBox1.Controls.Add(this.bttn_save);
            this.groupBox1.Controls.Add(this.cmb_designation);
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_confrmpassword);
            this.groupBox1.Controls.Add(this.cmb_accounttype);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(678, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bttn_newcategory
            // 
            this.bttn_newcategory.BackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.BorderSize = 0;
            this.bttn_newcategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_newcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_newcategory.Image = global::BisCarePosEdition.Properties.Resources.Add_;
            this.bttn_newcategory.Location = new System.Drawing.Point(637, 198);
            this.bttn_newcategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttn_newcategory.Name = "bttn_newcategory";
            this.bttn_newcategory.Size = new System.Drawing.Size(25, 25);
            this.bttn_newcategory.TabIndex = 9;
            this.bttn_newcategory.UseVisualStyleBackColor = false;
            this.bttn_newcategory.Click += new System.EventHandler(this.bttn_newcategory_Click);
            this.bttn_newcategory.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_save_Paint);
            this.bttn_newcategory.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_newcategory.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::BisCarePosEdition.Properties.Resources.Add_;
            this.button2.Location = new System.Drawing.Point(350, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 97;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_save_Paint);
            this.button2.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // btnUserRight
            // 
            this.btnUserRight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUserRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRight.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRight.Image = global::BisCarePosEdition.Properties.Resources.Backup;
            this.btnUserRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRight.Location = new System.Drawing.Point(432, 263);
            this.btnUserRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserRight.Name = "btnUserRight";
            this.btnUserRight.Size = new System.Drawing.Size(166, 32);
            this.btnUserRight.TabIndex = 13;
            this.btnUserRight.Text = "      User Right Settings";
            this.btnUserRight.UseVisualStyleBackColor = false;
            this.btnUserRight.Click += new System.EventHandler(this.btnUserRight_Click);
            this.btnUserRight.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.btnUserRight.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(200, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "   Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(316, 263);
            this.bttn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(110, 32);
            this.bttn_cancel.TabIndex = 12;
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
            this.bttn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.bttn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_save.Location = new System.Drawing.Point(84, 263);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(110, 32);
            this.bttn_save.TabIndex = 10;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            this.bttn_save.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_save.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm password ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account type ";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(689, 306);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_newcategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUserRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cmb_username;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.ComboBox cmb_designation;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_confrmpassword;
        private System.Windows.Forms.ComboBox cmb_accounttype;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}