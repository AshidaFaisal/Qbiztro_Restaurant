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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        string userid;
        public void clear()
        {
            txt_Newpassword.Text = string.Empty;
            txt_Currentpassword.Text = string.Empty;
            txt_confirmpassword.Text = string.Empty;
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
        private void PasswordChange_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            this.ActiveControl = txt_Currentpassword;
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "ChangePassword");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public string pass,oldpass;
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
            if (UpdateStatus == "1")
            {
                if (txt_Currentpassword.Text == "")
                {
                    MessageBox.Show("Please Enter Current Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Currentpassword.Focus();
                }
                else
                {
                    if (txt_Newpassword.Text == "")
                    {
                        MessageBox.Show("Please Enter New Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Newpassword.Focus();
                    }
                    else
                    {
                        if (txt_confirmpassword.Text == "")
                        {
                            MessageBox.Show("Please Enter Confirm Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_confirmpassword.Focus();
                        }
                        else
                        {
                            if (txt_Newpassword.Text == txt_confirmpassword.Text)
                            {
                                userid = File.ReadAllText("user.txt");
                                pass = obj.EncodePassword(txt_confirmpassword.Text, "Loyal");
                                oldpass = obj.EncodePassword(txt_Currentpassword.Text, "Loyal");
                                File.WriteAllText("password.txt", pass);
                                string msg = obj.UpdatePassword(userid, oldpass, pass);

                               // obj.SaveWindow(DateTime.Now, "ChangePassword", File.ReadAllText("user.txt"), "Update");
                                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Mismatch In Passwords.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_confirmpassword.Focus();
                            }
                            clear();
                            txt_Currentpassword.Focus();

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You Do Not Have The Permission To Update Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txt_Currentpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_Newpassword.Focus();
            }
        }

        private void txt_Newpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_confirmpassword.Focus();
            }
        }

        private void txt_confirmpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_Update.Focus();
            }
        }
        int k = 0;
        private void btn_Update_Paint(object sender, PaintEventArgs e)
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

        private void btn_Update_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_Update.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Update_Paint);
        }

        private void btn_Update_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_Update.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Update_Paint);
        }
        
    }
}
