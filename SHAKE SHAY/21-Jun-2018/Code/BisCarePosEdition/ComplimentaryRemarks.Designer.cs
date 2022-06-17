namespace BisCarePosEdition
{
    partial class ComplimentaryRemarks
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_staff = new System.Windows.Forms.ComboBox();
            this.rd_Others = new System.Windows.Forms.RadioButton();
            this.rd_staff = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_staff);
            this.groupBox2.Controls.Add(this.rd_Others);
            this.groupBox2.Controls.Add(this.rd_staff);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.txt_remarks);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 142);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // cmb_staff
            // 
            this.cmb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_staff.Enabled = false;
            this.cmb_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(464, 54);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(219, 28);
            this.cmb_staff.TabIndex = 13;
            this.cmb_staff.SelectedIndexChanged += new System.EventHandler(this.cmb_staff_SelectedIndexChanged);
            // 
            // rd_Others
            // 
            this.rd_Others.AutoSize = true;
            this.rd_Others.Checked = true;
            this.rd_Others.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Others.Location = new System.Drawing.Point(26, 19);
            this.rd_Others.Name = "rd_Others";
            this.rd_Others.Size = new System.Drawing.Size(81, 24);
            this.rd_Others.TabIndex = 12;
            this.rd_Others.TabStop = true;
            this.rd_Others.Text = "Others";
            this.rd_Others.UseVisualStyleBackColor = true;
            this.rd_Others.CheckedChanged += new System.EventHandler(this.rd_Others_CheckedChanged);
            // 
            // rd_staff
            // 
            this.rd_staff.AutoSize = true;
            this.rd_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_staff.Location = new System.Drawing.Point(464, 19);
            this.rd_staff.Name = "rd_staff";
            this.rd_staff.Size = new System.Drawing.Size(67, 24);
            this.rd_staff.TabIndex = 11;
            this.rd_staff.Text = "Staff";
            this.rd_staff.UseVisualStyleBackColor = true;
            this.rd_staff.CheckedChanged += new System.EventHandler(this.rd_staff_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(348, 98);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(26, 54);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(417, 28);
            this.txt_remarks.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(215, 98);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "ok";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ComplimentaryRemarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 183);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComplimentaryRemarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complimentary Remarks";
            this.Load += new System.EventHandler(this.ComplimentaryRemarks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_Others;
        private System.Windows.Forms.RadioButton rd_staff;
        private System.Windows.Forms.ComboBox cmb_staff;
    }
}