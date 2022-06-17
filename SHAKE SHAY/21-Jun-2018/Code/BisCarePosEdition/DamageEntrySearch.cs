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
using System.IO;

namespace BisCarePosEdition
{
    public partial class DamageEntrySearch : Form
    {
        public DamageEntrySearch()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        int f = 0;
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
        private void StockEntrySearch_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                DataSet ds = new DataSet();
                ds = obj.GetDealer();
                //ds = obj.GetItemnamestock();
                //cmb_itemname.DataSource = ds.Tables[0];
                //cmb_itemname.ValueMember = "ItemId";
                //cmb_itemname.DisplayMember = "ItemName";

                //DataRow dr = ds.Tables[0].NewRow();
                //dr["ItemName"] = "--Select One--";
                ////dr["ItemCode"] = "--Select One--";
                //dr["ItemId"] = "0";
                //ds.Tables[0].Rows.InsertAt(dr, 0);
                //cmb_itemname.SelectedIndex = 0;
                cmb_itemname.DataSource = ds.Tables[0];
                cmb_itemname.DisplayMember = "dealer_name";
                cmb_itemname.ValueMember = "dealer_id";
                DataRow dr = ds.Tables[0].NewRow();
                dr["dealer_name"] = "--Select One--";
                dr["dealer_id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_itemname.SelectedIndex = 0;

                f = 1;
                ch_date.Checked = true;
                chk_oldStock.Checked = true;
                ch_itemname.Checked = false;
                grpdate.Enabled = true;
                grpitem.Enabled = false;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string start = dtp_start.Value.ToString("yyyy-MM-dd");
                string end = dtp_end.Value.ToString("yyyy-MM-dd");
                gv_stocksearch.Rows.Clear();
                DataTable dt = new DataTable();

                if (f == 1)
                {
                    if (chk_oldStock.Checked == false)
                    {
                        //if (ch_date.Checked == true)
                        //{
                        //    dt = obj.SearchProductStockOld("2", start, end);
                        //}
                        //else
                        //{
                        //    dt = obj.SearchProductStockOld("1", start, end);
                        //}

                        if ((ch_itemname.Checked == true) && (ch_date.Checked == false))
                        {
                            if (cmb_itemname.SelectedIndex > 0)
                            {
                                dt = obj.SearchDamageEntry("2", start, end);
                            }
                            else
                            {
                                MessageBox.Show("Please select an item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cmb_itemname.Focus();
                            }
                        }

                        else
                        {
                            if ((ch_itemname.Checked == false) && (ch_date.Checked == true))
                            {

                                dt = obj.SearchDamageEntry("1", start, end);

                            }
                            else
                            {
                                if ((ch_itemname.Checked == true) && (ch_date.Checked == true))
                                {

                                    if (cmb_itemname.SelectedIndex > 0)
                                    {
                                        dt = obj.SearchDamageEntry("3", start, end);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please select an item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        cmb_itemname.Focus();
                                    }
                                }
                            }
                        }
                    }



                    else
                    {
                        if (ch_date.Checked == true)
                        {
                            dt = obj.SearchDamageEntry("2", start, end);
                        }
                        else
                        {
                            dt = obj.SearchDamageEntry("1", start, end);
                        }

                    }
                    int i = 0;

                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        /// in grid view order  sl ,date dealer, delaer ref no, total amount , ,Paidamount ,discount   purchase type 
                        gv_stocksearch.Rows.Add();
                        gv_stocksearch[0, i].Value = i + 1;
                        gv_stocksearch[1, i].Value = dt.Rows[i]["Date"].ToString();
                        //gv_stocksearch[2, i].Value = dt.Rows[i]["dealer_name"].ToString();
                        //gv_stocksearch[3, i].Value = dt.Rows[i]["DealerRef"].ToString();
                        //gv_stocksearch[4, i].Value = Convert.ToDouble(dt.Rows[i]["Total"]).ToString("F2");
                        //gv_stocksearch[5, i].Value = Convert.ToDouble(dt.Rows[i]["PaidedAmount"]).ToString("F2");
                        //gv_stocksearch[6, i].Value = Convert.ToDouble(dt.Rows[i]["Discount"]).ToString("F2");
                        //if (Convert.ToDouble(dt.Rows[i]["PurchaseType"]) == 1)
                        //    gv_stocksearch[7, i].Value = "Old Stock";
                        //else if (Convert.ToDouble(dt.Rows[i]["PurchaseType"]) == 0)
                        //    gv_stocksearch[7, i].Value = "Direct";
                        //gv_stocksearch[7, i].Value = dt.Rows[i]["Id"].ToString();
                        gv_stocksearch[9, i].Value = dt.Rows[i]["MasterId"].ToString();
                        gv_stocksearch[10, i].Value = dt.Rows[i]["UserName"].ToString();

                    }

                    //if (dt.Rows.Count < 1)
                    //{
                    //    MessageBox.Show("No Search Result Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }


        private void ch_itemname_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_itemname.Checked == true)
            {
                grpitem.Enabled = true;
                cmb_itemname.Focus();
            }
            else
            {
                grpitem.Enabled = false;
            }
        }

        private void ch_date_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_date.Checked == true)
            {
                grpdate.Enabled = true;
                dtp_start.Focus();

            }
            else
            {
                grpdate.Enabled = false;
            }
        }
        public string id;
        public DialogResult dr;
        private void gv_stocksearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int r = e.RowIndex;
                    id = gv_stocksearch[9, r].Value.ToString();
                    dr = DialogResult.OK;
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int k = 0;
        private void btn_search_Paint(object sender, PaintEventArgs e)
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

        private void btn_search_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_search.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_search_Paint);
        }

        private void btn_search_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_search.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_search_Paint);
        }

        private void cmb_itemname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_itemname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_search.Focus();
            }
        }

        private void cmb_itemname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_itemname.DroppedDown)
            {
                cmb_itemname.Focus();

            }
        }

        private void chk_oldStock_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_oldStock.Checked == true)
            {
                ch_itemname.Checked = false;
                ch_itemname.Enabled = false;
            }
            else
            {
                ch_itemname.Enabled = true;
            }
        }
    }
}
