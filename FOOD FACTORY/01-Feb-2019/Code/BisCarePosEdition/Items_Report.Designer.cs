namespace BisCarePosEdition
{
    partial class Items_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items_Report));
            this.btn_viewreport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewreport
            // 
            this.btn_viewreport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_viewreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewreport.Image")));
            this.btn_viewreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewreport.Location = new System.Drawing.Point(59, 60);
            this.btn_viewreport.Name = "btn_viewreport";
            this.btn_viewreport.Size = new System.Drawing.Size(132, 32);
            this.btn_viewreport.TabIndex = 3;
            this.btn_viewreport.Text = "     View Report";
            this.btn_viewreport.UseVisualStyleBackColor = false;
            this.btn_viewreport.Click += new System.EventHandler(this.btn_viewreport_Click);
            // 
            // Items_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 154);
            this.Controls.Add(this.btn_viewreport);
            this.Name = "Items_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items_Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewreport;
    }
}