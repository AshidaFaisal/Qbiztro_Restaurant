namespace BisCarePosEdition
{
    partial class NewForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbox_masters = new System.Windows.Forms.ComboBox();
            this.lbl_parentid = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_stat = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_forecolor = new System.Windows.Forms.Label();
            this.btnlblForeClr = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFormColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.chk_status = new System.Windows.Forms.CheckBox();
            this.lbl_form = new System.Windows.Forms.Label();
            this.txt_formname = new System.Windows.Forms.TextBox();
            this.lbl_formname = new System.Windows.Forms.Label();
            this.Cmb_formname = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_displayname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbox_masters);
            this.groupBox3.Controls.Add(this.lbl_parentid);
            this.groupBox3.Controls.Add(this.btn_browse);
            this.groupBox3.Controls.Add(this.pb_photo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbl_stat);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.Btn_Delete);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.chk_status);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl_form);
            this.groupBox3.Controls.Add(this.txt_displayname);
            this.groupBox3.Controls.Add(this.txt_formname);
            this.groupBox3.Controls.Add(this.lbl_formname);
            this.groupBox3.Controls.Add(this.Cmb_formname);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 354);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // cbox_masters
            // 
            this.cbox_masters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_masters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_masters.DropDownWidth = 400;
            this.cbox_masters.Enabled = false;
            this.cbox_masters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_masters.FormattingEnabled = true;
            this.cbox_masters.Location = new System.Drawing.Point(127, 65);
            this.cbox_masters.Name = "cbox_masters";
            this.cbox_masters.Size = new System.Drawing.Size(198, 24);
            this.cbox_masters.TabIndex = 109;
            this.cbox_masters.SelectedIndexChanged += new System.EventHandler(this.cbox_masters_SelectedIndexChanged);
            // 
            // lbl_parentid
            // 
            this.lbl_parentid.AutoSize = true;
            this.lbl_parentid.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentid.ForeColor = System.Drawing.Color.Black;
            this.lbl_parentid.Location = new System.Drawing.Point(39, 72);
            this.lbl_parentid.Name = "lbl_parentid";
            this.lbl_parentid.Size = new System.Drawing.Size(52, 17);
            this.lbl_parentid.TabIndex = 108;
            this.lbl_parentid.Text = "Master ";
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Image = global::BisCarePosEdition.Properties.Resources.Browse2;
            this.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Location = new System.Drawing.Point(527, 256);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(115, 32);
            this.btn_browse.TabIndex = 106;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // pb_photo
            // 
            this.pb_photo.BackColor = System.Drawing.Color.White;
            this.pb_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_photo.ErrorImage = null;
            this.pb_photo.Location = new System.Drawing.Point(433, 85);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(209, 162);
            this.pb_photo.TabIndex = 105;
            this.pb_photo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(348, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "Button Icon";
            // 
            // lbl_stat
            // 
            this.lbl_stat.AutoSize = true;
            this.lbl_stat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stat.ForeColor = System.Drawing.Color.Black;
            this.lbl_stat.Location = new System.Drawing.Point(57, 283);
            this.lbl_stat.Name = "lbl_stat";
            this.lbl_stat.Size = new System.Drawing.Size(83, 17);
            this.lbl_stat.TabIndex = 103;
            this.lbl_stat.Text = "Form Status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_forecolor);
            this.groupBox5.Controls.Add(this.btnlblForeClr);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Location = new System.Drawing.Point(35, 211);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(289, 57);
            this.groupBox5.TabIndex = 102;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Label Style";
            // 
            // lbl_forecolor
            // 
            this.lbl_forecolor.AutoSize = true;
            this.lbl_forecolor.Location = new System.Drawing.Point(4, 26);
            this.lbl_forecolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_forecolor.Name = "lbl_forecolor";
            this.lbl_forecolor.Size = new System.Drawing.Size(99, 17);
            this.lbl_forecolor.TabIndex = 11;
            this.lbl_forecolor.Text = "Set Fore Color";
            // 
            // btnlblForeClr
            // 
            this.btnlblForeClr.Location = new System.Drawing.Point(129, 20);
            this.btnlblForeClr.Margin = new System.Windows.Forms.Padding(4);
            this.btnlblForeClr.Name = "btnlblForeClr";
            this.btnlblForeClr.Size = new System.Drawing.Size(152, 28);
            this.btnlblForeClr.TabIndex = 0;
            this.btnlblForeClr.Text = "Select";
            this.btnlblForeClr.UseVisualStyleBackColor = true;
            this.btnlblForeClr.Click += new System.EventHandler(this.btnlblForeClr_Click);
            this.btnlblForeClr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnlblForeClr_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFormColor);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(35, 129);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(289, 57);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Button Style";
            // 
            // btnFormColor
            // 
            this.btnFormColor.Location = new System.Drawing.Point(129, 21);
            this.btnFormColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormColor.Name = "btnFormColor";
            this.btnFormColor.Size = new System.Drawing.Size(152, 28);
            this.btnFormColor.TabIndex = 74;
            this.btnFormColor.Text = "Select";
            this.btnFormColor.UseVisualStyleBackColor = true;
            this.btnFormColor.Click += new System.EventHandler(this.btnFormColor_Click);
            this.btnFormColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnFormColor_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Button BackColor";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(319, 316);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 32);
            this.btn_cancel.TabIndex = 100;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.Btn_Delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(226, 316);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(111, 32);
            this.Btn_Delete.TabIndex = 99;
            this.Btn_Delete.Text = "   Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(121, 316);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 98;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chk_status
            // 
            this.chk_status.AutoSize = true;
            this.chk_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_status.Location = new System.Drawing.Point(36, 286);
            this.chk_status.Name = "chk_status";
            this.chk_status.Size = new System.Drawing.Size(15, 14);
            this.chk_status.TabIndex = 97;
            this.chk_status.UseVisualStyleBackColor = true;
            this.chk_status.CheckedChanged += new System.EventHandler(this.chk_status_CheckedChanged);
            this.chk_status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_status_KeyDown);
            // 
            // lbl_form
            // 
            this.lbl_form.AutoSize = true;
            this.lbl_form.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form.ForeColor = System.Drawing.Color.Black;
            this.lbl_form.Location = new System.Drawing.Point(39, 34);
            this.lbl_form.Name = "lbl_form";
            this.lbl_form.Size = new System.Drawing.Size(79, 17);
            this.lbl_form.TabIndex = 73;
            this.lbl_form.Text = "Form Name";
            // 
            // txt_formname
            // 
            this.txt_formname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_formname.Location = new System.Drawing.Point(127, 31);
            this.txt_formname.Name = "txt_formname";
            this.txt_formname.Size = new System.Drawing.Size(198, 23);
            this.txt_formname.TabIndex = 72;
            this.txt_formname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_formname_KeyDown);
            // 
            // lbl_formname
            // 
            this.lbl_formname.AutoSize = true;
            this.lbl_formname.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formname.ForeColor = System.Drawing.Color.Black;
            this.lbl_formname.Location = new System.Drawing.Point(348, 33);
            this.lbl_formname.Name = "lbl_formname";
            this.lbl_formname.Size = new System.Drawing.Size(79, 17);
            this.lbl_formname.TabIndex = 71;
            this.lbl_formname.Text = "Form Name";
            // 
            // Cmb_formname
            // 
            this.Cmb_formname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_formname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_formname.DropDownWidth = 400;
            this.Cmb_formname.Enabled = false;
            this.Cmb_formname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_formname.FormattingEnabled = true;
            this.Cmb_formname.Location = new System.Drawing.Point(433, 30);
            this.Cmb_formname.Name = "Cmb_formname";
            this.Cmb_formname.Size = new System.Drawing.Size(209, 24);
            this.Cmb_formname.TabIndex = 2;
            this.Cmb_formname.SelectedIndexChanged += new System.EventHandler(this.Cmb_formname_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_edit);
            this.groupBox2.Controls.Add(this.Rb_new);
            this.groupBox2.Location = new System.Drawing.Point(9, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 44);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Rb_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_edit.ForeColor = System.Drawing.Color.Maroon;
            this.Rb_edit.Location = new System.Drawing.Point(153, 12);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(50, 21);
            this.Rb_edit.TabIndex = 2;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = false;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Rb_new.Checked = true;
            this.Rb_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_new.ForeColor = System.Drawing.Color.Maroon;
            this.Rb_new.Location = new System.Drawing.Point(34, 14);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(53, 21);
            this.Rb_new.TabIndex = 1;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = false;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_displayname
            // 
            this.txt_displayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_displayname.Location = new System.Drawing.Point(128, 102);
            this.txt_displayname.Name = "txt_displayname";
            this.txt_displayname.Size = new System.Drawing.Size(198, 23);
            this.txt_displayname.TabIndex = 72;
            this.txt_displayname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_formname_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Display Name";
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_form;
        private System.Windows.Forms.TextBox txt_formname;
        private System.Windows.Forms.Label lbl_formname;
        private System.Windows.Forms.ComboBox Cmb_formname;
        private System.Windows.Forms.Button btnFormColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chk_status;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_forecolor;
        private System.Windows.Forms.Button btnlblForeClr;
        private System.Windows.Forms.Label lbl_stat;
        private System.Windows.Forms.Label lbl_parentid;
        private System.Windows.Forms.ComboBox cbox_masters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_displayname;
    }
}