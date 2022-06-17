namespace BisCarePosEdition
{
    partial class Settings
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
            this.bttn_save = new System.Windows.Forms.Button();
            this.grp_Inv = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rd_autoInv = new System.Windows.Forms.RadioButton();
            this.rd_manualInv = new System.Windows.Forms.RadioButton();
            this.txt_inPr = new System.Windows.Forms.TextBox();
            this.lbl_prIN = new System.Windows.Forms.Label();
            this.lbl_stCust = new System.Windows.Forms.Label();
            this.txt_Inst = new System.Windows.Forms.TextBox();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_Inv.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttn_save);
            this.groupBox1.Controls.Add(this.grp_Inv);
            this.groupBox1.Location = new System.Drawing.Point(3, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 176);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Image = global::BisCarePosEdition.Properties.Resources.save1;
            this.bttn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_save.Location = new System.Drawing.Point(168, 134);
            this.bttn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(110, 32);
            this.bttn_save.TabIndex = 27;
            this.bttn_save.Text = "   Save";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            this.bttn_save.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_save.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // grp_Inv
            // 
            this.grp_Inv.Controls.Add(this.label16);
            this.grp_Inv.Controls.Add(this.rd_autoInv);
            this.grp_Inv.Controls.Add(this.rd_manualInv);
            this.grp_Inv.Controls.Add(this.txt_inPr);
            this.grp_Inv.Controls.Add(this.lbl_prIN);
            this.grp_Inv.Controls.Add(this.lbl_stCust);
            this.grp_Inv.Controls.Add(this.txt_Inst);
            this.grp_Inv.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Inv.Location = new System.Drawing.Point(6, 8);
            this.grp_Inv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_Inv.Name = "grp_Inv";
            this.grp_Inv.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_Inv.Size = new System.Drawing.Size(443, 115);
            this.grp_Inv.TabIndex = 26;
            this.grp_Inv.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Invoice No";
            // 
            // rd_autoInv
            // 
            this.rd_autoInv.AutoSize = true;
            this.rd_autoInv.Location = new System.Drawing.Point(136, 40);
            this.rd_autoInv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_autoInv.Name = "rd_autoInv";
            this.rd_autoInv.Size = new System.Drawing.Size(88, 21);
            this.rd_autoInv.TabIndex = 0;
            this.rd_autoInv.Text = "Automatic";
            this.rd_autoInv.UseVisualStyleBackColor = true;
            this.rd_autoInv.CheckedChanged += new System.EventHandler(this.rd_autoInv_CheckedChanged);
            // 
            // rd_manualInv
            // 
            this.rd_manualInv.AutoSize = true;
            this.rd_manualInv.Checked = true;
            this.rd_manualInv.Location = new System.Drawing.Point(50, 40);
            this.rd_manualInv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_manualInv.Name = "rd_manualInv";
            this.rd_manualInv.Size = new System.Drawing.Size(69, 21);
            this.rd_manualInv.TabIndex = 1;
            this.rd_manualInv.TabStop = true;
            this.rd_manualInv.Text = "Manual";
            this.rd_manualInv.UseVisualStyleBackColor = true;
            this.rd_manualInv.CheckedChanged += new System.EventHandler(this.rd_manualInv_CheckedChanged);
            this.rd_manualInv.Enter += new System.EventHandler(this.rd_manualInv_Enter);
            // 
            // txt_inPr
            // 
            this.txt_inPr.Enabled = false;
            this.txt_inPr.Location = new System.Drawing.Point(50, 74);
            this.txt_inPr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_inPr.Name = "txt_inPr";
            this.txt_inPr.Size = new System.Drawing.Size(146, 24);
            this.txt_inPr.TabIndex = 2;
            this.txt_inPr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_inPr_KeyDown);
            // 
            // lbl_prIN
            // 
            this.lbl_prIN.AutoSize = true;
            this.lbl_prIN.Enabled = false;
            this.lbl_prIN.Location = new System.Drawing.Point(7, 79);
            this.lbl_prIN.Name = "lbl_prIN";
            this.lbl_prIN.Size = new System.Drawing.Size(42, 17);
            this.lbl_prIN.TabIndex = 14;
            this.lbl_prIN.Text = "Prefix";
            // 
            // lbl_stCust
            // 
            this.lbl_stCust.AutoSize = true;
            this.lbl_stCust.Enabled = false;
            this.lbl_stCust.Location = new System.Drawing.Point(202, 78);
            this.lbl_stCust.Name = "lbl_stCust";
            this.lbl_stCust.Size = new System.Drawing.Size(78, 17);
            this.lbl_stCust.TabIndex = 15;
            this.lbl_stCust.Text = "Starting No";
            // 
            // txt_Inst
            // 
            this.txt_Inst.Enabled = false;
            this.txt_Inst.Location = new System.Drawing.Point(283, 74);
            this.txt_Inst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Inst.MaxLength = 10;
            this.txt_Inst.Name = "txt_Inst";
            this.txt_Inst.Size = new System.Drawing.Size(147, 24);
            this.txt_Inst.TabIndex = 3;
            this.txt_Inst.Text = "0";
            this.txt_Inst.TextChanged += new System.EventHandler(this.txt_Inst_TextChanged);
            this.txt_Inst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Inst_KeyDown);
            this.txt_Inst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Inst_KeyPress);
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.bttn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_cancel.Location = new System.Drawing.Point(145, 253);
            this.bttn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(110, 32);
            this.bttn_cancel.TabIndex = 28;
            this.bttn_cancel.Text = "    Close";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Visible = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            this.bttn_cancel.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_save_Paint);
            this.bttn_cancel.MouseEnter += new System.EventHandler(this.bttn_save_MouseEnter);
            this.bttn_cancel.MouseLeave += new System.EventHandler(this.bttn_save_MouseLeave);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(461, 177);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.grp_Inv.ResumeLayout(false);
            this.grp_Inv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.GroupBox grp_Inv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rd_autoInv;
        private System.Windows.Forms.RadioButton rd_manualInv;
        private System.Windows.Forms.TextBox txt_inPr;
        private System.Windows.Forms.Label lbl_prIN;
        private System.Windows.Forms.Label lbl_stCust;
        private System.Windows.Forms.TextBox txt_Inst;
    }
}