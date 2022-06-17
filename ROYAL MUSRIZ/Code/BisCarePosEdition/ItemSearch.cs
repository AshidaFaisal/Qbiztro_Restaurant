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
    public partial class ItemSearch : Form
    {
        public ItemSearch()
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
        private void ItemSearch_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            this.ActiveControl = cmb_itemcode;
            DataSet ds = new DataSet();
            ds = obj.GetItem();
            cmb_itemname.DataSource = ds.Tables[0];
            cmb_itemname.DisplayMember = "ItemName";
            cmb_itemname.ValueMember = "Id";

            cmb_itemcode.DataSource = ds.Tables[0];
            cmb_itemcode.DisplayMember = "ItemCode";
            cmb_itemcode.ValueMember = "Id";

            DataRow dr= ds.Tables[0].NewRow();
            dr["ItemName"] = "--Select One--";
            dr["ItemCode"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_itemname.SelectedIndex = 0;


            DataSet ds4 = new DataSet();
            ds4 = obj.GetCategory();
            cmb_catname.DataSource = ds4.Tables[0];
            cmb_catname.DisplayMember = "Name";
            cmb_catname.ValueMember = "Id";
            DataRow dr4 = ds4.Tables[0].NewRow();
            dr4["Name"] = "--Select One--";
            dr4["Id"] = "0";
            ds4.Tables[0].Rows.InsertAt(dr4, 0);
            cmb_catname.SelectedIndex = 0;

            //DataSet ds5 = new DataSet();
            //ds5 = obj.GetBrand();
            //cmb_brandid.DataSource = ds5.Tables[0];
            //cmb_brandid.DisplayMember = "Name";
            //cmb_brandid.ValueMember = "Id";
            //DataRow dr5 = ds5.Tables[0].NewRow();
            //dr5["Name"] = "--Select One--";
            //dr5["Id"] = "0";
            //ds5.Tables[0].Rows.InsertAt(dr5, 0);
            //cmb_brandid.SelectedIndex = 0;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        public void gridfill(DataTable dt)
        {
            try
            {
            gv_itemdetails.Rows.Clear();

            for (int i = -0; i < dt.Rows.Count; i++)
            {
                gv_itemdetails.Rows.Add();
                gv_itemdetails[0, i].Value = i + 1;
                gv_itemdetails[1, i].Value = dt.Rows[i]["ItemCode"].ToString();
                gv_itemdetails[2, i].Value = dt.Rows[i]["ItemName"].ToString();
                gv_itemdetails[3, i].Value = dt.Rows[i]["Catname"].ToString();
               // gv_itemdetails[4, i].Value = dt.Rows[i]["Name"].ToString();
                gv_itemdetails[4, i].Value = dt.Rows[i]["Unit"].ToString();
                gv_itemdetails[5, i].Value = dt.Rows[i]["CostPrice"].ToString();
                gv_itemdetails[6, i].Value = dt.Rows[i]["SellPrice"].ToString();
                gv_itemdetails[7, i].Value = dt.Rows[i]["Id"].ToString();
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void cmb_itemcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(),  cmb_catname.SelectedValue.ToString(), "1");
                gridfill(dt);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_catname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "2");
                gridfill(dt);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_brandid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(),  cmb_catname.SelectedValue.ToString(), "3");
                gridfill(dt);
            }
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
            if ((ch_itemcode.Checked == true) && (ch_itemname.Checked == false) && (ch_category.Checked == false) )
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "4");
                gridfill(dt);
            }
            if ((ch_itemcode.Checked == false) && (ch_itemname.Checked == true) && (ch_category.Checked == false) )
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(),cmb_catname.SelectedValue.ToString(), "5");
                gridfill(dt);
            }
            if ((ch_itemcode.Checked == false) && (ch_itemname.Checked == false) && (ch_category.Checked == true) )
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "7");
                gridfill(dt);
            }
           
            if ((ch_itemcode.Checked == true) && (ch_itemname.Checked == true) && (ch_category.Checked == false) )
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "8");
                gridfill(dt);
            }
           
            if ((ch_itemcode.Checked == true) && (ch_itemname.Checked == false) && (ch_category.Checked == true) )
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "10");
                gridfill(dt);
            }
            //if ((ch_itemcode.Checked == false) && (ch_itemname.Checked == true) && (ch_category.Checked == false) )
            //{
            //    DataTable dt = new DataTable();
            //    dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(),  cmb_catname.SelectedValue.ToString(), "11");
            //    gridfill(dt);
            //}
            if ((ch_itemcode.Checked == false) && (ch_itemname.Checked == true) && (ch_category.Checked == true) )
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "12");
                gridfill(dt);
            }
            //if ((ch_itemcode.Checked == false) && (ch_itemname.Checked == false) && (ch_category.Checked == true) )
            //{
            //    DataTable dt = new DataTable();
            //    dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(),  cmb_catname.SelectedValue.ToString(), "13");
            //    gridfill(dt);
            //}
            if ((ch_itemcode.Checked == true) && (ch_itemname.Checked == true) && (ch_category.Checked == true) )
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "14");
                gridfill(dt);
            }
            //if ((ch_itemcode.Checked == true) && (ch_itemname.Checked == true) && (ch_category.Checked == false) )
            //{
            //    DataTable dt = new DataTable();
            //    dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(),cmb_catname.SelectedValue.ToString(), "15");
            //    gridfill(dt);
            //}
            //if ((ch_itemcode.Checked == false) && (ch_itemname.Checked == true) && (ch_category.Checked == true) )
            //{
            //    DataTable dt = new DataTable();
            //    dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "16");
            //    gridfill(dt);
            //}
            //if ((ch_itemcode.Checked == true) && (ch_itemname.Checked == false) && (ch_category.Checked == true) )
            //{
            //    DataTable dt = new DataTable();
            //    dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "17");
            //    gridfill(dt);
            //}
            //if ((ch_itemcode.Checked == true) && (ch_itemname.Checked == true) && (ch_category.Checked == true) )
            //{
            //    DataTable dt = new DataTable();
            //    dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(),cmb_catname.SelectedValue.ToString(), "18");
            //    gridfill(dt);
            //}
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            //cmb_brandid.SelectedIndex = 0;
            cmb_catname.SelectedIndex = 0;
            cmb_itemcode.SelectedIndex = 0;
            txt_text.Text = "";
            //ch_brand.Checked = false;
            ch_category.Checked = false;
            ch_itemcode.Checked = false;
            ch_itemname.Checked = false;
            gv_itemdetails.Rows.Clear();
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_itemname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gv_itemdetails.Focus();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cmb_itemcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gv_itemdetails.Focus();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cmb_catname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gv_itemdetails.Focus();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cmb_brandid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gv_itemdetails.Focus();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gv_itemdetails.Focus();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
        public string id;
        public DialogResult dgr;
        private void gv_itemdetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
            if (e.KeyData == Keys.Enter)
            {
                int c = gv_itemdetails.CurrentCell.RowIndex;
                //id= = gv_itemdetails[1, c].Value.ToString();
                id = gv_itemdetails[7, c].Value.ToString();
                dgr = DialogResult.OK;
                this.Close();
            }
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_itemcode_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_itemcode.DroppedDown)
            {
                cmb_itemcode.Focus();

            }
        }

        private void cmb_itemname_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_itemname.DroppedDown)
            {
                cmb_itemname.Focus();

            }
        }

        private void cmb_catname_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_catname.DroppedDown)
            {
                cmb_catname.Focus();

            }
        }

        private void cmb_brandid_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!cmb_brandid.DroppedDown)
            //{
            //    cmb_brandid.Focus();

            //}
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            if( (ch_Ingradiant.Checked == true)&&(ch_Product.Checked==false))
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(),"19");
                gridfill(dt);
            }
            if ((ch_Ingradiant.Checked == false) && (ch_Product.Checked == true))
            {
                DataTable dt = new DataTable();
                dt = obj.SearchItem(txt_text.Text, cmb_itemname.SelectedValue.ToString(), cmb_catname.SelectedValue.ToString(), "18");
                gridfill(dt);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void cmb_catname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_catname.DroppedDown)
            {
                cmb_catname.Focus();

            }
        }

        private void cmb_itemname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_itemname.DroppedDown)
            {
                cmb_itemname.Focus();

            }
        }
    }
}
