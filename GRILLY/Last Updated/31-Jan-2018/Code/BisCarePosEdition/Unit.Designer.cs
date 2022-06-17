namespace BisCarePosEdition
{
    partial class Unit
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
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.cmb_unitid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_edit.Location = new System.Drawing.Point(148, 21);
            this.Rb_edit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(50, 21);
            this.Rb_edit.TabIndex = 1;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Delete);
            this.groupBox1.Controls.Add(this.cmb_unitid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_unit);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(382, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(135, 174);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(110, 32);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "   Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            this.Btn_Delete.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.Btn_Delete.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // cmb_unitid
            // 
            this.cmb_unitid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unitid.Enabled = false;
            this.cmb_unitid.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_unitid.FormattingEnabled = true;
            this.cmb_unitid.Location = new System.Drawing.Point(87, 93);
            this.cmb_unitid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_unitid.MaxLength = 3645;
            this.cmb_unitid.Name = "cmb_unitid";
            this.cmb_unitid.Size = new System.Drawing.Size(233, 24);
            this.cmb_unitid.TabIndex = 1;
            this.cmb_unitid.SelectedIndexChanged += new System.EventHandler(this.cmb_unitid_SelectedIndexChanged);
            this.cmb_unitid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_unitid_KeyDown);
            this.cmb_unitid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_unitid_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Select Unit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_edit);
            this.groupBox2.Controls.Add(this.Rb_new);
            this.groupBox2.Location = new System.Drawing.Point(75, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(226, 51);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_new.Location = new System.Drawing.Point(22, 21);
            this.Rb_new.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(52, 21);
            this.Rb_new.TabIndex = 0;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            // 
            // txt_unit
            // 
            this.txt_unit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit.Location = new System.Drawing.Point(87, 131);
            this.txt_unit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_unit.MaxLength = 50;
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(233, 24);
            this.txt_unit.TabIndex = 2;
            this.txt_unit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_unit_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(251, 174);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit ";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(19, 174);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 32);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(399, 225);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Unit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.ComboBox cmb_unitid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
    }
}

