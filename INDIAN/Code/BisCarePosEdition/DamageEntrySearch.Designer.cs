namespace BisCarePosEdition
{
    partial class DamageEntrySearch
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
            this.ch_itemname = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_oldStock = new System.Windows.Forms.CheckBox();
            this.ch_date = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grpitem = new System.Windows.Forms.GroupBox();
            this.cmb_itemname = new System.Windows.Forms.ComboBox();
            this.lbl_itm = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.grpdate = new System.Windows.Forms.GroupBox();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gv_stocksearch = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grpitem.SuspendLayout();
            this.grpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stocksearch)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_itemname
            // 
            this.ch_itemname.AutoSize = true;
            this.ch_itemname.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_itemname.Location = new System.Drawing.Point(143, 20);
            this.ch_itemname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_itemname.Name = "ch_itemname";
            this.ch_itemname.Size = new System.Drawing.Size(164, 22);
            this.ch_itemname.TabIndex = 0;
            this.ch_itemname.Text = "Include Dealer Name";
            this.ch_itemname.UseVisualStyleBackColor = true;
            this.ch_itemname.Visible = false;
            this.ch_itemname.CheckedChanged += new System.EventHandler(this.ch_itemname_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chk_oldStock);
            this.groupBox1.Controls.Add(this.ch_date);
            this.groupBox1.Controls.Add(this.ch_itemname);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.grpitem);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.grpdate);
            this.groupBox1.Controls.Add(this.gv_stocksearch);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(801, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // chk_oldStock
            // 
            this.chk_oldStock.AutoSize = true;
            this.chk_oldStock.Checked = true;
            this.chk_oldStock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_oldStock.Location = new System.Drawing.Point(418, 112);
            this.chk_oldStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_oldStock.Name = "chk_oldStock";
            this.chk_oldStock.Size = new System.Drawing.Size(73, 17);
            this.chk_oldStock.TabIndex = 6;
            this.chk_oldStock.Text = "Old Stock";
            this.chk_oldStock.UseVisualStyleBackColor = true;
            this.chk_oldStock.Visible = false;
            this.chk_oldStock.CheckedChanged += new System.EventHandler(this.chk_oldStock_CheckedChanged);
            // 
            // ch_date
            // 
            this.ch_date.AutoSize = true;
            this.ch_date.Checked = true;
            this.ch_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_date.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_date.Location = new System.Drawing.Point(16, 20);
            this.ch_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_date.Name = "ch_date";
            this.ch_date.Size = new System.Drawing.Size(110, 22);
            this.ch_date.TabIndex = 0;
            this.ch_date.Text = "Include Date";
            this.ch_date.UseVisualStyleBackColor = true;
            this.ch_date.CheckedChanged += new System.EventHandler(this.ch_date_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(685, 103);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "  Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // grpitem
            // 
            this.grpitem.Controls.Add(this.cmb_itemname);
            this.grpitem.Controls.Add(this.lbl_itm);
            this.grpitem.Location = new System.Drawing.Point(418, 25);
            this.grpitem.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpitem.Name = "grpitem";
            this.grpitem.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpitem.Size = new System.Drawing.Size(377, 56);
            this.grpitem.TabIndex = 1;
            this.grpitem.TabStop = false;
            this.grpitem.Text = "By Dealer";
            this.grpitem.Visible = false;
            // 
            // cmb_itemname
            // 
            this.cmb_itemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_itemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_itemname.FormattingEnabled = true;
            this.cmb_itemname.Location = new System.Drawing.Point(100, 24);
            this.cmb_itemname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_itemname.Name = "cmb_itemname";
            this.cmb_itemname.Size = new System.Drawing.Size(257, 24);
            this.cmb_itemname.TabIndex = 0;
            this.cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.cmb_itemname_SelectedIndexChanged);
            this.cmb_itemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_itemname_KeyDown);
            this.cmb_itemname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_itemname_KeyPress);
            // 
            // lbl_itm
            // 
            this.lbl_itm.AutoSize = true;
            this.lbl_itm.Location = new System.Drawing.Point(19, 27);
            this.lbl_itm.Name = "lbl_itm";
            this.lbl_itm.Size = new System.Drawing.Size(46, 17);
            this.lbl_itm.TabIndex = 1;
            this.lbl_itm.Text = "Dealer";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = global::BisCarePosEdition.Properties.Resources.search4;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(562, 103);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(117, 32);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "       Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_search.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // grpdate
            // 
            this.grpdate.Controls.Add(this.dtp_start);
            this.grpdate.Controls.Add(this.dtp_end);
            this.grpdate.Controls.Add(this.label1);
            this.grpdate.Controls.Add(this.label2);
            this.grpdate.Location = new System.Drawing.Point(15, 45);
            this.grpdate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpdate.Name = "grpdate";
            this.grpdate.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpdate.Size = new System.Drawing.Size(344, 90);
            this.grpdate.TabIndex = 2;
            this.grpdate.TabStop = false;
            this.grpdate.Text = "By Date";
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(88, 20);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(251, 24);
            this.dtp_start.TabIndex = 0;
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(88, 57);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(251, 24);
            this.dtp_end.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date ";
            // 
            // gv_stocksearch
            // 
            this.gv_stocksearch.AllowUserToAddRows = false;
            this.gv_stocksearch.AllowUserToDeleteRows = false;
            this.gv_stocksearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_stocksearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_stocksearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column10,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column11});
            this.gv_stocksearch.Location = new System.Drawing.Point(11, 143);
            this.gv_stocksearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gv_stocksearch.Name = "gv_stocksearch";
            this.gv_stocksearch.ReadOnly = true;
            this.gv_stocksearch.RowHeadersVisible = false;
            this.gv_stocksearch.RowHeadersWidth = 5;
            this.gv_stocksearch.Size = new System.Drawing.Size(785, 250);
            this.gv_stocksearch.TabIndex = 5;
            this.gv_stocksearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_stocksearch_CellDoubleClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sl #";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dealer";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dealer Ref #";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 130;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Paid Amount";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Discount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 115;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Purchase Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "itemid";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "User";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 400;
            // 
            // DamageEntrySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(816, 410);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DamageEntrySearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Damage Entry Search";
            this.Load += new System.EventHandler(this.StockEntrySearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpitem.ResumeLayout(false);
            this.grpitem.PerformLayout();
            this.grpdate.ResumeLayout(false);
            this.grpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stocksearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ch_itemname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpitem;
        private System.Windows.Forms.ComboBox cmb_itemname;
        private System.Windows.Forms.Label lbl_itm;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox grpdate;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gv_stocksearch;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox ch_date;
        private System.Windows.Forms.CheckBox chk_oldStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}