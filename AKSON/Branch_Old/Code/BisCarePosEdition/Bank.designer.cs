namespace BisCarePosEdition
{
    partial class Bank
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
            this.cmb_bankname = new System.Windows.Forms.ComboBox();
            this.rb_edit = new System.Windows.Forms.RadioButton();
            this.rb_new = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phno = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_branch = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phno = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_opening = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_bankname
            // 
            this.cmb_bankname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_bankname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_bankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bankname.FormattingEnabled = true;
            this.cmb_bankname.Location = new System.Drawing.Point(301, 40);
            this.cmb_bankname.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_bankname.Name = "cmb_bankname";
            this.cmb_bankname.Size = new System.Drawing.Size(217, 24);
            this.cmb_bankname.TabIndex = 3;
            this.cmb_bankname.SelectedIndexChanged += new System.EventHandler(this.cmb_bankname_SelectedIndexChanged);
            this.cmb_bankname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_bankname_MouseClick);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_edit.Location = new System.Drawing.Point(144, 24);
            this.rb_edit.Margin = new System.Windows.Forms.Padding(4);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(49, 21);
            this.rb_edit.TabIndex = 2;
            this.rb_edit.TabStop = true;
            this.rb_edit.Text = "Edit";
            this.rb_edit.UseVisualStyleBackColor = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_edit_CheckedChanged);
            // 
            // rb_new
            // 
            this.rb_new.AutoSize = true;
            this.rb_new.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_new.Location = new System.Drawing.Point(17, 24);
            this.rb_new.Margin = new System.Windows.Forms.Padding(4);
            this.rb_new.Name = "rb_new";
            this.rb_new.Size = new System.Drawing.Size(52, 21);
            this.rb_new.TabIndex = 1;
            this.rb_new.TabStop = true;
            this.rb_new.Text = "New";
            this.rb_new.UseVisualStyleBackColor = true;
            this.rb_new.CheckedChanged += new System.EventHandler(this.rb_new_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(348, 277);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "   Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(112, 277);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = " Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_branch
            // 
            this.txt_branch.Location = new System.Drawing.Point(56, 145);
            this.txt_branch.Margin = new System.Windows.Forms.Padding(4);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.Size = new System.Drawing.Size(180, 24);
            this.txt_branch.TabIndex = 5;
            this.txt_branch.DoubleClick += new System.EventHandler(this.txt_branch_DoubleClick);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(56, 186);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(180, 24);
            this.txt_email.TabIndex = 6;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            this.txt_email.DoubleClick += new System.EventHandler(this.txt_email_DoubleClick);
            this.txt_email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_email_Validating);
            // 
            // txt_phno
            // 
            this.txt_phno.Location = new System.Drawing.Point(370, 145);
            this.txt_phno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phno.MaxLength = 12;
            this.txt_phno.Name = "txt_phno";
            this.txt_phno.Size = new System.Drawing.Size(180, 24);
            this.txt_phno.TabIndex = 9;
            this.txt_phno.TextChanged += new System.EventHandler(this.txt_phno_TextChanged);
            this.txt_phno.DoubleClick += new System.EventHandler(this.txt_phno_DoubleClick);
            this.txt_phno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phno_KeyPress);
            this.txt_phno.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phno_Validating);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(370, 102);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(180, 24);
            this.txt_address.TabIndex = 8;
            this.txt_address.DoubleClick += new System.EventHandler(this.txt_address_DoubleClick);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(56, 102);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 24);
            this.txt_name.TabIndex = 4;
            this.txt_name.DoubleClick += new System.EventHandler(this.txt_name_DoubleClick);
            // 
            // lbl_branch
            // 
            this.lbl_branch.AutoSize = true;
            this.lbl_branch.Location = new System.Drawing.Point(1, 148);
            this.lbl_branch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_branch.Name = "lbl_branch";
            this.lbl_branch.Size = new System.Drawing.Size(51, 17);
            this.lbl_branch.TabIndex = 20;
            this.lbl_branch.Text = "Branch";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(10, 190);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(39, 17);
            this.lbl_email.TabIndex = 19;
            this.lbl_email.Text = "Email";
            // 
            // lbl_phno
            // 
            this.lbl_phno.AutoSize = true;
            this.lbl_phno.Location = new System.Drawing.Point(298, 148);
            this.lbl_phno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phno.Name = "lbl_phno";
            this.lbl_phno.Size = new System.Drawing.Size(68, 17);
            this.lbl_phno.TabIndex = 18;
            this.lbl_phno.Text = "Phone No";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(310, 105);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(56, 17);
            this.lbl_address.TabIndex = 17;
            this.lbl_address.Text = "Address";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(8, 106);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 17);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_accno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_opening);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_bankname);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_address);
            this.groupBox1.Controls.Add(this.lbl_phno);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_branch);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_phno);
            this.groupBox1.Controls.Add(this.txt_branch);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "A/C No";
            // 
            // txt_accno
            // 
            this.txt_accno.Location = new System.Drawing.Point(56, 234);
            this.txt_accno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_accno.MaxLength = 16;
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.Size = new System.Drawing.Size(180, 24);
            this.txt_accno.TabIndex = 7;
            this.txt_accno.TextChanged += new System.EventHandler(this.txt_accno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Opening Balance";
            // 
            // txt_opening
            // 
            this.txt_opening.Location = new System.Drawing.Point(370, 186);
            this.txt_opening.Margin = new System.Windows.Forms.Padding(4);
            this.txt_opening.MaxLength = 12;
            this.txt_opening.Name = "txt_opening";
            this.txt_opening.Size = new System.Drawing.Size(180, 24);
            this.txt_opening.TabIndex = 10;
            this.txt_opening.Text = "0";
            this.txt_opening.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_opening.TextChanged += new System.EventHandler(this.txt_opening_TextChanged);
            this.txt_opening.DoubleClick += new System.EventHandler(this.txt_opening_DoubleClick);
            this.txt_opening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_opening_KeyPress);
            // 
            // button1
            // 
            this.button1.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(230, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "   Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_new);
            this.groupBox2.Controls.Add(this.rb_edit);
            this.groupBox2.Location = new System.Drawing.Point(14, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 60);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 344);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_bankname;
        private System.Windows.Forms.RadioButton rb_edit;
        private System.Windows.Forms.RadioButton rb_new;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_branch;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phno;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_branch;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phno;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_opening;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_accno;
    }
}