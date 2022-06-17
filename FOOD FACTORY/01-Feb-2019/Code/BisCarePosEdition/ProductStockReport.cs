using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.IO;

namespace BisCarePosEdition
{
    public partial class ProductStockReport : Form
    {
        public ProductStockReport()
        {
            InitializeComponent();
            cmb_Cat.Enabled = false;
            cmb_item.Enabled = false;
            
            rd_custom.Checked = true;
        }
        Codebehind obj = new Codebehind();
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
        private void SalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                
                ApplyTheme();
                DataSet ds4 = new DataSet();
                ds4 = obj.GetCategory(1);
                cmb_Cat.DataSource = ds4.Tables[0];
                cmb_Cat.DisplayMember = "Name";
                cmb_Cat.ValueMember = "Id";
                DataRow dr4 = ds4.Tables[0].NewRow();
                dr4["Name"] = "--Select One--";
                dr4["Id"] = "0";
                ds4.Tables[0].Rows.InsertAt(dr4, 0);
                cmb_Cat.SelectedIndex = 0;


                DataSet ds5 = new DataSet();
                ds5 = obj.GetItemCodeForStock("1");
                cmb_item.DataSource = ds5.Tables[0];
                cmb_item.DisplayMember = "ItemName";
                cmb_item.ValueMember = "Id";
                DataRow dr5 = ds5.Tables[0].NewRow();
                dr5["ItemName"] = "--Select One--";
                dr5["Id"] = "0";
                ds5.Tables[0].Rows.InsertAt(dr5, 0);
                cmb_item.SelectedIndex = 0;


                
               
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
       

        public int mode;
        private void btn_viewreport_Click(object sender, EventArgs e)
        {
            try
            {


                if ((ch_Cat.Checked == false) && (ch_item.Checked == false)&&(ch_Date.Checked==true))
                {

                    mode = 1;

                }

                else if ((ch_Cat.Checked == true) && (ch_item.Checked == true) && (ch_Date.Checked == true))
                {
                    if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                    {
                        if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                        {
                            mode = 2;
                        }
                        else
                        {
                            MessageBox.Show("Please Choose item ");
                            cmb_item.Focus();
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Choose category ");
                        cmb_Cat.Focus();
                        return;
                    }

                }
                else if ((ch_Cat.Checked == true) && (ch_item.Checked == false) && (ch_Date.Checked == true))
                {
                    if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                    {
                        
                        
                            mode = 3;
                       

                    }
                    else
                    {
                        MessageBox.Show("Please Choose category ");
                        cmb_Cat.Focus();
                        return;
                    }
                }
                else if ((ch_Cat.Checked == false) && (ch_item.Checked == true) && (ch_Date.Checked == true))
                {

                    if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                    {
                        mode = 4;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose item ");
                        cmb_item.Focus();
                        return;
                    }
                }
                else if ((ch_Cat.Checked == true) && (ch_item.Checked == false) && (ch_Date.Checked == false))
                {
                    if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                    {


                        mode = 5;


                    }
                    else
                    {
                        MessageBox.Show("Please Choose category ");
                        cmb_Cat.Focus();
                        return;
                    }
                }
                else if ((ch_Cat.Checked == false) && (ch_item.Checked == true) && (ch_Date.Checked == false))
                {

                    if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                    {
                        mode = 7;
                    }
                    else
                    {
                        MessageBox.Show("Please Choose item ");
                        cmb_item.Focus();
                        return;
                    }
                }
                else if ((ch_Cat.Checked == true) && (ch_item.Checked == true) && (ch_Date.Checked == false))
                {
                    if (Convert.ToDouble(cmb_Cat.SelectedValue) > 0)
                    {
                        if (Convert.ToDouble(cmb_item.SelectedValue) > 0)
                        {
                            mode = 6;
                        }
                        else
                        {
                            MessageBox.Show("Please Choose item ");
                            cmb_item.Focus();
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Choose category ");
                        cmb_Cat.Focus();
                        return;
                    }

                }
                else if ((ch_Cat.Checked == false) && (ch_item.Checked == false) && (ch_Date.Checked == false))
                {                    
                 mode = 8;
                }





                //FrmSaleReport obj = new FrmSaleReport(Convert.ToInt32(cmb_item.SelectedValue.ToString()), Convert.ToInt32(cmb_Cat.SelectedValue.ToString()), BillMode, Convert.ToInt32(cmb_Waiter.SelectedValue.ToString()), dtp_start.Value.ToShortDateString(), dtp_end.Value, saletypee, cashierid, cashiername);
                frmReportProductStock obj = new frmReportProductStock(dtp_start.Value, dtp_end.Value, mode, Convert.ToInt32(cmb_Cat.SelectedValue.ToString()), Convert.ToInt32(cmb_item.SelectedValue.ToString()));
                obj.ShowDialog();
              
                cmb_item.SelectedIndex = 0;
                cmb_Cat.SelectedIndex = 0;
                //radioalltype.Checked = true;

         


            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


       
     
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void ch_Cat_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Cat.Checked == true)
            {
                cmb_Cat.Enabled = true;
                cmb_Cat.Focus();
            }
            else
            {
                cmb_Cat.Enabled = false;
                cmb_Cat.SelectedIndex = 0;
            }
        }

        private void ch_item_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_item.Checked == true)
            {
                cmb_item.Enabled = true;
                cmb_item.Focus();
            }
            else
            {
                cmb_item.Enabled = false;
                cmb_item.SelectedIndex = 0;
            }
        }

