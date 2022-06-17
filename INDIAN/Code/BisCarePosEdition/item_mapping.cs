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
    public partial class item_mapping : Form
    {
        public item_mapping()
        {
            InitializeComponent();
        }
        Codebehind objcode = new Codebehind();
        int f = 0;
        int k = 0;
        int Id = 0;

        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        private void bttn_delete_Click(object sender, EventArgs e)
        {
            try
            {
            if (DeleteStatus == "1")
            {
                if (cmb_mainitem_id.SelectedIndex > 0)
                {
                    if (cmb_subitem_id.SelectedIndex > 0)
                    {
                        objcode.DelItemmapping(Id);

                        MessageBox.Show("Successfully deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        txt_quantity.Text = "0";
                        cmb_subitem_id.SelectedValue = 0;
                        cmb_mainitem_id.SelectedValue = 0;
                        Gv_itemmapp.Rows.Clear();
                        Id = 0;

                        DataTable dt = objcode.SelectSubItems(Convert.ToInt32(cmb_mainitem_id.SelectedValue));

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                Gv_itemmapp[0, i].Value = dt.Rows[i]["Id"].ToString();
                                Gv_itemmapp[1, i].Value = dt.Rows[i]["ItemName"].ToString();
                                Gv_itemmapp[2, i].Value = dt.Rows[i]["Unit"].ToString();
                                Gv_itemmapp[3, i].Value = dt.Rows[i]["Quantity"].ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select SubItem", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_subitem_id.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select MainItem", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_mainitem_id.Focus();
                }
            }
            else
            {
                MessageBox.Show("You Do Not Have The Permission To Delete This Item Mapping", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet ds = new DataSet();
            ds = objcode.GETMainitemid();
            cmb_mainitem_id.DataSource = ds.Tables[0];
            cmb_mainitem_id.DisplayMember = "ItemName";
            cmb_mainitem_id.ValueMember = "Id";
            DataRow dr1 = ds.Tables[0].NewRow();
            dr1["ItemName"] = "--Select One--";
            dr1["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr1, 0);
            cmb_mainitem_id.SelectedIndex = 0;


            DataSet ds1 = new DataSet();
            ds1 = objcode.GETSubitemid();
            cmb_subitem_id.DataSource = ds1.Tables[0];
            cmb_subitem_id.DisplayMember = "ItemName";
            cmb_subitem_id.ValueMember = "Id";
            DataRow dr2 = ds1.Tables[0].NewRow();
            dr2["ItemName"] = "--Select One--";
            dr2["Id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr2, 0);
            cmb_subitem_id.SelectedIndex = 0;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref m);
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
        private void item_mapping_Load(object sender, EventArgs e)
        {
            try
            {

                ApplyTheme();
            this.ActiveControl = cmb_mainitem_id;

            DataTable dt1 = new DataTable();
            dt1 = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "ItemMapping");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();


            DataSet ds = new DataSet();
            ds = objcode.GETMainitemid();
            cmb_mainitem_id.DataSource = ds.Tables[0];
            cmb_mainitem_id.DisplayMember = "ItemName";
            cmb_mainitem_id.ValueMember = "Id";
            DataRow dr1 = ds.Tables[0].NewRow();
            dr1["ItemName"] = "--Select One--";
            dr1["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr1, 0);
            cmb_mainitem_id.SelectedIndex = 0;


            DataSet ds1 = new DataSet();
            ds1 = objcode.GETSubitemid();
            cmb_subitem_id.DataSource = ds1.Tables[0];
            cmb_subitem_id.DisplayMember = "ItemName";
            cmb_subitem_id.ValueMember = "Id";
            DataRow dr2 = ds1.Tables[0].NewRow();
            dr2["ItemName"] = "--Select One--";
            dr2["Id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr2, 0);
            cmb_subitem_id.SelectedIndex = 0;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
            if ((txt_quantity.Text != "") && (cmb_mainitem_id.SelectedIndex > 0) && (cmb_subitem_id.SelectedIndex > 0))
            {
                if (SaveStatus == "1")
                {
                    if (Convert.ToDouble(txt_quantity.Text) != 0)
                    {

                        objcode.InsertItemMapping(Convert.ToInt32(cmb_mainitem_id.SelectedValue), Convert.ToInt32(cmb_subitem_id.SelectedValue), txt_quantity.Text);

                        MessageBox.Show("Successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_subitem_id.SelectedValue = 0;
                    }
                    else
                    {
                        MessageBox.Show("Please enter quantity.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_quantity.Focus();
                    }
                    txt_quantity.Text = "0";
                  
                   // cmb_mainitem_id.SelectedValue = 0;
                    Gv_itemmapp.Rows.Clear();
                    Id = 0;

                    DataTable dt = objcode.SelectSubItems(Convert.ToInt32(cmb_mainitem_id.SelectedValue));

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Gv_itemmapp.Rows.Add();
                            Gv_itemmapp[0, i].Value = dt.Rows[i]["Id"].ToString();
                            Gv_itemmapp[1, i].Value = dt.Rows[i]["ItemName"].ToString();
                            if (dt.Rows[i]["Unit"].ToString().ToLower() == "kg")
                                Gv_itemmapp[2, i].Value = "gram";
                            else if (dt.Rows[i]["Unit"].ToString().ToLower() == "gram")
                                Gv_itemmapp[2, i].Value = "gram";
                            else
                                Gv_itemmapp[2, i].Value = dt.Rows[i]["Unit"].ToString();
                            Gv_itemmapp[3, i].Value = dt.Rows[i]["Quantity"].ToString();
                            Gv_itemmapp[4, i].Value = dt.Rows[i]["ProductId"].ToString();
                            Gv_itemmapp[5, i].Value = dt.Rows[i]["IngredientId"].ToString();
                        }
                    }
                    if (f == 1 && Convert.ToInt32(cmb_mainitem_id.SelectedValue) > 0)
                    {
                        DataTable dt1 = objcode.SelectSubItems(Convert.ToInt32(cmb_mainitem_id.SelectedValue));
                        Gv_itemmapp.Rows.Clear();
                        if (dt1.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt1.Rows.Count; i++)
                            {
                                Gv_itemmapp.Rows.Add();
                                Gv_itemmapp[0, i].Value = dt1.Rows[i]["Id"].ToString();
                                Gv_itemmapp[1, i].Value = dt1.Rows[i]["ItemName"].ToString();
                                if (dt.Rows[i]["Unit"].ToString().ToLower() == "kg")
                                    Gv_itemmapp[2, i].Value = "gram";
                                else if (dt.Rows[i]["Unit"].ToString().ToLower() == "gram")
                                    Gv_itemmapp[2, i].Value = "gram";
                                else
                                    Gv_itemmapp[2, i].Value = dt.Rows[i]["Unit"].ToString();
                                Gv_itemmapp[3, i].Value = dt1.Rows[i]["Quantity"].ToString();
                                Gv_itemmapp[4, i].Value = dt1.Rows[i]["ProductId"].ToString();
                                Gv_itemmapp[5, i].Value = dt1.Rows[i]["IngredientId"].ToString();
                            }
                        }

                    }
                }

                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Save Item Mapping", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txt_quantity.Text == "")
                {

                    MessageBox.Show("Please Enter Quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmb_mainitem_id.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Please Select MainItem", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_mainitem_id.Focus();
                    }


                    else
                    {
                        if (cmb_subitem_id.SelectedIndex <= 0)
                        {
                            MessageBox.Show("Please Select SubItem", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmb_subitem_id.Focus();
                        }

                    }
                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_mainitem_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1 && Convert.ToInt32(cmb_mainitem_id.SelectedValue) > 0)
            {
                DataTable dt = objcode.SelectSubItems(Convert.ToInt32(cmb_mainitem_id.SelectedValue));
                Gv_itemmapp.Rows.Clear();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Gv_itemmapp.Rows.Add();
                        Gv_itemmapp[0, i].Value = dt.Rows[i]["Id"].ToString();
                        Gv_itemmapp[1, i].Value = dt.Rows[i]["ItemName"].ToString();
                        if (dt.Rows[i]["Unit"].ToString().ToLower() == "kg")
                            Gv_itemmapp[2, i].Value = "gram";
                        else if (dt.Rows[i]["Unit"].ToString().ToLower() == "gram")
                            Gv_itemmapp[2, i].Value = "gram";
                        else
                            Gv_itemmapp[2, i].Value = dt.Rows[i]["Unit"].ToString();
                        Gv_itemmapp[3, i].Value = dt.Rows[i]["Quantity"].ToString();
                        Gv_itemmapp[4, i].Value = dt.Rows[i]["ProductId"].ToString();
                        Gv_itemmapp[5, i].Value = dt.Rows[i]["IngredientId"].ToString();
                    }
                }

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txt_quantity.Text == "")
            {
                txt_quantity.Text = "0";
            }
            //if (txt_quantity.Text.StartsWith("0") == true && txt_quantity.Text.EndsWith(".")!=true)
            //{
            //    txt_quantity.Text = Convert.ToDouble(txt_quantity.Text).ToString();
            //}
            string Str = txt_quantity.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {
                txt_quantity.Select(txt_quantity.Text.Length, 0);
            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantity.Text = "0";
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void btn_Cancel_Paint(object sender, PaintEventArgs e)
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

        private void btn_Cancel_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_Cancel.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Cancel_Paint);
        }

        private void btn_Cancel_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_Cancel.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Cancel_Paint);
        }

        private void cmb_mainitem_id_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_mainitem_id.DroppedDown)
            {
                cmb_mainitem_id.Focus();
            }
        }

        private void cmb_subitem_id_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_subitem_id.DroppedDown)
            {
                cmb_subitem_id.Focus();
            }
        }

        private void txt_quantity_DoubleClick(object sender, EventArgs e)
        {
            txt_quantity.SelectAll();
        }

        private void Gv_itemmapp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string s = "";
        private void cmb_subitem_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1 && Convert.ToInt32(cmb_subitem_id.SelectedValue) > 0)
            {
                s= objcode.SelectUnitOfSub(Convert.ToInt32(cmb_subitem_id.SelectedValue));
                if (s.ToLower() == "kg")
                    lblunit.Text = "gram";
                else
                    lblunit.Text = s;
            }
            else
            {
                lblunit.Text = ".";
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Gv_itemmapp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            if (e.RowIndex >= 0)
            {
                Id = Convert.ToInt32(Gv_itemmapp[0, e.RowIndex].Value);
                cmb_mainitem_id.SelectedValue = Convert.ToInt32(Gv_itemmapp[4, e.RowIndex].Value);
                cmb_subitem_id.SelectedValue = Convert.ToInt32(Gv_itemmapp[5, e.RowIndex].Value);
                txt_quantity.Text = Gv_itemmapp[3, e.RowIndex].Value.ToString();
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Gv_itemmapp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                {
                    if (DeleteStatus == "1")
                    {
                        Id = Convert.ToInt32(Gv_itemmapp[0, e.RowIndex].Value);
                        objcode.DelItemmapping(Id);

                        MessageBox.Show("Successfully deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        txt_quantity.Text = "0";
                        cmb_subitem_id.SelectedValue = 0;
                       // cmb_mainitem_id.SelectedValue = 0;
                        Gv_itemmapp.Rows.Clear();
                        Id = 0;

                        DataTable dt = objcode.SelectSubItems(Convert.ToInt32(cmb_mainitem_id.SelectedValue));

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                Gv_itemmapp.Rows.Add();
                                Gv_itemmapp[0, i].Value = dt.Rows[i]["Id"].ToString();
                                Gv_itemmapp[1, i].Value = dt.Rows[i]["ItemName"].ToString();
                                Gv_itemmapp[2, i].Value = dt.Rows[i]["Unit"].ToString();
                                Gv_itemmapp[3, i].Value = dt.Rows[i]["Quantity"].ToString();
                                Gv_itemmapp[4, i].Value = dt.Rows[i]["ProductId"].ToString();
                                Gv_itemmapp[5, i].Value = dt.Rows[i]["IngredientId"].ToString();
                            }
                        }
                        if (f == 1 && Convert.ToInt32(cmb_mainitem_id.SelectedValue) > 0)
                        {
                            DataTable dt1 = objcode.SelectSubItems(Convert.ToInt32(cmb_mainitem_id.SelectedValue));
                            Gv_itemmapp.Rows.Clear();
                            if (dt1.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt1.Rows.Count; i++)
                                {
                                    Gv_itemmapp.Rows.Add();
                                    Gv_itemmapp[0, i].Value = dt1.Rows[i]["Id"].ToString();
                                    Gv_itemmapp[1, i].Value = dt1.Rows[i]["ItemName"].ToString();
                                    Gv_itemmapp[2, i].Value = dt1.Rows[i]["Unit"].ToString();
                                    Gv_itemmapp[3, i].Value = dt1.Rows[i]["Quantity"].ToString();
                                    Gv_itemmapp[4, i].Value = dt1.Rows[i]["ProductId"].ToString();
                                    Gv_itemmapp[5, i].Value = dt1.Rows[i]["IngredientId"].ToString();
                                }
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Delete This Item Mapping", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //DataSet ds = new DataSet();
                    //ds = objcode.GETMainitemid();
                    //cmb_mainitem_id.DataSource = ds.Tables[0];
                    //cmb_mainitem_id.DisplayMember = "ItemName";
                    //cmb_mainitem_id.ValueMember = "Id";
                    //DataRow dr1 = ds.Tables[0].NewRow();
                    //dr1["ItemName"] = "--Select One--";
                    //dr1["Id"] = "0";
                    //ds.Tables[0].Rows.InsertAt(dr1, 0);
                    //cmb_mainitem_id.SelectedIndex = 0;


                    //DataSet ds1 = new DataSet();
                    //ds1 = objcode.GETSubitemid();
                    //cmb_subitem_id.DataSource = ds1.Tables[0];
                    //cmb_subitem_id.DisplayMember = "ItemName";
                    //cmb_subitem_id.ValueMember = "Id";
                    //DataRow dr2 = ds1.Tables[0].NewRow();
                    //dr2["ItemName"] = "--Select One--";
                    //dr2["Id"] = "0";
                    //ds1.Tables[0].Rows.InsertAt(dr2, 0);
                    //cmb_subitem_id.SelectedIndex = 0;
                    //f = 1;

                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_mainitem_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_subitem_id.Focus();
            }
        }

        private void cmb_subitem_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_quantity.Focus();
            }
        }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_Save.Focus();
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = "0";
            cmb_subitem_id.SelectedValue = 0;
            cmb_mainitem_id.SelectedValue = 0;
            Gv_itemmapp.Rows.Clear();
            cmb_mainitem_id.Focus();
        }

        private void cmb_mainitem_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_mainitem_id.DroppedDown)
            {
                cmb_mainitem_id.Focus();

            }
        }

        private void cmb_subitem_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_subitem_id.DroppedDown)
            {
                cmb_subitem_id.Focus();

            }
        }

        private void btn_foodcost_Click(object sender, EventArgs e)
        {
            Food__Cost fc = new Food__Cost();
            fc.ShowDialog();
        }
    }
}

