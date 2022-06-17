namespace BisCarePosEdition
{
    partial class Country
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
            this.Lbl = new System.Windows.Forms.Label();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.Cmb_Nationality = new System.Windows.Forms.ComboBox();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Coutryname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl);
            this.groupBox1.Controls.Add(this.bttn_cancel);
            this.groupBox1.Controls.Add(this.Cmb_Nationality);
            this.groupBox1.Controls.Add(this.bttn_delete);
            this.groupBox1.Controls.Add(this.bttn_save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Coutryname);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(43, 83);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(52, 16);
            this.Lbl.TabIndex = 3;
            this.Lbl.Text = "Country";
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.bttn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(250, 170);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(110, 32);
            this.bttn_cancel.TabIndex = 43;
            this.bttn_cancel.Text = " Close";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            // 
            // Cmb_Nationality
            // 
            this.Cmb_Nationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Nationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Nationality.FormattingEnabled = true;
            this.Cmb_Nationality.Location = new System.Drawing.Point(102, 80);
            this.Cmb_Nationality.Name = "Cmb_Nationality";
            this.Cmb_Nationality.Size = new System.Drawing.Size(247, 24);
            this.Cmb_Nationality.TabIndex = 2;
            this.Cmb_Nationality.SelectedIndexChanged += new System.EventHandler(this.Cmb_Nationality_SelectedIndexChanged);
            // 
            // bttn_delete
            // 
            this.bttn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.bttn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_delete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.bttn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_delete.Location = new System.Drawing.Point(134, 170);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(110, 32);
            this.bttn_delete.TabIndex = 42;
            this.bttn_delete.Text = "  Delete";
            this.bttn_delete.UseVisualStyleBackColor = false;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.bttn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.bttn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_save.Location = new System.Drawing.Point(18, 170);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(110, 32);
            this.bttn_save.TabIndex = 41;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Country Name";
            // 
            // txt_Coutryname
            // 
            this.txt_Coutryname.Location = new System.Drawing.Point(102, 127);
            this.txt_Coutryname.Name = "txt_Coutryname";
            this.txt_Coutryname.Size = new System.Drawing.Size(247, 23);
            this.txt_Coutryname.TabIndex = 37;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rb_edit);
            this.groupBox3.Controls.Add(this.Rb_new);
            this.groupBox3.Location = new System.Drawing.Point(102, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 47);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Location = new System.Drawing.Point(89, 17);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(47, 20);
            this.Rb_edit.TabIndex = 1;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Location = new System.Drawing.Point(12, 17);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(51, 20);
            this.Rb_new.TabIndex = 0;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            // 
            // Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 225);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Country";
            this.Text = "Country";
            this.Load += new System.EventHandler(this.Country_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Button bttn_delete;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Coutryname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.ComboBox Cmb_Nationality;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.RadioButton Rb_new;
    }
}