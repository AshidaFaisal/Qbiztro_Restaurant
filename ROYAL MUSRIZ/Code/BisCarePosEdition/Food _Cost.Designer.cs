namespace BisCarePosEdition
{
    partial class Food__Cost
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
            this.Gv_itemmapp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.lblunit = new System.Windows.Forms.Label();
            this.cmb_mainitem_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_subitem_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foodcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_savefood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_itemmapp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gv_itemmapp
            // 
            this.Gv_itemmapp.AllowUserToAddRows = false;
            this.Gv_itemmapp.AllowUserToDeleteRows = false;
            this.Gv_itemmapp.BackgroundColor = System.Drawing.Color.SlateGray;
            this.Gv_itemmapp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_itemmapp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.CostPrice,
            this.Foodcost,
            this.Column7});
            this.Gv_itemmapp.Location = new System.Drawing.Point(49, 72);
            this.Gv_itemmapp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Gv_itemmapp.Name = "Gv_itemmapp";
            this.Gv_itemmapp.RowHeadersWidth = 5;
            this.Gv_itemmapp.Size = new System.Drawing.Size(568, 303);
            this.Gv_itemmapp.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_savefood);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cost);
            this.groupBox1.Controls.Add(this.Btn_Reset);
            this.groupBox1.Controls.Add(this.lblunit);
            this.groupBox1.Controls.Add(this.Gv_itemmapp);
            this.groupBox1.Controls.Add(this.cmb_mainitem_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.cmb_subitem_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(676, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Food Cost";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(436, 381);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(178, 24);
            this.txt_cost.TabIndex = 7;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.Image = global::BisCarePosEdition.Properties.Resources.reset1;
            this.Btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reset.Location = new System.Drawing.Point(136, 158);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(110, 32);
            this.Btn_Reset.TabIndex = 5;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Visible = false;
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.Location = new System.Drawing.Point(296, 123);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(32, 17);
            this.lblunit.TabIndex = 3;
            this.lblunit.Text = "Unit";
            this.lblunit.Visible = false;
            // 
            // cmb_mainitem_id
            // 
            this.cmb_mainitem_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_mainitem_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_mainitem_id.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mainitem_id.FormattingEnabled = true;
            this.cmb_mainitem_id.Location = new System.Drawing.Point(92, 24);
            this.cmb_mainitem_id.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmb_mainitem_id.Name = "cmb_mainitem_id";
            this.cmb_mainitem_id.Size = new System.Drawing.Size(269, 24);
            this.cmb_mainitem_id.TabIndex = 0;
            this.cmb_mainitem_id.SelectedIndexChanged += new System.EventHandler(this.cmb_mainitem_id_SelectedIndexChanged);
            this.cmb_mainitem_id.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_mainitem_id_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(251, 158);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredient";
            this.label2.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(19, 158);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 32);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            // 
            // cmb_subitem_id
            // 
            this.cmb_subitem_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_subitem_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_subitem_id.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_subitem_id.FormattingEnabled = true;
            this.cmb_subitem_id.Location = new System.Drawing.Point(83, 72);
            this.cmb_subitem_id.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmb_subitem_id.Name = "cmb_subitem_id";
            this.cmb_subitem_id.Size = new System.Drawing.Size(269, 24);
            this.cmb_subitem_id.TabIndex = 1;
            this.cmb_subitem_id.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            this.label3.Visible = false;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(83, 120);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_quantity.MaxLength = 8;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(208, 24);
            this.txt_quantity.TabIndex = 2;
            this.txt_quantity.Text = "0";
            this.txt_quantity.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ingredient";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unit";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ProductId";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IngredientId";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "CostPrice";
            this.CostPrice.Name = "CostPrice";
            // 
            // Foodcost
            // 
            this.Foodcost.HeaderText = "Foodcost";
            this.Foodcost.Name = "Foodcost";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Delete";
            this.Column7.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 80;
            // 
            // btn_savefood
            // 
            this.btn_savefood.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_savefood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savefood.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savefood.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_savefood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_savefood.Location = new System.Drawing.Point(367, 19);
            this.btn_savefood.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_savefood.Name = "btn_savefood";
            this.btn_savefood.Size = new System.Drawing.Size(110, 32);
            this.btn_savefood.TabIndex = 9;
            this.btn_savefood.Text = "Save";
            this.btn_savefood.UseVisualStyleBackColor = false;
            this.btn_savefood.Click += new System.EventHandler(this.btn_savefood_Click);
            // 
            // Food__Cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Controls.Add(this.groupBox1);
            this.Name = "Food__Cost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Cost";
            this.Load += new System.EventHandler(this.Food__Cost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_itemmapp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Gv_itemmapp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.ComboBox cmb_mainitem_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_subitem_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foodcost;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.Button btn_savefood;

    }
}