namespace BisCarePosEdition
{
    partial class CustomerSearch
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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chBetwn = new System.Windows.Forms.RadioButton();
            this.chstart = new System.Windows.Forms.RadioButton();
            this.txt_custname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_text = new System.Windows.Forms.GroupBox();
            this.txt_mob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grp_text.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tinno";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Btn_Close);
            this.groupBox1.Controls.Add(this.dgvCustomer);
            this.groupBox1.Controls.Add(this.grp_text);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(746, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(505, 361);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 32);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = " Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chBetwn);
            this.groupBox3.Controls.Add(this.chstart);
            this.groupBox3.Controls.Add(this.txt_custname);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(299, 89);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By Name";
            // 
            // chBetwn
            // 
            this.chBetwn.AutoSize = true;
            this.chBetwn.Checked = true;
            this.chBetwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBetwn.Location = new System.Drawing.Point(140, 22);
            this.chBetwn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBetwn.Name = "chBetwn";
            this.chBetwn.Size = new System.Drawing.Size(95, 21);
            this.chBetwn.TabIndex = 2;
            this.chBetwn.TabStop = true;
            this.chBetwn.Text = "In Between";
            this.chBetwn.UseVisualStyleBackColor = true;
            this.chBetwn.CheckedChanged += new System.EventHandler(this.chBetwn_CheckedChanged);
            // 
            // chstart
            // 
            this.chstart.AutoSize = true;
            this.chstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chstart.Location = new System.Drawing.Point(18, 22);
            this.chstart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chstart.Name = "chstart";
            this.chstart.Size = new System.Drawing.Size(88, 21);
            this.chstart.TabIndex = 1;
            this.chstart.Text = "Start With";
            this.chstart.UseVisualStyleBackColor = true;
            this.chstart.CheckedChanged += new System.EventHandler(this.chstart_CheckedChanged);
            // 
            // txt_custname
            // 
            this.txt_custname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_custname.Location = new System.Drawing.Point(64, 50);
            this.txt_custname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_custname.Name = "txt_custname";
            this.txt_custname.Size = new System.Drawing.Size(227, 30);
            this.txt_custname.TabIndex = 0;
            this.txt_custname.TextChanged += new System.EventHandler(this.txt_custname_TextChanged);
            this.txt_custname.DoubleClick += new System.EventHandler(this.txt_custname_DoubleClick);
            this.txt_custname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_custname_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Close.Location = new System.Drawing.Point(621, 360);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(110, 32);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvCustomer.Location = new System.Drawing.Point(7, 108);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(724, 243);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCustomer_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SlNo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 220;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 220;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Opening Balance";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CstNo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Id";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // grp_text
            // 
            this.grp_text.Controls.Add(this.txt_mob);
            this.grp_text.Controls.Add(this.label1);
            this.grp_text.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_text.Location = new System.Drawing.Point(312, 11);
            this.grp_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_text.Name = "grp_text";
            this.grp_text.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_text.Size = new System.Drawing.Size(427, 89);
            this.grp_text.TabIndex = 1;
            this.grp_text.TabStop = false;
            this.grp_text.Text = "Search By MobileNo";
            // 
            // txt_mob
            // 
            this.txt_mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mob.Location = new System.Drawing.Point(90, 33);
            this.txt_mob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mob.Name = "txt_mob";
            this.txt_mob.Size = new System.Drawing.Size(305, 30);
            this.txt_mob.TabIndex = 0;
            this.txt_mob.TextChanged += new System.EventHandler(this.txt_mob_TextChanged);
            this.txt_mob.DoubleClick += new System.EventHandler(this.txt_mob_DoubleClick);
            this.txt_mob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mob_KeyDown);
            this.txt_mob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mob_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobile No";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(391, 470);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 32);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "        Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerSearch";
            this.Text = "Customer Search";
            this.Load += new System.EventHandler(this.CustomerSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grp_text.ResumeLayout(false);
            this.grp_text.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton chBetwn;
        private System.Windows.Forms.RadioButton chstart;
        private System.Windows.Forms.TextBox txt_custname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox grp_text;
        private System.Windows.Forms.TextBox txt_mob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
    }
}