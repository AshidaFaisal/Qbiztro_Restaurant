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
    public partial class OtherExpences : Form
    {
        public OtherExpences()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        int isupdate = 0;
        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if( cmb_newtype.SelectedIndex<=0)
            {
                MessageBox.Show("Please select type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_newtype.Focus();
            }
            else
            {
                if (txt_amount.Text == "0")
                {
                    MessageBox.Show("Please enter amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_amount.Focus();
                }
                else
                {
                    if (isupdate == 0)
                    {
                        if (SaveStatus == "1")
                        {
                            obj.InsertExpence(cmb_newtype.Text, dtp_newdate.Value, txt_description.Text, txt_amount.Text);
                            MessageBox.Show("Other Expense successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                            cmb_newtype.Focus();
                        }
                        else
                        {

                            MessageBox.Show("You Do Not Have The Permission To Save Other Expense", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            
                        }
                    }
                    else
                    {
                        if (isupdate == 1)
                        {
                            if (UpdateStatus == "1")
                            {
                                obj.UpdateOtherExpence(dtp_newdate.Value, txt_amount.Text, cmb_newtype.Text, txt_description.Text, id);
                                MessageBox.Show("Other Expense details successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                isupdate = 0;
                                clear();
                                cmb_newtype.Focus();
                            }
                            else
                            {

                                MessageBox.Show("You Do Not Have The Permission To Update Other Expense", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
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
        public void clear()
        {
            txt_description.Text = "";
            txt_amount.Text = "0";
            cmb_newtype.SelectedIndex = 0;
            cmb_edittype.SelectedIndex = 0;
            cbox_date.Checked = false;
            cbox_type.Checked = false;
            dtp_enddate.Value = DateTime.Now;
            dtp_newdate.Value = DateTime.Now;
            dtp_startdate.Value = DateTime.Now;
            gv_search.Rows.Clear();
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
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
        private void OtherExpenceNew_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "OtherExpense");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();  
            this.ActiveControl = cmb_newtype;

            DataSet ds = obj.GetOtherExpenceType();
            cmb_newtype.DataSource = ds.Tables[0];
            cmb_newtype.DisplayMember = "Name";
            cmb_newtype.ValueMember = "Id";

            DataRow dr4 = ds.Tables[0].NewRow();
            dr4["Name"] = "--Select One--";
            dr4["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr4, 0);
            cmb_newtype.SelectedIndex = 0;

            DataSet ds1 = obj.GetOtherExpenceType();
            cmb_edittype.DataSource = ds1.Tables[0];
            cmb_edittype.DisplayMember = "Name";
            cmb_edittype.ValueMember = "Id";

            DataRow dr1 = ds1.Tables[0].NewRow();
            dr1["Name"] = "--Select One--";
            dr1["Id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr1, 0);
            cmb_edittype.SelectedIndex = 0;



            //DataTable dt = obj.SelectIncomeExpenseType("1");
            //cmb_newtype.DataSource = dt;
            //cmb_newtype.DisplayMember = "Name";
            //cmb_newtype.ValueMember = "Id";
            //DataRow dr = dt.NewRow();
            //dr["Name"] = "--Select One--";
            //dr["Id"] = "0";
            //dt.Rows.InsertAt(dr, 0);
            //cmb_newtype.SelectedIndex = 0;
           // f = 1;


            cbox_date.Checked = true;
            cbox_type.Checked = false;
            dtp_enddate.Value = DateTime.Now;
            dtp_newdate.Value = DateTime.Now;
            dtp_startdate.Value = DateTime.Now;
            cmb_edittype.Enabled = false;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_search_Click(object sender, EventArgs e)
        {
            try
            {
            gv_search.Rows.Clear();
            string start = dtp_startdate.Value.ToString("yyyy-MM-dd");
            string end = dtp_enddate.Value.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            if ((cbox_date.Checked == true) && (cbox_type.Checked == false))
            {
                dt = obj.SearchOtherExpence(start, end, cmb_edittype.Text, "1");
            }
            if ((cbox_date.Checked == false) && (cbox_type.Checked == true))
            {
                if (cmb_edittype.SelectedIndex > 0)
                {
                    dt = obj.SearchOtherExpence(start, end, cmb_edittype.Text, "2");
                }
                else
                {
                    MessageBox.Show("Please select a Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_edittype.Focus();
                }
            }
            if ((cbox_date.Checked == true) && (cbox_type.Checked == true))
            {
                if (cmb_edittype.SelectedIndex > 0)
                {
                    dt = obj.SearchOtherExpence(start, end, cmb_edittype.Text, "3");
                }
                else
                {
                    MessageBox.Show("Please select a Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_edittype.Focus();
                }
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gv_search.Rows.Add();
                gv_search[0, i].Value = i + 1;
                gv_search[1, i].Value = Convert.ToDateTime(dt.Rows[i]["Date"]).ToShortDateString();
                gv_search[2, i].Value = dt.Rows[i]["Type"].ToString();
                gv_search[4, i].Value = dt.Rows[i]["Description"].ToString();
                gv_search[3, i].Value =Convert.ToDouble( dt.Rows[i]["Amount"]).ToString("F2");
                gv_search[5, i].Value = dt.Rows[i]["Id"].ToString();

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cbox_type_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_type.Checked == true)
            {
                cmb_edittype.Enabled = true;
                cmb_edittype.Focus();
            }
            else
            {
                cmb_edittype.Enabled = false;
            }
        }

        private void cbox_date_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_date.Checked == true)
            {
                dtp_enddate.Enabled = true;
                dtp_startdate.Enabled = true;
                dtp_startdate.Focus();

            }
            else
            {
                dtp_enddate.Enabled = false;
                dtp_startdate.Enabled = false;
            }
        }
        DialogResult dr1;
        string id;
        private void gv_search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            if (e.RowIndex >= 0)
            {
                id = gv_search[5, e.RowIndex].Value.ToString();

                // gv_search.Rows.Remove(gv_search.Rows[e.RowIndex]);
                dtp_newdate.Value = Convert.ToDateTime(gv_search[1, e.RowIndex].Value.ToString());
                cmb_newtype.Text = gv_search[2, e.RowIndex].Value.ToString();
                txt_amount.Text = gv_search[3, e.RowIndex].Value.ToString();
                txt_description.Text = gv_search[4, e.RowIndex].Value.ToString();
                dr1 = DialogResult.OK;
                isupdate = 1;
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            try
            {
            if (DeleteStatus == "1")
            {
                if (isupdate == 1)
                {
                    obj.DeleteExpense(id);
                    MessageBox.Show("Expence sucessully deleted ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isupdate = 0;
                    clear();
                    cmb_newtype.Focus();
                  
                }
                else
                {
                    MessageBox.Show("Please select Expence for delete ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete Other Expence", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (txt_amount.Text == "")
            {
                txt_amount.Text = "0";
            }
            if (txt_amount.Text.StartsWith("0") == true && txt_amount.Text.EndsWith(".")==false)
            {
                txt_amount.Text = Convert.ToDouble(txt_amount.Text).ToString();
            }
            string Str = txt_amount.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {
                txt_amount.Select(txt_amount.Text.Length, 0);
                // Functionality here	
            }
            else
            {
                MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_amount.Text = "0";
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void dtp_newdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_newtype.Focus();
            }
        }

        private void cmb_newtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_description.Focus();
            }
        }

        private void txt_description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_amount.Focus();
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bttn_save.Focus();
            }
        }

        private void dtp_enddate_Enter(object sender, EventArgs e)
        {
            
        }

        private void dtp_enddate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bttn_search.Focus();
            }
        }

        private void bttn_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gv_search.Focus();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
            cmb_newtype.Focus();
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int k = 0;
        private void bttn_save_Paint(object sender, PaintEventArgs e)
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

        private void bttn_save_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            bttn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_save_Paint);
        }

        private void bttn_save_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            bttn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_save_Paint);
        }

        private void bttn_save_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_newtype.Focus();
            }
        }

        private void bttn_delete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_newtype.Focus();
            }
        }

        private void btn_reset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_newtype.Focus();
            }
        }

        private void cmb_edittype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bttn_search.Focus();
            }
        }

        private void bttn_newcategory_Click(object sender, EventArgs e)
        {
            IncomeExpenseType ob = new IncomeExpenseType(2);
            ob.ShowDialog();
            DataSet ds = obj.GetOtherExpenceType();
            cmb_newtype.DataSource = ds.Tables[0];
            cmb_newtype.DisplayMember = "Name";
            cmb_newtype.ValueMember = "Id";

            DataRow dr4 = ds.Tables[0].NewRow();
            dr4["Name"] = "--Select One--";
            dr4["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr4, 0);
            cmb_newtype.SelectedIndex = 0;

            DataSet ds1 = obj.GetOtherExpenceType();
            cmb_edittype.DataSource = ds1.Tables[0];
            cmb_edittype.DisplayMember = "Name";
            cmb_edittype.ValueMember = "Id";

            DataRow dr1 = ds1.Tables[0].NewRow();
            dr1["Name"] = "--Select One--";
            dr1["Id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr1, 0);
            cmb_edittype.SelectedIndex = 0;
        }




    }
}