        private void dtp_start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_end.Focus();
            }
        }

        private void dtp_end_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Cat.Focus();
            }
        }

      
        private void cmb_Cat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_item.Focus();
            }
        }
        int k = 0;
        private void btn_viewreport_Paint(object sender, PaintEventArgs e)
        {

        }
        public static GraphicsPath GetRoundedRect(RectangleF r, float radiusX, float radiusY)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            r = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            if (radiusX <= 0.0F || radiusY <= 0.0F)
            {
                gp.AddRectangle(r);
            }
            else
            {
                try
                {
                    //arcs work with diameters (radius * 2)
                    PointF d = new PointF(Math.Min(radiusX * 2, r.Width), Math.Min(radiusY * 2, r.Height));
                    gp.AddArc(r.X, r.Y, d.X, d.Y, 180, 90);
                    gp.AddArc(r.Right - d.X, r.Y, d.X - 1, d.Y, 270, 90);
                    gp.AddArc(r.Right - d.X, (r.Bottom) - d.Y - 1, d.X - 1, d.Y, 0, 90);
                    gp.AddArc(r.X, (r.Bottom) - d.Y - 1, d.X - 1, d.Y, 90, 90);
                }
                catch (Exception w)
                {

                }
            }
            gp.CloseFigure();
            return gp;
        }
        public static Color ColorFromHex(string hex)
        {
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            if (hex.Length != 6) throw new Exception("Color not valid");

            return Color.FromArgb(
                int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber));
        }

        private void btn_viewreport_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_viewreport.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_viewreport_Paint);
        }

        private void btn_viewreport_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_viewreport.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_viewreport_Paint);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        Codebehind cb = new Codebehind();
       
                  
          

      

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }
        }
        public void DateChanging()
        {
            try
            {
                var MonthFirstDay = new DateTime(Convert.ToInt32(DateTime.Now.Year), Convert.ToInt32(DateTime.Now.Month), 1);
                var LastweekFistDay = DateTime.Now.AddDays(-6);
                if ((dtp_start.Value.ToShortDateString() == MonthFirstDay.ToShortDateString()) && (dtp_end.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
                {
                    rd_monthly.Checked = true;
                }
                else if ((dtp_start.Value.ToShortDateString() == LastweekFistDay.ToShortDateString()) && (dtp_end.Value.ToShortDateString() == DateTime.Now.ToShortDateString()))
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
        private void rd_monthly_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                f = 1;
                // double days = (dtp_end.Value).Days;
                //rd_monthly.Checked = true;
                dtp_end.Value = DateTime.Now;
                dtp_start.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
                f = 0;
                // dtp_start.Value = DateTime(dtp_start.Year, dtp_start.Month, 1);
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rd_weekly_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                f = 1;
                dtp_start.Value = DateTime.Now.AddDays(-6);
                dtp_end.Value = DateTime.Now;
                f = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            if (f == 0)
            {
                DateChanging();
            }
        }

        private void cmb_Cat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_Cat.DroppedDown)
            {
                cmb_Cat.Focus();

            }
        }

        private void cmb_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_item.DroppedDown)
            {
                cmb_item.Focus();

            }
        }

       

        private void radioalltype_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiocash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiocredit_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void cmb_item_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ch_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Date.Checked == true)
            {
                dtp_start.Enabled = true;
                dtp_end.Enabled = true;
                groupBox3.Enabled = true;
                dtp_start.Focus();
            }
            else
            {
                dtp_start.Enabled = false;
                dtp_end.Enabled = false;
                groupBox3.Enabled = false;
            }

        }
    }
}
