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
using System.Security.Cryptography;

namespace BisCarePosEdition
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            Cmb_username.Enabled = false;
        }
        Codebehind cb = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public void clear()
        {
            try
            {
            DataSet ds2 = new DataSet();
            ds2 = cb.GetUsername();
            Cmb_username.DataSource = ds2.Tables[0];
            Cmb_username.DisplayMember = "username";
            Cmb_username.ValueMember = "user_id";
            DataRow dr = ds2.Tables[0].NewRow();
            dr["username"] = "--Select One--";
            dr["user_id"] = "0";
            ds2.Tables[0].Rows.InsertAt(dr, 0);
            Cmb_username.SelectedIndex = 0;


            DataSet dss = new DataSet();
            dss = cb.GetDesignation();
            cmb_designation.DataSource = dss.Tables[0];
            cmb_designation.DisplayMember = "designation_name";
            cmb_designation.ValueMember = "designation_id";
            DataRow dr1 = dss.Tables[0].NewRow();
            dr1["designation_name"] = "--Select One--";
            dr1["designation_id"] = "0";
            dss.Tables[0].Rows.InsertAt(dr1, 0);
            cmb_designation.SelectedIndex = 0;

            DataSet ds1 = cb.Getusertype();
            cmb_accounttype.DataSource = ds1.Tables[0];
            cmb_accounttype.DisplayMember = "UserAcc_type";
            cmb_accounttype.ValueMember = "UserAcc_id";
            DataRow dr2 = ds1.Tables[0].NewRow();
            dr2["UserAcc_type"] = "--Select One--";
            dr2["UserAcc_id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr2, 0);
            cmb_accounttype.SelectedIndex = 0;

            f = 1;

            button1.Enabled = false;


            cmb_accounttype.Text = string.Empty;
            txt_confrmpassword.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_contact.Text = string.Empty;
            cmb_designation.Text = string.Empty;
            //Cmb_username.Text = string.Empty;
            button1.Enabled = false;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        int f = 0;
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
        private void User_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = cb.GetFormUserRights(File.ReadAllText("user.txt"), "User");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

            this.ActiveControl = cmb_accounttype;

            DataSet ds2 = new DataSet();
            ds2 = cb.GetUsername();
            Cmb_username.DataSource = ds2.Tables[0];
            Cmb_username.DisplayMember = "username";
            Cmb_username.ValueMember = "user_id";
            DataRow dr = ds2.Tables[0].NewRow();
            dr["username"] = "--Select One--";
            dr["user_id"] = "0";
            ds2.Tables[0].Rows.InsertAt(dr, 0);
            Cmb_username.SelectedIndex = 0;


            DataSet ds = new DataSet();
            ds = cb.GetDesignation();
            cmb_designation.DataSource = ds.Tables[0];
            cmb_designation.DisplayMember = "designation_name";
            cmb_designation.ValueMember = "designation_id";

            DataRow dr7 = ds.Tables[0].NewRow();
            dr7["designation_name"] = "--Select One--";
            dr7["designation_id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr7, 0);
            cmb_designation.SelectedValue = 0;

            DataSet ds1 = cb.Getusertype();
            cmb_accounttype.DataSource = ds1.Tables[0];
            cmb_accounttype.DisplayMember = "UserAcc_type";
            cmb_accounttype.ValueMember = "UserAcc_id";
            DataRow dr2 = ds1.Tables[0].NewRow();
            dr2["UserAcc_type"] = "--Select One--";
            dr2["UserAcc_id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr2, 0);
            cmb_accounttype.SelectedIndex = 0;
           
            f = 1;

            button1.Enabled = false;


            cmb_accounttype.Text = string.Empty;
            txt_confrmpassword.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_contact.Text = string.Empty;
            cmb_designation.SelectedIndex = 0;
            //Cmb_username.Text = string.Empty;
            button1.Enabled = false;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
       

        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if (Rb_new.Checked == true)
            {
                if (SaveStatus == "1")
                {
                    if (txt_username.Text == "")
                    {
                        MessageBox.Show("Please Enter UserName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Focus();
                    }

                    else if (cmb_accounttype.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Please Select Account Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_accounttype.Focus();
                    }
                    else if (txt_password.Text == "")
                    {
                        MessageBox.Show("Please Enter Password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Focus();
                    }
                    else if (txt_confrmpassword.Text == "")
                    {
                        MessageBox.Show("Please Enter Confirm Password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_confrmpassword.Focus();

                    }

                    else if (txt_name.Text == "")
                    {
                        MessageBox.Show("Please Enter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_name.Focus();

                    }
                    else if (cmb_designation.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Please Select Designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_designation.Focus();
                    }

                    else
                    {
                        if ((txt_username.Text != "") && (txt_password.Text != "") && (txt_name.Text != "") && (txt_confrmpassword.Text != "") && (cmb_designation.SelectedIndex >= 0) && (cmb_accounttype.SelectedIndex >= 0))
                        {
                            if (txt_password.Text == txt_confrmpassword.Text)
                            {
                                string pass = cb.EncodePassword(txt_password.Text, "Loyal");
                             string msg = cb.InsertUserAccount(cmb_accounttype.SelectedValue.ToString(), txt_username.Text, pass, txt_name.Text, txt_contact.Text, cmb_designation.SelectedValue.ToString());
                                if (msg == "Username Successfully Saved.")
                                {
                                    MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // obj.SaveWindow(DateTime.Now, "User", File.ReadAllText("user.txt"), "Save");
                                }
                                else
                                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear();
                                
                            }
                            else
                            {
                                if (txt_password.Text != txt_confrmpassword.Text)
                                {

                                    MessageBox.Show("Password Does Not Match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_confrmpassword.Focus();
                                }
                            }
                        }

                    }
                }

                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Save User", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }



            //  }

            if ((Rb_edit.Checked == true) && (Cmb_username.SelectedIndex > 0))
            {

                if (UpdateStatus == "1")
                {
                    if (txt_username.Text == "")
                    {
                        MessageBox.Show("Please Enter UserName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Focus();
                    }

                    else if (cmb_accounttype.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Please Select Account Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_accounttype.Focus();
                    }
                    else if (txt_password.Text == "")
                    {
                        MessageBox.Show("Please Enter Password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Focus();
                    }
                    else if (txt_confrmpassword.Text == "")
                    {
                        MessageBox.Show("Please Enter Confirm Password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_confrmpassword.Focus();

                    }

                    else if (txt_name.Text == "")
                    {
                        MessageBox.Show("Please Enter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_name.Focus();

                    }
                    else if (cmb_designation.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Please Select Designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_designation.Focus();
                    }


                    else if (txt_password.Text == txt_confrmpassword.Text)
                    {
                        string pass = cb.EncodePassword(txt_password.Text, "Loyal");
                        string msg = cb.UpdateUser(Cmb_username.SelectedValue.ToString(), cmb_accounttype.SelectedValue.ToString(), txt_username.Text, pass, txt_name.Text, txt_contact.Text, cmb_designation.SelectedValue.ToString());
                        //obj.SaveWindow(DateTime.Now, "User", File.ReadAllText("user.txt"), "Update");
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Rb_new.Checked = true;
                        cmb_accounttype.Focus();

                        DataSet ds2 = new DataSet();
                        ds2 = cb.GetUsername();
                        Cmb_username.DataSource = ds2.Tables[0];
                        Cmb_username.DisplayMember = "username";
                        Cmb_username.ValueMember = "user_id";
                        DataRow dr = ds2.Tables[0].NewRow();
                        dr["username"] = "--Select One--";
                        dr["user_id"] = "0";
                        ds2.Tables[0].Rows.InsertAt(dr, 0);
                        Cmb_username.SelectedIndex = 0;
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Password Does Not Match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Update User", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
                if ((Rb_edit.Checked == true) && (Cmb_username.SelectedIndex <= 0))
                {
                    MessageBox.Show("Please Select Any UserName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            Rb_new.Checked = true;
            cmb_accounttype.Focus();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
            if (DeleteStatus == "1")
            {
            try
            {
                cb.DeleteUser(Cmb_username.SelectedValue.ToString());
                    MessageBox.Show("Deletion Successfull.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Rb_new.Checked = true;
                    cmb_accounttype.Focus();
                    //obj.SaveWindow(DateTime.Now, "User", File.ReadAllText("user.txt"), "Delete");
                    DataSet ds2 = new DataSet();
                    ds2 = cb.GetUsername();
                    Cmb_username.DataSource = ds2.Tables[0];
                    Cmb_username.DisplayMember = "username";
                    Cmb_username.ValueMember = "user_id";
                    DataRow dr = ds2.Tables[0].NewRow();
                    dr["username"] = "--Select One--";
                    dr["user_id"] = "0";
                    ds2.Tables[0].Rows.InsertAt(dr, 0);
                    Cmb_username.SelectedIndex = 0;
                    Rb_new.Checked = true;
                }
                catch
                {

                    MessageBox.Show("You Cannot Delete This User.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            Rb_new.Checked = true;
            cmb_accounttype.Focus();
            }
            else
            {
                MessageBox.Show("You Do Not Have The Permission To Delete User", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            UserAccountType u = new UserAccountType();
            u.ShowDialog();

            DataSet ds1 = cb.Getusertype();
            cmb_accounttype.DataSource = ds1.Tables[0];
            cmb_accounttype.DisplayMember = "UserAcc_type";
            cmb_accounttype.ValueMember = "UserAcc_id";
            DataRow dr2 = ds1.Tables[0].NewRow();
            dr2["UserAcc_type"] = "--Select One--";
            dr2["UserAcc_id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr2, 0);
            cmb_accounttype.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_newcategory_Click(object sender, EventArgs e)
        {
            try
            {
            Designation d = new Designation();
            d.ShowDialog();

            DataSet ds = new DataSet();
            ds = cb.GetDesignation();
            cmb_designation.DataSource = ds.Tables[0];
            cmb_designation.DisplayMember = "designation_name";
            cmb_designation.ValueMember = "designation_id";

            DataRow dr = ds.Tables[0].NewRow();
            dr["designation_name"] = "--Select One--";
            dr["designation_id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_designation.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_new.Checked == true)
            {
                Cmb_username.Enabled = false;
                clear();
                cmb_accounttype.Focus();
            }
        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                Cmb_username.Enabled = true;
                clear();
                Cmb_username.Focus();
                Cmb_username.SelectedIndex = 0;
            }
        }

        private void Cmb_username_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (f == 1)
            {
                if (Cmb_username.SelectedIndex != 0)
                {
                    DataTable dt = new DataTable();
                    dt = cb.EditUser(Cmb_username.SelectedValue.ToString());
                    cmb_accounttype.SelectedValue = dt.Rows[0]["acc_type"];
                    txt_username.Text = dt.Rows[0]["username"].ToString();

                    string pass = cb.Decrypt(dt.Rows[0]["password"].ToString(), "Loyal");

                    txt_password.Text =pass ;
                    txt_confrmpassword.Text = pass;

                    txt_name.Text = dt.Rows[0]["name"].ToString();
                    txt_contact.Text = dt.Rows[0]["contact_no"].ToString();
                    cmb_designation.SelectedValue = dt.Rows[0]["designation_id"];
                    button1.Enabled = true;
                }
                else
                {
                    cmb_accounttype.Text = "";
                    txt_username.Text = "";
                    txt_password.Text = "";
                    txt_confrmpassword.Text = "";
                    txt_name.Text = "";
                    txt_contact.Text = "";

                    cmb_designation.Text = "";

                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_accounttype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_username.Focus();
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_confrmpassword.Focus();
            }
        }

        private void txt_confrmpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_name.Focus();
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_contact.Focus();
            }
        }

        private void txt_contact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_designation.Focus();
            }
        }

        private void cmb_designation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bttn_save.Focus();
            }
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void cmb_accounttype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUserRight_Click(object sender, EventArgs e)
        {
            UserRightscs obj = new UserRightscs();
            obj.ShowDialog();
        }
        int k = 0;
        private void bttn_save_Paint(object sender, PaintEventArgs e)
        {

            Color borderDark, borderLight, bgdark, bgmed, bglight, textColor;
            int _roundedRadiusX = 3;
            int _roundedRadiusY = 3;
            if (k == 0)
            {
                //initialization
                //blue button
                borderDark = ColorFromHex("#1f48a1");
                borderLight = ColorFromHex("#4487e4");
                bgdark = ColorFromHex("#2961b5");
                bglight = ColorFromHex("#3e7ddb");
                textColor = Color.White;
            }
            else
            {
                //////yellow button
                borderDark = ColorFromHex("#ecc757");
                borderLight = ColorFromHex("#fcf3d7");
                bgdark = ColorFromHex("#f9e189");
                bglight = ColorFromHex("#fbf9e0");
                textColor = ColorFromHex("#1e395b");
            }
            //now let's we begin painting
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle r = new Rectangle(e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width, e.ClipRectangle.Height);
            Rectangle r2 = r;
            r2.Inflate(-1, -1);
            Rectangle r3 = r2;
            r3.Inflate(-1, -1);

            //clear background first
            using (SolidBrush br = new SolidBrush(Color.FromName("ButtonFace")))
            {
                g.FillRectangle(br, r);
            }

            //rectangle for gradient, half upper and lower
            RectangleF halfup = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            RectangleF halfdown = new RectangleF(r.Left, r.Top + (r.Height / 2) - 1, r.Width, r.Height);

            //BEGIN PAINT BACKGROUND
            //for half upper, we paint using linear gradient
            using (GraphicsPath thePath = GetRoundedRect(r, _roundedRadiusX, _roundedRadiusY))
            {
                LinearGradientBrush lgb =
                    new LinearGradientBrush(halfup, bglight, bgdark, 90f, true);

                Blend blend = new Blend(4);
                blend.Positions = new float[] { 0, 0.18f, 0.35f, 1f };
                blend.Factors = new float[] { 0f, .4f, .9f, 1f };
                lgb.Blend = blend;
                g.FillPath(lgb, thePath);
                lgb.Dispose();

                //for half lower, we paint using radial gradient
                using (GraphicsPath p = new GraphicsPath())
                {
                    p.AddEllipse(halfdown); //make it radial
                    using (PathGradientBrush gradient = new PathGradientBrush(p))
                    {
                        gradient.WrapMode = WrapMode.Clamp;
                        gradient.CenterPoint = new PointF(Convert.ToSingle(halfdown.Left + halfdown.Width / 2), Convert.ToSingle(halfdown.Bottom));
                        gradient.CenterColor = bglight;
                        gradient.SurroundColors = new Color[] { bgdark };

                        blend = new Blend(4);
                        blend.Positions = new float[] { 0, 0.15f, 0.4f, 1f };
                        blend.Factors = new float[] { 0f, .3f, 1f, 1f };
                        gradient.Blend = blend;

                        g.FillPath(gradient, thePath);
                    }
                }
                //END PAINT BACKGROUND
                //BEGIN PAINT BORDERS
                using (GraphicsPath gborderDark = thePath)
                {
                    using (Pen p = new Pen(borderDark, 1))
                    {
                        g.DrawPath(p, gborderDark);
                    }
                }
                using (GraphicsPath gborderLight = GetRoundedRect(r2, _roundedRadiusX, _roundedRadiusY))
                {
                    using (Pen p = new Pen(borderLight, 1))
                    {
                        g.DrawPath(p, gborderLight);
                    }
                }
                using (GraphicsPath gborderMed = GetRoundedRect(r3, _roundedRadiusX, _roundedRadiusY))
                {
                    SolidBrush bordermed = new SolidBrush(Color.FromArgb(50, borderLight));
                    using (Pen p = new Pen(bordermed, 1))
                    {
                        g.DrawPath(p, gborderMed);
                    }
                }
                //END PAINT BORDERS
                //BEGIN PAINT TEXT & Image
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                if (this.ShowKeyboardCues)
                    sf.HotkeyPrefix = HotkeyPrefix.Show;
                else
                    sf.HotkeyPrefix = HotkeyPrefix.Hide;
                g.DrawString((sender as Control).Text, (sender as Control).Font, new SolidBrush(textColor), e.ClipRectangle, sf);
                g.DrawImage(((Button)sender).Image, e.ClipRectangle.Left, e.ClipRectangle.Top);
            }
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

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {
            try
            {
            string Str = txt_contact.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (isNum)
            {

                txt_contact.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(txt_contact.Text), 2, MidpointRounding.AwayFromZero));
                //txt_totalAmount.Text = Convert.ToString(decimal.Round(Convert.ToDecimal((Convert.ToDouble(txt_Quantity.Text)) * (Convert.ToDouble(txt_Rate.Text))), 2, MidpointRounding.AwayFromZero));

                //txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                txt_contact.Select(txt_contact.Text.Length, 0);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_designation_SelectedIndexChanged(object sender, EventArgs e)
        {

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
