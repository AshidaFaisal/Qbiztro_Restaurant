namespace BisCarePosEdition
{
    partial class EmployeSearch
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.ch_mobile = new System.Windows.Forms.CheckBox();
            this.ch_Nationality = new System.Windows.Forms.CheckBox();
            this.ch_designation = new System.Windows.Forms.CheckBox();
            this.ch_Emp = new System.Windows.Forms.CheckBox();
            this.cbox_mob = new System.Windows.Forms.ComboBox();
            this.cbox_Nationality = new System.Windows.Forms.ComboBox();
            this.cbox_designation = new System.Windows.Forms.ComboBox();
            this.gv_EmpSearch = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_emp = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_EmpSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btn_Search.Image = global::WindowsFormsApplication10.Properties.Resources.search4;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(733, 6);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 32);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "     Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // ch_mobile
            // 
            this.ch_mobile.AutoSize = true;
            this.ch_mobile.Location = new System.Drawing.Point(568, 13);
            this.ch_mobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_mobile.Name = "ch_mobile";
            this.ch_mobile.Size = new System.Drawing.Size(132, 21);
            this.ch_mobile.TabIndex = 6;
            this.ch_mobile.Text = "Include MobileNo";
            this.ch_mobile.UseVisualStyleBackColor = true;
            this.ch_mobile.CheckedChanged += new System.EventHandler(this.ch_mobile_CheckedChanged);
            // 
            // ch_Nationality
            // 
            this.ch_Nationality.AutoSize = true;
            this.ch_Nationality.Location = new System.Drawing.Point(376, 13);
            this.ch_Nationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_Nationality.Name = "ch_Nationality";
            this.ch_Nationality.Size = new System.Drawing.Size(141, 21);
            this.ch_Nationality.TabIndex = 4;
            this.ch_Nationality.Text = "Include Nationality";
            this.ch_Nationality.UseVisualStyleBackColor = true;
            this.ch_Nationality.CheckedChanged += new System.EventHandler(this.ch_Nationality_CheckedChanged);
            // 
            // ch_designation
            // 
            this.ch_designation.AutoSize = true;
            this.ch_designation.Location = new System.Drawing.Point(185, 13);
            this.ch_designation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_designation.Name = "ch_designation";
            this.ch_designation.Size = new System.Drawing.Size(149, 21);
            this.ch_designation.TabIndex = 2;
            this.ch_designation.Text = "Include Designation";
            this.ch_designation.UseVisualStyleBackColor = true;
            this.ch_designation.CheckedChanged += new System.EventHandler(this.ch_designation_CheckedChanged);
            // 
            // ch_Emp
            // 
            this.ch_Emp.AutoSize = true;
            this.ch_Emp.Location = new System.Drawing.Point(13, 13);
            this.ch_Emp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_Emp.Name = "ch_Emp";
            this.ch_Emp.Size = new System.Drawing.Size(136, 21);
            this.ch_Emp.TabIndex = 0;
            this.ch_Emp.Text = "Include Employee";
            this.ch_Emp.UseVisualStyleBackColor = true;
            this.ch_Emp.CheckedChanged += new System.EventHandler(this.ch_Emp_CheckedChanged);
            // 
            // cbox_mob
            // 
            this.cbox_mob.FormattingEnabled = true;
            this.cbox_mob.Location = new System.Drawing.Point(568, 42);
            this.cbox_mob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_mob.Name = "cbox_mob";
            this.cbox_mob.Size = new System.Drawing.Size(140, 24);
            this.cbox_mob.TabIndex = 7;
            this.cbox_mob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_mob_KeyPress);
            this.cbox_mob.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbox_mob_MouseClick);
            // 
            // cbox_Nationality
            // 
            this.cbox_Nationality.FormattingEnabled = true;
            this.cbox_Nationality.Location = new System.Drawing.Point(376, 42);
            this.cbox_Nationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_Nationality.Name = "cbox_Nationality";
            this.cbox_Nationality.Size = new System.Drawing.Size(140, 24);
            this.cbox_Nationality.TabIndex = 5;
            this.cbox_Nationality.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbox_Nationality_MouseClick);
            // 
            // cbox_designation
            // 
            this.cbox_designation.FormattingEnabled = true;
            this.cbox_designation.Location = new System.Drawing.Point(185, 42);
            this.cbox_designation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_designation.Name = "cbox_designation";
            this.cbox_designation.Size = new System.Drawing.Size(140, 24);
            this.cbox_designation.TabIndex = 3;
            this.cbox_designation.SelectedIndexChanged += new System.EventHandler(this.cbox_designation_SelectedIndexChanged);
            this.cbox_designation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbox_designation_MouseClick);
            // 
            // gv_EmpSearch
            // 
            this.gv_EmpSearch.AllowUserToAddRows = false;
            this.gv_EmpSearch.AllowUserToDeleteRows = false;
            this.gv_EmpSearch.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gv_EmpSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_EmpSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column11,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.gv_EmpSearch.Location = new System.Drawing.Point(13, 87);
            this.gv_EmpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gv_EmpSearch.Name = "gv_EmpSearch";
            this.gv_EmpSearch.ReadOnly = true;
            this.gv_EmpSearch.RowHeadersWidth = 15;
            this.gv_EmpSearch.Size = new System.Drawing.Size(879, 252);
            this.gv_EmpSearch.TabIndex = 10;
            this.gv_EmpSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_EmpSearch_CellContentClick);
            this.gv_EmpSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_EmpSearch_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "SlNo";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Emp Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date Of Birth";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Designation";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date Of Joinig";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Working Hours";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mobile No";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Country";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Gender";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // txt_emp
            // 
            this.txt_emp.Location = new System.Drawing.Point(13, 42);
            this.txt_emp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_emp.Name = "txt_emp";
            this.txt_emp.Size = new System.Drawing.Size(139, 24);
            this.txt_emp.TabIndex = 1;
            this.txt_emp.DoubleClick += new System.EventHandler(this.txt_emp_DoubleClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btn_cancel.Image = global::WindowsFormsApplication10.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(733, 46);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "    Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // EmployeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 345);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_emp);
            this.Controls.Add(this.gv_EmpSearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.ch_mobile);
            this.Controls.Add(this.ch_Nationality);
            this.Controls.Add(this.ch_designation);
            this.Controls.Add(this.ch_Emp);
            this.Controls.Add(this.cbox_mob);
            this.Controls.Add(this.cbox_Nationality);
            this.Controls.Add(this.cbox_designation);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Search";
            this.Load += new System.EventHandler(this.EmployeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_EmpSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.CheckBox ch_mobile;
        private System.Windows.Forms.CheckBox ch_Nationality;
        private System.Windows.Forms.CheckBox ch_designation;
        private System.Windows.Forms.CheckBox ch_Emp;
        private System.Windows.Forms.ComboBox cbox_mob;
        private System.Windows.Forms.ComboBox cbox_Nationality;
        private System.Windows.Forms.ComboBox cbox_designation;
        private System.Windows.Forms.DataGridView gv_EmpSearch;
        private System.Windows.Forms.TextBox txt_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btn_cancel;
    }
}