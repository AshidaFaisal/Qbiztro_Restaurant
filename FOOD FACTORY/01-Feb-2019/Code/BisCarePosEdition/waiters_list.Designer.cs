namespace BisCarePosEdition
{
    partial class waiters_list
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
            this.listBox_waiter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_waiter
            // 
            this.listBox_waiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_waiter.FormattingEnabled = true;
            this.listBox_waiter.ItemHeight = 20;
            this.listBox_waiter.Location = new System.Drawing.Point(0, 0);
            this.listBox_waiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_waiter.Name = "listBox_waiter";
            this.listBox_waiter.Size = new System.Drawing.Size(854, 749);
            this.listBox_waiter.TabIndex = 0;
            this.listBox_waiter.SelectedIndexChanged += new System.EventHandler(this.listBox_waiter_SelectedIndexChanged);
            this.listBox_waiter.DoubleClick += new System.EventHandler(this.listBox_waiter_DoubleClick);
            this.listBox_waiter.Enter += new System.EventHandler(this.listBox_waiter_Enter);
            this.listBox_waiter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_waiter_KeyDown);
            this.listBox_waiter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox_waiter_KeyPress);
            // 
            // waiters_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(854, 749);
            this.Controls.Add(this.listBox_waiter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "waiters_list";
            this.Text = "waiters_list";
            this.Load += new System.EventHandler(this.waiters_list_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_waiter;




    }
}