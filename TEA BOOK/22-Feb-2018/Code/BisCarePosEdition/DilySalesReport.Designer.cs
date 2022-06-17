namespace BisCarePosEdition
{
    partial class DilySalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DilySalesReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_viewreport = new System.Windows.Forms.Button();
            this.grp_BillType = new System.Windows.Forms.GroupBox();
            this.rd_all = new System.Windows.Forms.RadioButton();
            this.rd_counterBill = new System.Windows.Forms.RadioButton();
            this.rd_takeaway = new System.Windows.Forms.RadioButton();
            this.rd_Dinein = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grp_BillType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_viewreport);
            this.groupBox1.Controls.Add(this.grp_BillType);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 32);
            this.button1.TabIndex = 50;
            this.button1.Text = "Print Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::BisCarePosEdition.Properties.Resources.close_bttn;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(310, 84);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 49;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_viewreport_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_viewreport_MouseLeave);
            // 
            // btn_viewreport
            // 
            this.btn_viewreport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_viewreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport.Image = global::BisCarePosEdition.Properties.Resources.Reportnew;
            this.btn_viewreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewreport.Location = new System.Drawing.Point(176, 84);
            this.btn_viewreport.Name = "btn_viewreport";
            this.btn_viewreport.Size = new System.Drawing.Size(128, 32);
            this.btn_viewreport.TabIndex = 48;
            this.btn_viewreport.Text = "View Report";
            this.btn_viewreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewreport.UseVisualStyleBackColor = false;
            this.btn_viewreport.Click += new System.EventHandler(this.btn_viewreport_Click);
            this.btn_viewreport.MouseEnter += new System.EventHandler(this.btn_viewreport_MouseEnter);
            this.btn_viewreport.MouseLeave += new System.EventHandler(this.btn_viewreport_MouseLeave);
            // 
            // grp_BillType
            // 
            this.grp_BillType.Controls.Add(this.rd_all);
            this.grp_BillType.Controls.Add(this.rd_counterBill);
            this.grp_BillType.Controls.Add(this.rd_takeaway);
            this.grp_BillType.Controls.Add(this.rd_Dinein);
            this.grp_BillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_BillType.Location = new System.Drawing.Point(14, 8);
            this.grp_BillType.Name = "grp_BillType";
            this.grp_BillType.Size = new System.Drawing.Size(406, 65);
            this.grp_BillType.TabIndex = 47;
            this.grp_BillType.TabStop = false;
            this.grp_BillType.Text = "Bill Type";
            // 
            // rd_all
            // 
            this.rd_all.AutoSize = true;
            this.rd_all.Checked = true;
            this.rd_all.Location = new System.Drawing.Point(12, 26);
            this.rd_all.Name = "rd_all";
            this.rd_all.Size = new System.Drawing.Size(41, 21);
            this.rd_all.TabIndex = 51;
            this.rd_all.TabStop = true;
            this.rd_all.Text = "All";
            this.rd_all.UseVisualStyleBackColor = true;
            this.rd_all.CheckedChanged += new System.EventHandler(this.rd_all_CheckedChanged);
            // 
            // rd_counterBill
            // 
            this.rd_counterBill.AutoSize = true;
            this.rd_counterBill.Location = new System.Drawing.Point(296, 26);
            this.rd_counterBill.Name = "rd_counterBill";
            this.rd_counterBill.Size = new System.Drawing.Size(98, 21);
            this.rd_counterBill.TabIndex = 50;
            this.rd_counterBill.Text = "Counter Bill";
            this.rd_counterBill.UseVisualStyleBackColor = true;
            // 
            // rd_takeaway
            // 
            this.rd_takeaway.AutoSize = true;
            this.rd_takeaway.Location = new System.Drawing.Point(176, 26);
            this.rd_takeaway.Name = "rd_takeaway";
            this.rd_takeaway.Size = new System.Drawing.Size(95, 21);
            this.rd_takeaway.TabIndex = 49;
            this.rd_takeaway.Text = "Take Away";
            this.rd_takeaway.UseVisualStyleBackColor = true;
            // 
            // rd_Dinein
            // 
            this.rd_Dinein.AutoSize = true;
            this.rd_Dinein.Location = new System.Drawing.Point(72, 26);
            this.rd_Dinein.Name = "rd_Dinein";
            this.rd_Dinein.Size = new System.Drawing.Size(70, 21);
            this.rd_Dinein.TabIndex = 48;
            this.rd_Dinein.Text = "Dine In";
            this.rd_Dinein.UseVisualStyleBackColor = true;
            this.rd_Dinein.CheckedChanged += new System.EventHandler(this.rd_Dinein_CheckedChanged);
            // 
            // DilySalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(438, 139);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DilySalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Sales Report";
            this.Load += new System.EventHandler(this.DilySalesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.grp_BillType.ResumeLayout(false);
            this.grp_BillType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_BillType;
        private System.Windows.Forms.RadioButton rd_counterBill;
        private System.Windows.Forms.RadioButton rd_takeaway;
        private System.Windows.Forms.RadioButton rd_Dinein;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_viewreport;
        private System.Windows.Forms.RadioButton rd_all;
        private System.Windows.Forms.Button button1;
    }
}