namespace BisCarePosEdition
{
    partial class Stock_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Report));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.bttn_search = new System.Windows.Forms.Button();
            this.rd_counter = new System.Windows.Forms.RadioButton();
            this.rd_Ingradient = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.bttn_search);
            this.groupBox1.Controls.Add(this.rd_counter);
            this.groupBox1.Controls.Add(this.rd_Ingradient);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(168, 75);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 32);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // bttn_search
            // 
            this.bttn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.bttn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_search.Image = ((System.Drawing.Image)(resources.GetObject("bttn_search.Image")));
            this.bttn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_search.Location = new System.Drawing.Point(24, 75);
            this.bttn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_search.Name = "bttn_search";
            this.bttn_search.Size = new System.Drawing.Size(140, 32);
            this.bttn_search.TabIndex = 8;
            this.bttn_search.Text = "View Report";
            this.bttn_search.UseVisualStyleBackColor = false;
            // 
            // rd_counter
            // 
            this.rd_counter.AutoSize = true;
            this.rd_counter.Location = new System.Drawing.Point(139, 32);
            this.rd_counter.Name = "rd_counter";
            this.rd_counter.Size = new System.Drawing.Size(142, 21);
            this.rd_counter.TabIndex = 1;
            this.rd_counter.Text = "Counter Sale Items";
            this.rd_counter.UseVisualStyleBackColor = true;
            // 
            // rd_Ingradient
            // 
            this.rd_Ingradient.AutoSize = true;
            this.rd_Ingradient.Checked = true;
            this.rd_Ingradient.Location = new System.Drawing.Point(23, 32);
            this.rd_Ingradient.Name = "rd_Ingradient";
            this.rd_Ingradient.Size = new System.Drawing.Size(88, 21);
            this.rd_Ingradient.TabIndex = 0;
            this.rd_Ingradient.TabStop = true;
            this.rd_Ingradient.Text = "Ingredient";
            this.rd_Ingradient.UseVisualStyleBackColor = true;
            // 
            // Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 147);
            this.Controls.Add(this.groupBox1);
            this.Name = "Stock_Report";
            this.Text = "Stock_Report";
            this.Load += new System.EventHandler(this.Stock_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button bttn_search;
        private System.Windows.Forms.RadioButton rd_counter;
        private System.Windows.Forms.RadioButton rd_Ingradient;
    }
}