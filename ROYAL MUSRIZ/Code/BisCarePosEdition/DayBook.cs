using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BisCarePosEdition
{
    public partial class DayBook : Form
    {
        public DayBook()
        {
            InitializeComponent();
            Codebehind obj = new Codebehind();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        public void ApplyTheme()
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(Theme.FormColor));
            var G = GetAll(this, typeof(GroupBox));
            foreach (GroupBox gb in G)
            {
                gb.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.LblForeColor));
            }
            var b = GetAll(this, typeof(Button));
            foreach (Button cb in b)
            {
                if (Theme.FlatStyle == "Flat")
                {
                    cb.FlatStyle = FlatStyle.Flat;
                }
                if (Theme.FlatStyle == "Standard")
                {
                    cb.FlatStyle = FlatStyle.Standard;
                }
                if (Theme.FlatStyle == "Pop up")
                {
                    cb.FlatStyle = FlatStyle.Popup;
                }
                if (Theme.FlatStyle == "System")
                {
                    cb.FlatStyle = FlatStyle.System;
                }
                cb.BackColor = Color.FromArgb(Convert.ToInt32(Theme.BtnBackColor));
                cb.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.BtnForeColor));
                cb.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.BtnMouseOver));
            }
            var lbl = GetAll(this, typeof(Label));
            foreach (Label labl in lbl)
            {
                labl.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.LblForeColor));
            }
            var gv = GetAll(this, typeof(DataGridView));
            foreach (DataGridView dgv in gv)
            {
                dgv.BackgroundColor = Color.FromArgb(Convert.ToInt32(Theme.DgvBackColor));
            }
        }

        public void DateChanging()
        {
            try
            {
                var MonthFirstDay = new DateTime(Convert.ToInt32(DateTime.Now.Year), Convert.ToInt32(DateTime.Now.Month), 1);
                var LastweekFistDay = DateTime.Now.AddDays(-6);
                if ((dtpStartDate.Value.ToShortDateString() == MonthFirstDay.ToShortDateString()) && (dtpEndDate.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
                {
                    rd_monthly.Checked = true;
                }
                else if ((dtpStartDate.Value.ToShortDateString() == LastweekFistDay.ToShortDateString()) && (dtpEndDate.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
                {
                    rd_weekly.Checked = true;
                }
                else
                {
                    rd_custom.Checked = true;
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int f = 0;
        private void DayBook_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void rd_weekly_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                f = 1;
                dtpStartDate.Value = DateTime.Now.AddDays(-6);
                dtpEndDate.Value = DateTime.Now;
                f = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpStartDate.Value.ToShortDateString()) <= Convert.ToDateTime(dtpEndDate.Value.ToShortDateString()))
            {
                FrmReportDayBook objr = new FrmReportDayBook(dtpStartDate.Value, dtpEndDate.Value);
                objr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please check the Start Date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpStartDate.Focus();
            }
        }

        private void rd_monthly_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                f = 1;
                dtpEndDate.Value = DateTime.Now;
                dtpStartDate.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
                f = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
