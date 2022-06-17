namespace BisCarePosEdition
{
    partial class Tables
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
            this.radioEdit = new System.Windows.Forms.RadioButton();
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listbox_tables = new System.Windows.Forms.ListBox();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnNonAc = new System.Windows.Forms.CheckBox();
            this.rbtnAC = new System.Windows.Forms.CheckBox();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.rbtnNonAc);
            this.gbCategory.Controls.Add(this.rbtnAC);
            this.gbCategory.Controls.Add(this.radioEdit);
            this.gbCategory.Controls.Add(this.radioNew);
            this.gbCategory.Controls.Add(this.button1);
            this.gbCategory.Controls.Add(this.listbox_tables);
            this.gbCategory.Controls.Add(this.txt_remarks);
            this.gbCategory.Controls.Add(this.btn_cancel);
            this.gbCategory.Controls.Add(this.btn_save);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Controls.Add(this.txt_name);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Location = new System.Drawing.Point(9, 3);
            this.gbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCategory.Size = new System.Drawing.Size(387, 397);
            this.gbCategory.TabIndex = 0;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Table Details";
            // 
            // radioEdit
            // 
            this.radioEdit.AutoSize = true;
            this.radioEdit.Location = new System.Drawing.Point(190, 24);
            this.radioEdit.Name = "radioEdit";
            this.radioEdit.Size = new System.Drawing.Size(49, 21);
            this.radioEdit.TabIndex = 17;
            this.radioEdit.TabStop = true;
            this.radioEdit.Text = "Edit";
            this.radioEdit.UseVisualStyleBackColor = true;
            this.radioEdit.CheckedChanged += new System.EventHandler(this.radioEdit_CheckedChanged);
            // 
            // radioNew
            // 
            this.radioNew.AutoSize = true;
            this.radioNew.Checked = true;
            this.radioNew.Location = new System.Drawing.Point(119, 24);
            this.radioNew.Name = "radioNew";
            this.radioNew.Size = new System.Drawing.Size(52, 21);
            this.radioNew.TabIndex = 16;
            this.radioNew.TabStop = true;
            this.radioNew.Text = "New";
            this.radioNew.UseVisualStyleBackColor = true;
            this.radioNew.CheckedChanged += new System.EventHandler(this.radioNew_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(135, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "   Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // listbox_tables
            // 
            this.listbox_tables.FormattingEnabled = true;
            this.listbox_tables.ItemHeight = 16;
            this.listbox_tables.Location = new System.Drawing.Point(12, 214);
            this.listbox_tables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbox_tables.Name = "listbox_tables";
            this.listbox_tables.Size = new System.Drawing.Size(365, 164);
            this.listbox_tables.TabIndex = 5;
            this.listbox_tables.SelectedIndexChanged += new System.EventHandler(this.listbox_tables_SelectedIndexChanged);
            this.listbox_tables.DoubleClick += new System.EventHandler(this.listbox_tables_DoubleClick);
            this.listbox_tables.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listbox_tables_KeyDown);
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(115, 112);
            this.txt_remarks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_remarks.MaxLength = 250;
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(262, 51);
            this.txt_remarks.TabIndex = 1;
            this.txt_remarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_remarks_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(260, 173);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(117, 32);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "  Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(12, 173);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 32);
            this.btn_save.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(18, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Remarks";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(115, 50);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(262, 24);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Table Name";
            // 
            // rbtnNonAc
            // 
            this.rbtnNonAc.AutoSize = true;
            this.rbtnNonAc.Location = new System.Drawing.Point(190, 83);
            this.rbtnNonAc.Name = "rbtnNonAc";
            this.rbtnNonAc.Size = new System.Drawing.Size(73, 21);
            this.rbtnNonAc.TabIndex = 21;
            this.rbtnNonAc.Text = "Non AC";
            this.rbtnNonAc.UseVisualStyleBackColor = true;
            this.rbtnNonAc.CheckedChanged += new System.EventHandler(this.rbtnNonAc_CheckedChanged);
            // 
            // rbtnAC
            // 
            this.rbtnAC.AutoSize = true;
            this.rbtnAC.Checked = true;
            this.rbtnAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbtnAC.Location = new System.Drawing.Point(119, 83);
            this.rbtnAC.Name = "rbtnAC";
            this.rbtnAC.Size = new System.Drawing.Size(44, 21);
            this.rbtnAC.TabIndex = 20;
            this.rbtnAC.Text = "AC";
            this.rbtnAC.UseVisualStyleBackColor = true;
            this.rbtnAC.CheckedChanged += new System.EventHandler(this.rbtnAC_CheckedChanged);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(406, 409);
            this.Controls.Add(this.gbCategory);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Tables_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox_tables;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioEdit;
        private System.Windows.Forms.RadioButton radioNew;
        private System.Windows.Forms.CheckBox rbtnNonAc;
        private System.Windows.Forms.CheckBox rbtnAC;
    }
}