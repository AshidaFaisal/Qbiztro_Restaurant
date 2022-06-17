namespace BisCarePosEdition
{
    partial class SwipingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwipingMachine));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.cmb_bank = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_new = new System.Windows.Forms.RadioButton();
            this.rb_edit = new System.Windows.Forms.RadioButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_branch = new System.Windows.Forms.Label();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.btn_Newbank = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Newbank);
            this.groupBox1.Controls.Add(this.bttn_reset);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_accno);
            this.groupBox1.Controls.Add(this.cmb_bank);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_name);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_address);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_branch);
            this.groupBox1.Controls.Add(this.txt_branch);
            this.groupBox1.Controls.Add(this.txt_Remarks);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(729, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Swiping Machine Details";
            // 
            // bttn_reset
            // 
            this.bttn_reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.bttn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_reset.Image = global::BisCarePosEdition.Properties.Resources.reset;
            this.bttn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_reset.Location = new System.Drawing.Point(404, 284);
            this.bttn_reset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(128, 39);
            this.bttn_reset.TabIndex = 10;
            this.bttn_reset.Text = "Reset";
            this.bttn_reset.UseVisualStyleBackColor = false;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "A/C No";
            // 
            // txt_accno
            // 
            this.txt_accno.Location = new System.Drawing.Point(90, 230);
            this.txt_accno.Margin = new System.Windows.Forms.Padding(5);
            this.txt_accno.MaxLength = 16;
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.ReadOnly = true;
            this.txt_accno.Size = new System.Drawing.Size(261, 24);
            this.txt_accno.TabIndex = 67;
            // 
            // cmb_bank
            // 
            this.cmb_bank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_bank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bank.DropDownWidth = 500;
            this.cmb_bank.FormattingEnabled = true;
            this.cmb_bank.Location = new System.Drawing.Point(90, 176);
            this.cmb_bank.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_bank.Name = "cmb_bank";
            this.cmb_bank.Size = new System.Drawing.Size(261, 24);
            this.cmb_bank.TabIndex = 6;
            this.cmb_bank.SelectedIndexChanged += new System.EventHandler(this.cmb_bank_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(268, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "   Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_name
            // 
            this.cmb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(442, 57);
            this.cmb_name.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(261, 24);
            this.cmb_name.TabIndex = 4;
            this.cmb_name.SelectedIndexChanged += new System.EventHandler(this.cmb_name_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(539, 284);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(128, 39);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "   Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(131, 284);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 39);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = " Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(90, 126);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(261, 24);
            this.txt_name.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_new);
            this.groupBox2.Controls.Add(this.rb_edit);
            this.groupBox2.Location = new System.Drawing.Point(16, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(278, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rb_new
            // 
            this.rb_new.AutoSize = true;
            this.rb_new.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_new.Location = new System.Drawing.Point(20, 30);
            this.rb_new.Margin = new System.Windows.Forms.Padding(5);
            this.rb_new.Name = "rb_new";
            this.rb_new.Size = new System.Drawing.Size(52, 21);
            this.rb_new.TabIndex = 2;
            this.rb_new.TabStop = true;
            this.rb_new.Text = "New";
            this.rb_new.UseVisualStyleBackColor = true;
            this.rb_new.CheckedChanged += new System.EventHandler(this.rb_new_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_edit.Location = new System.Drawing.Point(168, 30);
            this.rb_edit.Margin = new System.Windows.Forms.Padding(5);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(49, 21);
            this.rb_edit.TabIndex = 3;
            this.rb_edit.TabStop = true;
            this.rb_edit.Text = "Edit";
            this.rb_edit.UseVisualStyleBackColor = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_edit_CheckedChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 130);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 17);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(14, 179);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(38, 17);
            this.lbl_address.TabIndex = 17;
            this.lbl_address.Text = "Bank";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(364, 131);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(61, 17);
            this.lbl_email.TabIndex = 19;
            this.lbl_email.Text = "Remarks";
            // 
            // lbl_branch
            // 
            this.lbl_branch.AutoSize = true;
            this.lbl_branch.Location = new System.Drawing.Point(365, 235);
            this.lbl_branch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_branch.Name = "lbl_branch";
            this.lbl_branch.Size = new System.Drawing.Size(51, 17);
            this.lbl_branch.TabIndex = 20;
            this.lbl_branch.Text = "Branch";
            // 
            // txt_branch
            // 
            this.txt_branch.Location = new System.Drawing.Point(442, 230);
            this.txt_branch.Margin = new System.Windows.Forms.Padding(5);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.ReadOnly = true;
            this.txt_branch.Size = new System.Drawing.Size(261, 24);
            this.txt_branch.TabIndex = 77;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Location = new System.Drawing.Point(442, 126);
            this.txt_Remarks.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(261, 24);
            this.txt_Remarks.TabIndex = 7;
            // 
            // btn_Newbank
            // 
            this.btn_Newbank.BackColor = System.Drawing.Color.Transparent;
            this.btn_Newbank.FlatAppearance.BorderSize = 0;
            this.btn_Newbank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Newbank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Newbank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Newbank.Image = ((System.Drawing.Image)(resources.GetObject("btn_Newbank.Image")));
            this.btn_Newbank.Location = new System.Drawing.Point(359, 176);
            this.btn_Newbank.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Newbank.Name = "btn_Newbank";
            this.btn_Newbank.Size = new System.Drawing.Size(25, 25);
            this.btn_Newbank.TabIndex = 78;
            this.btn_Newbank.UseVisualStyleBackColor = false;
            this.btn_Newbank.Click += new System.EventHandler(this.btn_Newbank_Click);
            // 
            // SwipingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 378);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SwipingMachine";
            this.Text = "Swiping Machine";
            this.Load += new System.EventHandler(this.SwipingMachine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_bank;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_new;
        private System.Windows.Forms.RadioButton rb_edit;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_branch;
        private System.Windows.Forms.TextBox txt_branch;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_accno;
        private System.Windows.Forms.Button bttn_reset;
        private System.Windows.Forms.Button btn_Newbank;
    }
}