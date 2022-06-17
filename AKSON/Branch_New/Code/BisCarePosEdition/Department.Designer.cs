namespace BisCarePosEdition
{
    partial class Department
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
            this.gpdepartment = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.labelse = new System.Windows.Forms.Label();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.labeldep = new System.Windows.Forms.Label();
            this.gpnewedit = new System.Windows.Forms.GroupBox();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.gpdepartment.SuspendLayout();
            this.gpnewedit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpdepartment
            // 
            this.gpdepartment.Controls.Add(this.label2);
            this.gpdepartment.Controls.Add(this.txt_remarks);
            this.gpdepartment.Controls.Add(this.labelse);
            this.gpdepartment.Controls.Add(this.txt_department);
            this.gpdepartment.Controls.Add(this.cmb_department);
            this.gpdepartment.Controls.Add(this.btn_cancel);
            this.gpdepartment.Controls.Add(this.Btn_Delete);
            this.gpdepartment.Controls.Add(this.btn_save);
            this.gpdepartment.Controls.Add(this.labeldep);
            this.gpdepartment.Controls.Add(this.gpnewedit);
            this.gpdepartment.Location = new System.Drawing.Point(5, 12);
            this.gpdepartment.Name = "gpdepartment";
            this.gpdepartment.Size = new System.Drawing.Size(455, 323);
            this.gpdepartment.TabIndex = 0;
            this.gpdepartment.TabStop = false;
            this.gpdepartment.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Remarks";
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(133, 205);
            this.txt_remarks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_remarks.MaxLength = 50;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(301, 27);
            this.txt_remarks.TabIndex = 19;
            this.txt_remarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_remarks_KeyDown);
            // 
            // labelse
            // 
            this.labelse.AutoSize = true;
            this.labelse.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelse.Location = new System.Drawing.Point(2, 107);
            this.labelse.Name = "labelse";
            this.labelse.Size = new System.Drawing.Size(128, 17);
            this.labelse.TabIndex = 18;
            this.labelse.Text = "Department Search";
            // 
            // txt_department
            // 
            this.txt_department.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Location = new System.Drawing.Point(133, 155);
            this.txt_department.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_department.MaxLength = 50;
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(301, 27);
            this.txt_department.TabIndex = 17;
            this.txt_department.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_department_KeyDown);
            // 
            // cmb_department
            // 
            this.cmb_department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_department.Enabled = false;
            this.cmb_department.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(133, 101);
            this.cmb_department.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(301, 27);
            this.cmb_department.TabIndex = 16;
            this.cmb_department.SelectedIndexChanged += new System.EventHandler(this.cmb_department_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(324, 262);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(197, 262);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(110, 32);
            this.Btn_Delete.TabIndex = 14;
            this.Btn_Delete.Text = "   Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            this.Btn_Delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn_Delete_KeyDown);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(62, 262);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_save_KeyDown);
            this.btn_save.Leave += new System.EventHandler(this.btn_save_Leave);
            // 
            // labeldep
            // 
            this.labeldep.AutoSize = true;
            this.labeldep.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldep.Location = new System.Drawing.Point(2, 161);
            this.labeldep.Name = "labeldep";
            this.labeldep.Size = new System.Drawing.Size(121, 17);
            this.labeldep.TabIndex = 12;
            this.labeldep.Text = "Department Name";
            // 
            // gpnewedit
            // 
            this.gpnewedit.Controls.Add(this.Rb_edit);
            this.gpnewedit.Controls.Add(this.Rb_new);
            this.gpnewedit.Location = new System.Drawing.Point(133, 31);
            this.gpnewedit.Name = "gpnewedit";
            this.gpnewedit.Size = new System.Drawing.Size(197, 36);
            this.gpnewedit.TabIndex = 0;
            this.gpnewedit.TabStop = false;
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_edit.Location = new System.Drawing.Point(99, 12);
            this.Rb_edit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(49, 21);
            this.Rb_edit.TabIndex = 2;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            this.Rb_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rb_edit_KeyDown);
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_new.Location = new System.Drawing.Point(20, 12);
            this.Rb_new.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(52, 21);
            this.Rb_new.TabIndex = 1;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            this.Rb_new.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rb_new_KeyDown);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(465, 347);
            this.Controls.Add(this.gpdepartment);
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.gpdepartment.ResumeLayout(false);
            this.gpdepartment.PerformLayout();
            this.gpnewedit.ResumeLayout(false);
            this.gpnewedit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpdepartment;
        private System.Windows.Forms.GroupBox gpnewedit;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.Label labeldep;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.Label labelse;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Label label2;
    }
}