namespace BisCarePosEdition
{
    partial class ItemSearch
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ch_Ingradiant = new System.Windows.Forms.RadioButton();
            this.ch_Product = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_itemname = new System.Windows.Forms.ComboBox();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_itemcode = new System.Windows.Forms.ComboBox();
            this.cmb_catname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gv_itemdetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.ch_itemcode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ch_itemname = new System.Windows.Forms.CheckBox();
            this.ch_category = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_itemdetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnrefresh);
            this.groupBox3.Controls.Add(this.bttn_cancel);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.gv_itemdetails);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(0, -3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1005, 479);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ch_Ingradiant);
            this.groupBox4.Controls.Add(this.ch_Product);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(6, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 43);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // ch_Ingradiant
            // 
            this.ch_Ingradiant.AutoSize = true;
            this.ch_Ingradiant.Location = new System.Drawing.Point(159, 16);
            this.ch_Ingradiant.Name = "ch_Ingradiant";
            this.ch_Ingradiant.Size = new System.Drawing.Size(138, 21);
            this.ch_Ingradiant.TabIndex = 6;
            this.ch_Ingradiant.TabStop = true;
            this.ch_Ingradiant.Text = "Include Ingredient";
            this.ch_Ingradiant.UseVisualStyleBackColor = true;
            // 
            // ch_Product
            // 
            this.ch_Product.AutoSize = true;
            this.ch_Product.Checked = true;
            this.ch_Product.Location = new System.Drawing.Point(22, 16);
            this.ch_Product.Name = "ch_Product";
            this.ch_Product.Size = new System.Drawing.Size(124, 21);
            this.ch_Product.TabIndex = 5;
            this.ch_Product.TabStop = true;
            this.ch_Product.Text = "Include Product";
            this.ch_Product.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::BisCarePosEdition.Properties.Resources.search4;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(349, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "       Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::BisCarePosEdition.Properties.Resources.reset;
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.Location = new System.Drawing.Point(696, 431);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(147, 39);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "     Reset";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            this.btnrefresh.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btnrefresh.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(851, 431);
            this.bttn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(147, 39);
            this.bttn_cancel.TabIndex = 3;
            this.bttn_cancel.Text = "Close";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            this.bttn_cancel.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.bttn_cancel.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_itemname);
            this.groupBox1.Controls.Add(this.lbl_itemname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_itemcode);
            this.groupBox1.Controls.Add(this.cmb_catname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(526, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // cmb_itemname
            // 
            this.cmb_itemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_itemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_itemname.DropDownWidth = 600;
            this.cmb_itemname.FormattingEnabled = true;
            this.cmb_itemname.Location = new System.Drawing.Point(86, 54);
            this.cmb_itemname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_itemname.Name = "cmb_itemname";
            this.cmb_itemname.Size = new System.Drawing.Size(433, 24);
            this.cmb_itemname.TabIndex = 1;
            this.cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.cmb_itemname_SelectedIndexChanged);
            this.cmb_itemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_itemname_KeyDown);
            this.cmb_itemname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_itemname_KeyPress);
            this.cmb_itemname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_itemname_MouseClick);
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Location = new System.Drawing.Point(7, 57);
            this.lbl_itemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(79, 17);
            this.lbl_itemname.TabIndex = 1;
            this.lbl_itemname.Text = "Item Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Code ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_itemcode
            // 
            this.cmb_itemcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_itemcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_itemcode.FormattingEnabled = true;
            this.cmb_itemcode.Location = new System.Drawing.Point(86, 20);
            this.cmb_itemcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_itemcode.Name = "cmb_itemcode";
            this.cmb_itemcode.Size = new System.Drawing.Size(90, 24);
            this.cmb_itemcode.TabIndex = 0;
            this.cmb_itemcode.SelectedIndexChanged += new System.EventHandler(this.cmb_itemcode_SelectedIndexChanged);
            this.cmb_itemcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_itemcode_KeyDown);
            this.cmb_itemcode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_itemcode_MouseClick);
            // 
            // cmb_catname
            // 
            this.cmb_catname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_catname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_catname.DropDownWidth = 300;
            this.cmb_catname.FormattingEnabled = true;
            this.cmb_catname.Location = new System.Drawing.Point(247, 21);
            this.cmb_catname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_catname.Name = "cmb_catname";
            this.cmb_catname.Size = new System.Drawing.Size(272, 24);
            this.cmb_catname.TabIndex = 2;
            this.cmb_catname.SelectedIndexChanged += new System.EventHandler(this.cmb_catname_SelectedIndexChanged);
            this.cmb_catname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_catname_KeyDown);
            this.cmb_catname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_catname_KeyPress);
            this.cmb_catname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_catname_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category ";
            // 
            // gv_itemdetails
            // 
            this.gv_itemdetails.AllowUserToAddRows = false;
            this.gv_itemdetails.AllowUserToDeleteRows = false;
            this.gv_itemdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_itemdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column10});
            this.gv_itemdetails.Location = new System.Drawing.Point(6, 157);
            this.gv_itemdetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gv_itemdetails.Name = "gv_itemdetails";
            this.gv_itemdetails.ReadOnly = true;
            this.gv_itemdetails.RowHeadersWidth = 5;
            this.gv_itemdetails.Size = new System.Drawing.Size(992, 265);
            this.gv_itemdetails.TabIndex = 4;
            this.gv_itemdetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_itemdetails_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sl #";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item Code";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 290;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Category";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Unit";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cost Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sell Price";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ItemId";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.txt_text);
            this.groupBox2.Controls.Add(this.ch_itemcode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ch_itemname);
            this.groupBox2.Controls.Add(this.ch_category);
            this.groupBox2.Location = new System.Drawing.Point(538, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(460, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::BisCarePosEdition.Properties.Resources.search4;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(335, 26);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(111, 32);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "      Find";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_search_KeyDown);
            this.btn_search.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_search.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // txt_text
            // 
            this.txt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_text.Location = new System.Drawing.Point(84, 25);
            this.txt_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(239, 30);
            this.txt_text.TabIndex = 12;
            // 
            // ch_itemcode
            // 
            this.ch_itemcode.AutoSize = true;
            this.ch_itemcode.Location = new System.Drawing.Point(127, 84);
            this.ch_itemcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_itemcode.Name = "ch_itemcode";
            this.ch_itemcode.Size = new System.Drawing.Size(90, 21);
            this.ch_itemcode.TabIndex = 17;
            this.ch_itemcode.Text = "Item Code";
            this.ch_itemcode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Text ";
            // 
            // ch_itemname
            // 
            this.ch_itemname.AutoSize = true;
            this.ch_itemname.Location = new System.Drawing.Point(7, 84);
            this.ch_itemname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_itemname.Name = "ch_itemname";
            this.ch_itemname.Size = new System.Drawing.Size(94, 21);
            this.ch_itemname.TabIndex = 14;
            this.ch_itemname.Text = "Item Name";
            this.ch_itemname.UseVisualStyleBackColor = true;
            // 
            // ch_category
            // 
            this.ch_category.AutoSize = true;
            this.ch_category.Location = new System.Drawing.Point(239, 84);
            this.ch_category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_category.Name = "ch_category";
            this.ch_category.Size = new System.Drawing.Size(84, 21);
            this.ch_category.TabIndex = 15;
            this.ch_category.Text = "Category";
            this.ch_category.UseVisualStyleBackColor = true;
            // 
            // ItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1014, 481);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Search";
            this.Load += new System.EventHandler(this.ItemSearch_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_itemdetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_itemname;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_itemcode;
        private System.Windows.Forms.ComboBox cmb_catname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gv_itemdetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.CheckBox ch_itemcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ch_itemname;
        private System.Windows.Forms.CheckBox ch_category;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ch_Ingradiant;
        private System.Windows.Forms.RadioButton ch_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}