namespace BisCarePosEdition
{
    partial class waiter
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
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.radioediit = new System.Windows.Forms.RadioButton();
            this.radionew = new System.Windows.Forms.RadioButton();
            this.txt_wcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.listbox_waiter = new System.Windows.Forms.ListBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(114, 142);
            this.txt_remarks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_remarks.MaxLength = 500;
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(305, 50);
            this.txt_remarks.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(302, 202);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(117, 32);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.radioediit);
            this.gbCategory.Controls.Add(this.radionew);
            this.gbCategory.Controls.Add(this.txt_wcode);
            this.gbCategory.Controls.Add(this.label3);
            this.gbCategory.Controls.Add(this.btn_delete);
            this.gbCategory.Controls.Add(this.listbox_waiter);
            this.gbCategory.Controls.Add(this.txt_remarks);
            this.gbCategory.Controls.Add(this.btn_cancel);
            this.gbCategory.Controls.Add(this.btn_save);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Controls.Add(this.txt_name);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Location = new System.Drawing.Point(10, 1);
            this.gbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCategory.Size = new System.Drawing.Size(424, 399);
            this.gbCategory.TabIndex = 0;
            this.gbCategory.TabStop = false;
            // 
            // radioediit
            // 
            this.radioediit.AutoSize = true;
            this.radioediit.Enabled = false;
            this.radioediit.Location = new System.Drawing.Point(236, 27);
            this.radioediit.Name = "radioediit";
            this.radioediit.Size = new System.Drawing.Size(49, 21);
            this.radioediit.TabIndex = 18;
            this.radioediit.Text = "Edit";
            this.radioediit.UseVisualStyleBackColor = true;
            this.radioediit.Visible = false;
            this.radioediit.CheckedChanged += new System.EventHandler(this.radioediit_CheckedChanged);
            // 
            // radionew
            // 
            this.radionew.AutoSize = true;
            this.radionew.Checked = true;
            this.radionew.Location = new System.Drawing.Point(114, 27);
            this.radionew.Name = "radionew";
            this.radionew.Size = new System.Drawing.Size(52, 21);
            this.radionew.TabIndex = 17;
            this.radionew.TabStop = true;
            this.radionew.Text = "New";
            this.radionew.UseVisualStyleBackColor = true;
            this.radionew.Visible = false;
            this.radionew.CheckedChanged += new System.EventHandler(this.radionew_CheckedChanged);
            // 
            // txt_wcode
            // 
            this.txt_wcode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wcode.Location = new System.Drawing.Point(114, 56);
            this.txt_wcode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_wcode.MaxLength = 50;
            this.txt_wcode.Name = "txt_wcode";
            this.txt_wcode.Size = new System.Drawing.Size(305, 24);
            this.txt_wcode.TabIndex = 16;
            this.txt_wcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_wcode_KeyDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Waiter Code";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(178, 202);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 32);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listbox_waiter
            // 
            this.listbox_waiter.FormattingEnabled = true;
            this.listbox_waiter.ItemHeight = 16;
            this.listbox_waiter.Location = new System.Drawing.Point(10, 243);
            this.listbox_waiter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbox_waiter.Name = "listbox_waiter";
            this.listbox_waiter.Size = new System.Drawing.Size(409, 148);
            this.listbox_waiter.TabIndex = 5;
            this.listbox_waiter.SelectedIndexChanged += new System.EventHandler(this.listbox_waiter_SelectedIndexChanged);
            this.listbox_waiter.DoubleClick += new System.EventHandler(this.listbox_waiter_DoubleClick);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(55, 202);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 32);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Remarks";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(114, 99);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(305, 24);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waiter Name";
            // 
            // waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(441, 411);
            this.Controls.Add(this.gbCategory);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiter";
            this.Load += new System.EventHandler(this.waiter_Load_2);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox listbox_waiter;
        private System.Windows.Forms.TextBox txt_wcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioediit;
        private System.Windows.Forms.RadioButton radionew;
    }
}