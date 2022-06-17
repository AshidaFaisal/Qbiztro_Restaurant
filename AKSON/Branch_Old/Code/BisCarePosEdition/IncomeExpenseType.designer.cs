namespace BisCarePosEdition
{
    partial class IncomeExpenseType
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
            this.rbtnIncome = new System.Windows.Forms.RadioButton();
            this.rbtnExpense = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rb_edit = new System.Windows.Forms.RadioButton();
            this.Rb_new = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxTypeName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.bttn_save = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnIncome
            // 
            this.rbtnIncome.AutoSize = true;
            this.rbtnIncome.Checked = true;
            this.rbtnIncome.Location = new System.Drawing.Point(39, 27);
            this.rbtnIncome.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnIncome.Name = "rbtnIncome";
            this.rbtnIncome.Size = new System.Drawing.Size(60, 17);
            this.rbtnIncome.TabIndex = 0;
            this.rbtnIncome.TabStop = true;
            this.rbtnIncome.Text = "Income";
            this.rbtnIncome.UseVisualStyleBackColor = true;
            this.rbtnIncome.CheckedChanged += new System.EventHandler(this.rbtnIncome_CheckedChanged);
            // 
            // rbtnExpense
            // 
            this.rbtnExpense.AutoSize = true;
            this.rbtnExpense.Location = new System.Drawing.Point(148, 27);
            this.rbtnExpense.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnExpense.Name = "rbtnExpense";
            this.rbtnExpense.Size = new System.Drawing.Size(66, 17);
            this.rbtnExpense.TabIndex = 1;
            this.rbtnExpense.Text = "Expense";
            this.rbtnExpense.UseVisualStyleBackColor = true;
            this.rbtnExpense.CheckedChanged += new System.EventHandler(this.rbtnExpense_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 145);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 24);
            this.txtName.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(164, 192);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(222, 57);
            this.txtDescription.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rb_edit);
            this.groupBox3.Controls.Add(this.Rb_new);
            this.groupBox3.Location = new System.Drawing.Point(8, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(217, 70);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // Rb_edit
            // 
            this.Rb_edit.AutoSize = true;
            this.Rb_edit.Location = new System.Drawing.Point(123, 27);
            this.Rb_edit.Margin = new System.Windows.Forms.Padding(4);
            this.Rb_edit.Name = "Rb_edit";
            this.Rb_edit.Size = new System.Drawing.Size(43, 17);
            this.Rb_edit.TabIndex = 1;
            this.Rb_edit.Text = "Edit";
            this.Rb_edit.UseVisualStyleBackColor = true;
            this.Rb_edit.CheckedChanged += new System.EventHandler(this.Rb_edit_CheckedChanged);
            // 
            // Rb_new
            // 
            this.Rb_new.AutoSize = true;
            this.Rb_new.Checked = true;
            this.Rb_new.Location = new System.Drawing.Point(24, 27);
            this.Rb_new.Margin = new System.Windows.Forms.Padding(4);
            this.Rb_new.Name = "Rb_new";
            this.Rb_new.Size = new System.Drawing.Size(47, 17);
            this.Rb_new.TabIndex = 0;
            this.Rb_new.TabStop = true;
            this.Rb_new.Text = "New";
            this.Rb_new.UseVisualStyleBackColor = true;
            this.Rb_new.CheckedChanged += new System.EventHandler(this.Rb_new_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnExpense);
            this.groupBox1.Controls.Add(this.rbtnIncome);
            this.groupBox1.Location = new System.Drawing.Point(232, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(255, 70);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select Type";
            // 
            // cboxTypeName
            // 
            this.cboxTypeName.Enabled = false;
            this.cboxTypeName.FormattingEnabled = true;
            this.cboxTypeName.Location = new System.Drawing.Point(164, 100);
            this.cboxTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.cboxTypeName.Name = "cboxTypeName";
            this.cboxTypeName.Size = new System.Drawing.Size(222, 24);
            this.cboxTypeName.TabIndex = 17;
            this.cboxTypeName.SelectedIndexChanged += new System.EventHandler(this.cboxTypeName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BisCarePosEdition.Properties.Resources.reset;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(116, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_delete
            // 
            this.bttn_delete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_delete.Image = global::BisCarePosEdition.Properties.Resources.delete6;
            this.bttn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_delete.Location = new System.Drawing.Point(256, 268);
            this.bttn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(129, 39);
            this.bttn_delete.TabIndex = 21;
            this.bttn_delete.Text = "  Delete";
            this.bttn_delete.UseVisualStyleBackColor = false;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.button_close_01;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(256, 314);
            this.bttn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(129, 39);
            this.bttn_cancel.TabIndex = 22;
            this.bttn_cancel.Text = " Close";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.bttn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_save.Location = new System.Drawing.Point(116, 268);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(129, 39);
            this.bttn_save.TabIndex = 18;
            this.bttn_save.Text = "Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // IncomeExpenseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttn_delete);
            this.Controls.Add(this.bttn_cancel);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.cboxTypeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IncomeExpenseType";
            this.Text = "Income Expense Type";
            this.Load += new System.EventHandler(this.IncomeExpenseType_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnIncome;
        private System.Windows.Forms.RadioButton rbtnExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Rb_edit;
        private System.Windows.Forms.RadioButton Rb_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxTypeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttn_delete;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Button bttn_save;
    }
}