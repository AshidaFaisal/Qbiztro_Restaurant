namespace BisCarePosEdition
{
    partial class Category
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
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_image = new System.Windows.Forms.Label();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_countersale = new System.Windows.Forms.RadioButton();
            this.rd_increadiant = new System.Windows.Forms.RadioButton();
            this.rd_Product = new System.Windows.Forms.RadioButton();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.btn_browse);
            this.gbCategory.Controls.Add(this.lbl_image);
            this.gbCategory.Controls.Add(this.pb_photo);
            this.gbCategory.Controls.Add(this.groupBox2);
            this.gbCategory.Controls.Add(this.groupBox1);
            this.gbCategory.Controls.Add(this.txt_remarks);
            this.gbCategory.Controls.Add(this.Btn_Delete);
            this.gbCategory.Controls.Add(this.btn_cancel);
            this.gbCategory.Controls.Add(this.btn_save);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Controls.Add(this.txt_name);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Controls.Add(this.cmb_category);
            this.gbCategory.Controls.Add(this.label7);
            this.gbCategory.Location = new System.Drawing.Point(6, 2);
            this.gbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCategory.Size = new System.Drawing.Size(697, 273);
            this.gbCategory.TabIndex = 0;
            this.gbCategory.TabStop = false;
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
            this.btn_browse.Location = new System.Drawing.Point(560, 223);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(115, 32);
            this.btn_browse.TabIndex = 96;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_image.Location = new System.Drawing.Point(432, 21);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(78, 17);
            this.lbl_image.TabIndex = 17;
            this.lbl_image.Text = "Item Image";
            // 
            // pb_photo
            // 
            this.pb_photo.Image = global::BisCarePosEdition.Properties.Resources.RestaurantWall;
            this.pb_photo.Location = new System.Drawing.Point(435, 47);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(240, 172);
            this.pb_photo.TabIndex = 16;
            this.pb_photo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_edit);
            this.groupBox2.Controls.Add(this.Rb_new);
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(125, 51);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_edit.Location = new System.Drawing.Point(65, 19);
            this.Rb_edit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(49, 21);
            this.Rb_edit.TabIndex = 1;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_new.Location = new System.Drawing.Point(9, 19);
            this.Rb_new.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(52, 21);
            this.Rb_new.TabIndex = 0;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_countersale);
            this.groupBox1.Controls.Add(this.rd_increadiant);
            this.groupBox1.Controls.Add(this.rd_Product);
            this.groupBox1.Location = new System.Drawing.Point(135, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(287, 51);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // rd_countersale
            // 
            this.rd_countersale.AutoSize = true;
            this.rd_countersale.ForeColor = System.Drawing.Color.Black;
            this.rd_countersale.Location = new System.Drawing.Point(175, 19);
            this.rd_countersale.Name = "rd_countersale";
            this.rd_countersale.Size = new System.Drawing.Size(104, 21);
            this.rd_countersale.TabIndex = 3;
            this.rd_countersale.Text = "Counter Sale";
            this.rd_countersale.UseVisualStyleBackColor = true;
            this.rd_countersale.CheckedChanged += new System.EventHandler(this.rd_countersale_CheckedChanged);
            // 
            // rd_increadiant
            // 
            this.rd_increadiant.AutoSize = true;
            this.rd_increadiant.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_increadiant.Location = new System.Drawing.Point(83, 19);
            this.rd_increadiant.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rd_increadiant.Name = "rd_increadiant";
            this.rd_increadiant.Size = new System.Drawing.Size(88, 21);
            this.rd_increadiant.TabIndex = 1;
            this.rd_increadiant.Text = "Ingredient";
            this.rd_increadiant.UseVisualStyleBackColor = true;
            this.rd_increadiant.CheckedChanged += new System.EventHandler(this.rd_increadiant_CheckedChanged);
            // 
            // rd_Product
            // 
            this.rd_Product.AutoSize = true;
            this.rd_Product.Checked = true;
            this.rd_Product.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Product.Location = new System.Drawing.Point(7, 19);
            this.rd_Product.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rd_Product.Name = "rd_Product";
            this.rd_Product.Size = new System.Drawing.Size(75, 21);
            this.rd_Product.TabIndex = 0;
            this.rd_Product.TabStop = true;
            this.rd_Product.Text = "Product";
            this.rd_Product.UseVisualStyleBackColor = true;
            this.rd_Product.CheckedChanged += new System.EventHandler(this.rd_Product_CheckedChanged);
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(124, 174);
            this.txt_remarks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_remarks.MaxLength = 50;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(289, 27);
            this.txt_remarks.TabIndex = 3;
            this.txt_remarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_remarks_KeyDown);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(187, 221);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(110, 32);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "   Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            this.Btn_Delete.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.Btn_Delete.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(303, 221);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(71, 221);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Remarks";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(124, 130);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(289, 27);
            this.txt_name.TabIndex = 2;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category Name";
            // 
            // cmb_category
            // 
            this.cmb_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_category.Enabled = false;
            this.cmb_category.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(124, 85);
            this.cmb_category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(289, 27);
            this.cmb_category.TabIndex = 1;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            this.cmb_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_category_KeyDown);
            this.cmb_category.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_category_KeyPress);
            this.cmb_category.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_category_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Select Category";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(715, 282);
            this.Controls.Add(this.gbCategory);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Category";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_increadiant;
        private System.Windows.Forms.RadioButton rd_Product;
        private System.Windows.Forms.RadioButton rd_countersale;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}