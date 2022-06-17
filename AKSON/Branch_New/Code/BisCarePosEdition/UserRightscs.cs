using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace BisCarePosEdition
{
    public partial class UserRightscs : Form
    {
        public UserRightscs()
        {
            InitializeComponent();
            ch_selectall.Checked = false;
        }
        Codebehind ObjCode = new Codebehind();
        int f = 0;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";

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
        private void UserRightscs_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "UserRights");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

            DataSet ds2 = new DataSet();
            ds2 = ObjCode.GetUserForRightSettings();
            Cmb_username.DataSource = ds2.Tables[0];
            Cmb_username.DisplayMember = "username";
            Cmb_username.ValueMember = "user_id";
            DataRow dr = ds2.Tables[0].NewRow();
            dr["username"] = "--Select One--";
            dr["user_id"] = "0";
            ds2.Tables[0].Rows.InsertAt(dr, 0);
            Cmb_username.SelectedIndex = 0;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Cmb_username_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
            if (f == 1)
            {
                dgvRights.Rows.Clear();
                if (Convert.ToInt32(Cmb_username.SelectedValue) > 0)
                {
                    DataTable dt = new DataTable();
                    dt = ObjCode.GetUserRights(Cmb_username.SelectedValue.ToString());
                    if (dt.Rows.Count < 1)
                    {
                        DataTable dt1 = new DataTable();
                        dt1 = ObjCode.GetFormNames();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            dgvRights.Rows.Add();
                            dgvRights[0, i].Value = dt1.Rows[i]["FormName"].ToString();
                            dgvRights[1, i].Value = false;
                            dgvRights[2, i].Value = false;
                            dgvRights[3, i].Value = false;
                            dgvRights[4, i].Value = false;
                            dgvRights[5, i].Value = dt1.Rows[i]["Id"].ToString();
                            dgvRights[6, i].Value = false;
                           // dgvRights[7,i].Value= dt1.Rows[i]["ParentId"].ToString();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dgvRights.Rows.Add();
                            dgvRights[0, i].Value = dt.Rows[i]["FormName"].ToString();
                            if (dt.Rows[i]["ViewStatus"].ToString() == "1")
                            {
                                dgvRights[1, i].Value = true;
                            }
                            else
                            {
                                dgvRights[1, i].Value = false;
                            }
                            if (dt.Rows[i]["SaveStatus"].ToString() == "1")
                            {
                                dgvRights[2, i].Value = true;
                            }
                            else
                            {
                                dgvRights[2, i].Value = false;
                            }
                            if (dt.Rows[i]["UpdateStatus"].ToString() == "1")
                            {
                                dgvRights[3, i].Value = true;
                            }
                            else
                            {
                                dgvRights[3, i].Value = false;
                            }
                            if (dt.Rows[i]["DeleteStatus"].ToString() == "1")
                            {
                                dgvRights[4, i].Value = true;
                            }
                            else
                            {
                                dgvRights[4, i].Value = false;
                            }
                            dgvRights[5, i].Value = dt.Rows[i]["FormId"].ToString();
                            if (dt.Rows[i]["DeleteStatus"].ToString() == "1" && dt.Rows[i]["UpdateStatus"].ToString() == "1" && dt.Rows[i]["SaveStatus"].ToString() == "1" && dt.Rows[i]["ViewStatus"].ToString() == "1")
                                dgvRights[6, i].Value = true;
                            else
                                dgvRights[6, i].Value = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string parentid;
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if (dgvRights.Rows.Count > 0)
            {
                if (SaveStatus == "1")
                {
                    ObjCode.DeleteUserRightSettings(Cmb_username.SelectedValue.ToString());
                    for (int i = 0; i < dgvRights.Rows.Count; i++)
                    {
                        string ViewStat = "0", SaveStat = "0", UpdateStat = "0", DeleteStat = "0";
                        if (Convert.ToBoolean(dgvRights[1, i].Value) == true)
                        {
                            ViewStat = "1";
                        }
                        if (Convert.ToBoolean(dgvRights[2, i].Value) == true)
                        {
                            SaveStat = "1";
                        }
                        if (Convert.ToBoolean(dgvRights[3, i].Value) == true)
                        {
                            UpdateStat = "1";
                        }
                        if (Convert.ToBoolean(dgvRights[4, i].Value) == true)
                        {
                            DeleteStat = "1";
                        }
                     
                        
                        ObjCode.InsertUserRightSettings(Cmb_username.SelectedValue.ToString(), dgvRights[5, i].Value.ToString(), ViewStat, SaveStat, UpdateStat, DeleteStat);
                    }
                    // ObjCode.SaveWindow(DateTime.Now, "UserRightSettings", File.ReadAllText("user.txt"), "Save");
                    MessageBox.Show("User Right Settings Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRights.Rows.Clear();
                    Cmb_username.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Save User Rights", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Select A User.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_username.Focus();

            }
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
        int k = 0;
        private void btn_save_Paint(object sender, PaintEventArgs e)
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

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (ch_selectall.Checked == true)
            {
                if (f == 1)
                {
                    dgvRights.Rows.Clear();
                    if (Convert.ToInt32(Cmb_username.SelectedValue) > 0)
                    {

                        DataTable dt1 = new DataTable();
                        dt1 = ObjCode.GetFormNames();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            dgvRights.Rows.Add();
                            dgvRights[0, i].Value = dt1.Rows[i]["FormName"].ToString();
                            dgvRights[1, i].Value = true;
                            dgvRights[2, i].Value = true;
                            dgvRights[3, i].Value = true;
                            dgvRights[4, i].Value = true;
                            dgvRights[5, i].Value = dt1.Rows[i]["Id"].ToString();
                            dgvRights[6, i].Value = true;
                        }
                    }

                }
            }
            else
            {
                if (f == 1)
                {
                    dgvRights.Rows.Clear();
                    if (Convert.ToInt32(Cmb_username.SelectedValue) > 0)
                    {

                        DataTable dt1 = new DataTable();
                        dt1 = ObjCode.GetFormNames();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            dgvRights.Rows.Add();
                            dgvRights[0, i].Value = dt1.Rows[i]["FormName"].ToString();
                            dgvRights[1, i].Value = false;
                            dgvRights[2, i].Value = false;
                            dgvRights[3, i].Value = false;
                            dgvRights[4, i].Value = false;
                            dgvRights[5, i].Value = dt1.Rows[i]["Id"].ToString();
                            dgvRights[6, i].Value = false;
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

        private void dgvRights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            if (e.ColumnIndex == 6)
            {
              
                // int tab = 0;
                //  MessageBox.Show("" + dgvRights[6, e.RowIndex].State);
                if (Convert.ToBoolean(dgvRights[6, e.RowIndex].EditedFormattedValue) == true)
                {

                    dgvRights[1, e.RowIndex].Value = true;
                    dgvRights[2, e.RowIndex].Value = true;
                    dgvRights[3, e.RowIndex].Value = true;
                    dgvRights[4, e.RowIndex].Value = true;
                }
                else
                {
                    dgvRights[1, e.RowIndex].Value = false;
                    dgvRights[2, e.RowIndex].Value = false;
                    dgvRights[3, e.RowIndex].Value = false;
                    dgvRights[4, e.RowIndex].Value = false;

                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void Cmb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Cmb_username.DroppedDown)
            {
                Cmb_username.Focus();

            }
        }
           
         
    }
}
