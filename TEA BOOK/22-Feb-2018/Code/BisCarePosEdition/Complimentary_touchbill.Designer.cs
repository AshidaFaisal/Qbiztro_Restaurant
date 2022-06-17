namespace BisCarePosEdition
{
    partial class Complimentary_touchbill
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cmb_staff = new System.Windows.Forms.ComboBox();
            this.txt_others = new System.Windows.Forms.TextBox();
            this.rd_staff = new System.Windows.Forms.RadioButton();
            this.rd_others = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_ok);
            this.groupBox1.Controls.Add(this.cmb_staff);
            this.groupBox1.Controls.Add(this.txt_others);
            this.groupBox1.Controls.Add(this.rd_staff);
            this.groupBox1.Controls.Add(this.rd_others);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(439, 226);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(141, 55);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.Location = new System.Drawing.Point(229, 226);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(125, 55);
            this.btn_ok.TabIndex = 15;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cmb_staff
            // 
            this.cmb_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(439, 118);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(303, 33);
            this.cmb_staff.TabIndex = 14;
            this.cmb_staff.SelectedIndexChanged += new System.EventHandler(this.cmb_staff_SelectedIndexChanged);
            // 
            // txt_others
            // 
            this.txt_others.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_others.Location = new System.Drawing.Point(27, 121);
            this.txt_others.Name = "txt_others";
            this.txt_others.Size = new System.Drawing.Size(361, 32);
            this.txt_others.TabIndex = 13;
            this.txt_others.TextChanged += new System.EventHandler(this.txt_others_TextChanged);
            // 
            // rd_staff
            // 
            this.rd_staff.AutoSize = true;
            this.rd_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_staff.Location = new System.Drawing.Point(439, 50);
            this.rd_staff.Name = "rd_staff";
            this.rd_staff.Size = new System.Drawing.Size(80, 30);
            this.rd_staff.TabIndex = 1;
            this.rd_staff.Text = "Staff";
            this.rd_staff.UseVisualStyleBackColor = true;
            this.rd_staff.CheckedChanged += new System.EventHandler(this.rd_staff_CheckedChanged);
            // 
            // rd_others
            // 
            this.rd_others.AutoSize = true;
            this.rd_others.Checked = true;
            this.rd_others.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_others.Location = new System.Drawing.Point(27, 50);
            this.rd_others.Name = "rd_others";
            this.rd_others.Size = new System.Drawing.Size(101, 30);
            this.rd_others.TabIndex = 12;
            this.rd_others.TabStop = true;
            this.rd_others.Text = "Others";
            this.rd_others.UseVisualStyleBackColor = true;
            this.rd_others.CheckedChanged += new System.EventHandler(this.rd_others_CheckedChanged);
            // 
            // Complimentary_touchbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 353);
            this.Controls.Add(this.groupBox1);
            this.Name = "Complimentary_touchbill";
            this.Text = "Complimentary Remarks";
            this.Load += new System.EventHandler(this.Complimentary_touchbill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_staff;
        private System.Windows.Forms.RadioButton rd_others;
        private System.Windows.Forms.ComboBox cmb_staff;
        private System.Windows.Forms.TextBox txt_others;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ok;
    }
}