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
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }
        //Codebehind obj = new Codebehind();
        Codebehind ObjCode = new Codebehind();
         public string userid,na;
        private void CloseOpenForms()
        {

            // Close all open forms - except for the main form.  (This is usually OpenForms[0].
            // Closing a form decrmements the OpenForms count
            while (Application.OpenForms.Count > 1)
            {
                Application.OpenForms[Application.OpenForms.Count - 1].Close();
                
            }
        }

        private void bttn_bankTrans_Click(object sender, EventArgs e)
        {

        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (keyData == Keys.B)
            //{
            //    CloseOpenForms();
            //    Billing Obj = new Billing();

            //    Obj.Show();
            //}
            if (keyData == Keys.F2)
            {
                CloseOpenForms();
                Billing Obj = new Billing();
                //Obj.TopLevel = false;
                //Obj.AutoScroll = true;
                //splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == Keys.F3)
            {
                CloseOpenForms();
                PendingOT_S Obj = new PendingOT_S();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == Keys.F4)
            {
                CloseOpenForms();
                DeleteKot Obj = new DeleteKot();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();

            }
            if (keyData == Keys.F5)
            {
                CloseOpenForms();
                SearchBill Obj = new SearchBill();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == Keys.F6)
            {
                CloseOpenForms();
                DeleteBill Obj = new DeleteBill();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == Keys.F7)
            {
                CloseOpenForms();
                Item Obj = new Item();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            //if(keyData==Keys.F5)
            if (keyData == (Keys.Control | Keys.I))
            {
                CloseOpenForms();
                OtherIncomeNew Obj = new OtherIncomeNew();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == (Keys.Control | Keys.E))
            {
                CloseOpenForms();
                OtherExpences Obj = new OtherExpences();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                CloseOpenForms();
                StockEntry Obj = new StockEntry();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.C))
            {
                CloseOpenForms();
                ClearTransactions Obj = new ClearTransactions();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.B))
            {
                CloseOpenForms();
                BackupDB Obj = new BackupDB();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == (Keys.Control | Keys.Alt | Keys.Shift | Keys.R))
            {
                CloseOpenForms();
                ResetDB Obj = new ResetDB();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.R))
            {
                CloseOpenForms();
                RestoreDB Obj = new RestoreDB();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void bttn_Administration_Click(object sender, EventArgs e)
        {
            SetBackColor();
            bttn_Administration.BackColor = Color.Black;
            Gbox_Admin1.Visible = true;
            Gbox_Activities1.Visible = false;
            //grpBdr1.Visible = false;
            Gbox_Finance1.Visible = false;
            Gbox_Master1.Visible = false;
            Gbox_Reports1.Visible = false;
        }

        private void bttn_Masters_Click(object sender, EventArgs e)
        {
            SetBackColor();
            bttn_Masters.BackColor = Color.Black;
            Gbox_Master1.Visible = true;
            Gbox_Activities1.Visible = false;
            Gbox_Admin1.Visible = false;
            Gbox_Finance1.Visible = false;
            //grpBdr1.Visible = false;
            Gbox_Reports1.Visible = false;
        }

        private void bttn_Finance_Click(object sender, EventArgs e)
        {
            SetBackColor();
            bttn_Finance.BackColor = Color.Black;
            Gbox_Activities1.Visible = false;
            Gbox_Admin1.Visible = false;
            Gbox_Finance1.Visible = true;
            Gbox_Master1.Visible = false;
            Gbox_Reports1.Visible = false;
            // grpBdr1.Visible = false;
        }

        private void bttn_activities_Click(object sender, EventArgs e)
        {
            SetBackColor();
            bttn_activities.BackColor = Color.Black;
            Gbox_Activities1.Visible = true;
            Gbox_Admin1.Visible = false;
            Gbox_Finance1.Visible = false;
            Gbox_Master1.Visible = false;
            Gbox_Reports1.Visible = false;
            //grpBdr1.Visible = false;
        }

        private void bttn_reprt_Click(object sender, EventArgs e)
        {
            SetBackColor();
            bttn_reprt.BackColor = Color.Black;
            Gbox_Activities1.Visible = false;
            Gbox_Admin1.Visible = false;
            Gbox_Finance1.Visible = false;
            Gbox_Master1.Visible = false;
            Gbox_Reports1.Visible = true;
            //grpBdr1.Visible = false;
        }

        //private void bttn_BDR_Click(object sender, EventArgs e)
        //{
        //    SetBackColor();
        //    //bttn_BDR.BackColor = Color.Black;   
        //    Gbox_Activities1.Visible = false;
        //    Gbox_Admin1.Visible = false;
        //    Gbox_Finance1.Visible = false;
        //    Gbox_Master1.Visible = false;
        //    Gbox_Reports1.Visible = false;
        //    grpBdr1.Visible = true;
        //}
        int LogoutStat = 0;

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

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }
        private void Home1_Load(object sender, EventArgs e)
        {
            Theme ObjTheme = new Theme();
            ObjTheme.setTheme();
            ApplyTheme();
            SetBackColor();
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            //button4.BackColor = Color.Black;
            //button4.ForeColor = Color.White;
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            Gbox_Activities1.Visible = true;
            bttn_activities.BackColor = Color.Black;
            Gbox_Admin1.Visible = false;
            Gbox_Finance1.Visible = false;
            Gbox_Master1.Visible = false;
            Gbox_Reports1.Visible = false;
            //grpBdr1.Visible = false;          
        }

        private void Home1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (LogoutStat == 0)
                {
                    userid = File.ReadAllText("user.txt");
                    int counterid = Convert.ToInt32(File.ReadAllText("counter.txt"));
                    ObjCode.updatelogin(userid, DateTime.Now,DateTime.Now , counterid, "changestatus");//Convert.ToDateTime(globalvariable.StoreDate)
                    //if (msg == "1")
                    //{
                    //    this.Close();
                    //}
                    //else
                        this.Close();
                    //MessageBox.Show(msg);
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Gbox_Admin_Enter(object sender, EventArgs e)
        {

        }
        public void SetBackColor()
        {
            bttn_Administration.BackColor = Color.FromArgb(Convert.ToInt32(Theme.MBBackColor));
            bttn_Masters.BackColor = Color.FromArgb(Convert.ToInt32(Theme.MBBackColor));
            bttn_Finance.BackColor = Color.FromArgb(Convert.ToInt32(Theme.MBBackColor));
            bttn_activities.BackColor = Color.FromArgb(Convert.ToInt32(Theme.MBBackColor));
            bttn_reprt.BackColor = Color.FromArgb(Convert.ToInt32(Theme.MBBackColor));
            //bttn_BDR.BackColor = Color.FromArgb(Convert.ToInt32(Theme.MBBackColor));
            bttn_logout.BackColor = Color.FromArgb(Convert.ToInt32(Theme.MBBackColor));

            bttn_Administration.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.MBForeColor));
            bttn_Masters.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.MBForeColor));
            bttn_Finance.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.MBForeColor));
            bttn_activities.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.MBForeColor));
            bttn_reprt.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.MBForeColor));
            //bttn_BDR.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.MBForeColor));
            bttn_logout.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.MBForeColor));

            if (Theme.MBFlatStyle == "Flat")
            {
                bttn_Administration.FlatStyle = FlatStyle.Flat;
                bttn_Masters.FlatStyle = FlatStyle.Flat;
                bttn_Finance.FlatStyle = FlatStyle.Flat;
                bttn_activities.FlatStyle = FlatStyle.Flat;
                bttn_reprt.FlatStyle = FlatStyle.Flat;
                //bttn_BDR.FlatStyle = FlatStyle.Flat;
                bttn_logout.FlatStyle = FlatStyle.Flat;
            }
            if (Theme.MBFlatStyle == "Standard")
            {
                bttn_Administration.FlatStyle = FlatStyle.Standard;
                bttn_Masters.FlatStyle = FlatStyle.Standard;
                bttn_Finance.FlatStyle = FlatStyle.Standard;
                bttn_activities.FlatStyle = FlatStyle.Standard;
                bttn_reprt.FlatStyle = FlatStyle.Standard;
                // bttn_BDR.FlatStyle = FlatStyle.Standard;
                bttn_logout.FlatStyle = FlatStyle.Standard;
            }
            if (Theme.MBFlatStyle == "Pop up")
            {
                bttn_Administration.FlatStyle = FlatStyle.Popup;
                bttn_Masters.FlatStyle = FlatStyle.Popup;
                bttn_Finance.FlatStyle = FlatStyle.Popup;
                bttn_activities.FlatStyle = FlatStyle.Popup;
                bttn_reprt.FlatStyle = FlatStyle.Popup;
                //bttn_BDR.FlatStyle = FlatStyle.Popup;
                bttn_logout.FlatStyle = FlatStyle.Popup;
            }
            if (Theme.MBFlatStyle == "System")
            {
                bttn_Administration.FlatStyle = FlatStyle.System;
                bttn_Masters.FlatStyle = FlatStyle.System;
                bttn_Finance.FlatStyle = FlatStyle.System;
                bttn_activities.FlatStyle = FlatStyle.System;
                bttn_reprt.FlatStyle = FlatStyle.System;
                //bttn_BDR.FlatStyle = FlatStyle.System;
                bttn_logout.FlatStyle = FlatStyle.System;
            }

            bttn_Administration.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.MBMouseOvr));
            bttn_Masters.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.MBMouseOvr));
            bttn_Finance.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.MBMouseOvr));
            bttn_activities.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.MBMouseOvr));
            bttn_reprt.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.MBMouseOvr));
            //bttn_BDR.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.MBMouseOvr));
            bttn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.MBMouseOvr));
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DialogResult dr = MessageBox.Show("You Are About to Logout. Do You Wish To Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    userid = File.ReadAllText("user.txt");
                   int counterid = Convert.ToInt32(File.ReadAllText("counter.txt"));
                    ObjCode.updatelogin(userid, DateTime.Now,DateTime.Now, counterid, "changestatus"); //Convert.ToDateTime(globalvariable.StoreDate)
                    //if (msg == "1")
                    //{
                    //    LogoutStat = 1;
                    //    this.Close();
                    //}
                    //else
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestaurent_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Restuarant");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        if ((Application.OpenForms["Restuarant"] as Restuarant) == null)
                        {
                            Restuarant Obj = new Restuarant();
                            Obj.TopLevel = false;
                            Obj.AutoScroll = true;
                            splitContainer1.Panel2.Controls.Add(Obj);
                            Obj.Show();
                        }
                        else
                        {
                            Application.OpenForms["Restuarant"].Focus();


                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnInvcNosettings_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Setting");
                if (dt.Rows.Count > 0)
                {
                    //if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    //{
                    //    Settings Obj = new Settings();
                    //    Obj.MdiParent = this;
                    //    Obj.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Counter");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        if ((Application.OpenForms["Counter"] as Counter) == null)
                        {
                            Counter Obj = new Counter();
                            Obj.TopLevel = false;
                            Obj.AutoScroll = true;
                            splitContainer1.Panel2.Controls.Add(Obj);
                            Obj.Show();
                        }
                        else
                        {
                            Application.OpenForms["Counter"].Focus();


                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnUserAccType_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "UserAccountType");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        if ((Application.OpenForms["UserAccountType"] as UserAccountType) == null)
                        {
                            UserAccountType Obj = new UserAccountType();
                            Obj.TopLevel = false;
                            Obj.AutoScroll = true;
                            splitContainer1.Panel2.Controls.Add(Obj);
                            Obj.Show();
                        }
                        else
                        {
                            Application.OpenForms["UserAccountType"].Focus();


                        }

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnDesignation_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Designation");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        if ((Application.OpenForms["Designation"] as Designation) == null)
                        {
                            Designation Obj = new Designation();
                            Obj.TopLevel = false;
                            Obj.AutoScroll = true;
                            splitContainer1.Panel2.Controls.Add(Obj);
                            Obj.Show();
                        }
                        else
                        {
                            Application.OpenForms["Designation"].Focus();


                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "User");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        if ((Application.OpenForms["User"] as User) == null)
                        {
                            User Obj = new User();
                            Obj.TopLevel = false;
                            Obj.AutoScroll = true;
                            splitContainer1.Panel2.Controls.Add(Obj);
                            Obj.Show();
                        }
                        else
                        {
                            Application.OpenForms["User"].Focus();


                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ChangePassword");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        if ((Application.OpenForms["PasswordChange"] as PasswordChange) == null)
                        {
                            PasswordChange Obj = new PasswordChange();
                            Obj.TopLevel = false;
                            Obj.AutoScroll = true;
                            splitContainer1.Panel2.Controls.Add(Obj);
                            Obj.Show();
                        }
                        else
                        {
                            Application.OpenForms["PasswordChange"].Focus();


                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnUserRights_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "UserRights");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        if ((Application.OpenForms["UserRightscs"] as UserRightscs) == null)
                        {
                            UserRightscs Obj = new UserRightscs();
                            Obj.TopLevel = false;
                            Obj.AutoScroll = true;
                            splitContainer1.Panel2.Controls.Add(Obj);
                            Obj.Show();
                        }
                        else
                        {
                            Application.OpenForms["UserRightscs"].Focus();


                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnClearTransactions_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ClearTransactions");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        DialogResult dr = MessageBox.Show("This will clear all your Transactions. Do you wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            // obj.ClearTrnsactions();
                            ClearTransactions ct = new ClearTransactions();
                            ct.ShowDialog();

                            //MessageBox.Show("Transactions successfully cleared.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnBakup_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "BackUp");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        if ((Application.OpenForms["BackupDB"] as BackupDB) == null)
                        {
                            BackupDB Obj = new BackupDB();
                            Obj.TopLevel = false;
                            Obj.AutoScroll = true;
                            splitContainer1.Panel2.Controls.Add(Obj);
                            Obj.Show();
                        }
                        else
                        {
                            Application.OpenForms["BackupDB"].Focus();


                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ResetDB");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        DialogResult dgResult = MessageBox.Show("This Will Erase All Your Data. Do You Want To Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dgResult == DialogResult.Yes)
                        {
                            ResetDB Rdb = new ResetDB();

                            Rdb.ShowDialog();
                            if (Rdb.Dr == DialogResult.OK)
                                this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Restore");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        if ((Application.OpenForms["RestoreDB"] as RestoreDB) == null)
                        {
                            RestoreDB Obj = new RestoreDB();
                            // Obj.MdiParent = this;
                            Obj.ShowDialog();
                            if (Obj.dr == DialogResult.OK)
                                this.Close();
                        }
                        else
                        {
                            Application.OpenForms["RestoreDB"].Focus();


                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnThemeRoller_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ThemeRoller");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        ThemeRoller ObjTheme = new ThemeRoller();
                        ObjTheme.ShowDialog();
                        ApplyTheme();
                        SetBackColor();
                        button1.BackColor = Color.Black;
                        button1.ForeColor = Color.White;
                        button2.BackColor = Color.Black;
                        button2.ForeColor = Color.White;
                        button3.BackColor = Color.Black;
                        button3.ForeColor = Color.White;
                        //button4.BackColor = Color.Black;
                        //button4.ForeColor = Color.White;
                        button5.BackColor = Color.Black;
                        button5.ForeColor = Color.White;
                        button6.BackColor = Color.Black;
                        button6.ForeColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Brand");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        Brand Obj = new Brand();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Category");
                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        Category Obj = new Category();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnItemMaster_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Item");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        Item Obj = new Item();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnRecipeManager_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ItemMapping");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        item_mapping Obj = new item_mapping();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Table");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {
                        Tables Obj = new Tables();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Waiter");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        waiter Obj = new waiter();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.WindowState = FormWindowState.Minimized;
                        Obj.Show();
                        Obj.WindowState = FormWindowState.Normal;

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Unit");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        Unit Obj = new Unit();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "StockEntry");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        StockEntry Obj = new StockEntry();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Billing");
                if (dt.Rows.Count > 0)
                {
                    if ((dt.Rows[0][1].ToString() == "1"))
                    {
                        Billing Obj = new Billing();
                        //   Obj.MdiParent = this;
                        Obj.Show();
                    }

                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnPendingKOT_Click(object sender, EventArgs e)
        {

            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "PendingKOT");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        PendingOT_S Obj = new PendingOT_S();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnDeleteKOT_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeleteKOT");
                if (dt.Rows.Count > 0)
                {

                    if ((Application.OpenForms["DeleteKot"] as DeleteKot) == null)
                    {
                        DeleteKot Obj = new DeleteKot();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeleteBill");
                if (dt.Rows.Count > 0)
                {

                    if ((Application.OpenForms["DeleteBill"] as DeleteBill) == null)
                    {
                        DeleteBill Obj = new DeleteBill();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnTouchBilling_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    CloseOpenForms();
            //    DataTable dt = new DataTable();
            //    dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeleteBill");
            //    if (dt.Rows.Count > 0)
            //    {

            //        if ((Application.OpenForms["DeleteBill"] as DeleteBill) == null)
            //        {
            //             Obj = new DeleteBill();
            //            Obj.TopLevel = false;
            //            Obj.AutoScroll = true;
            //            splitContainer1.Panel2.Controls.Add(Obj);
            //            Obj.Show();

            //        }
            //        else
            //        {
            //            MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            //}
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                SearchBill Obj = new SearchBill();
                Obj.TopLevel = false;
                Obj.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(Obj);
                Obj.Show();

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void BtnTAX_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Tax");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        Tax Obj = new Tax();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnOtherIncome_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OtherIncome");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        OtherIncomeNew Obj = new OtherIncomeNew();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnOtherExpense_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OtherExpence");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        OtherExpences Obj = new OtherExpences();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "SalesReport");
                if (dt.Rows.Count > 0)
                {

                    if ((Application.OpenForms["SalesReport"] as SalesReport) == null)
                    {
                        SalesReport Obj = new SalesReport();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "SalesReportByDate");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        SalesReportByDate Obj = new SalesReportByDate();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnDeletedInvc_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeletedInvoiceReport");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        DeletedInvoiceReportShort Obj = new DeletedInvoiceReportShort();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnDeletedInvcDetailed_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeletedInvoiceReportDetaile");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        DeletedInvoiceReport Obj = new DeletedInvoiceReport();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnDeletedKOT_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeletedKOTRepot");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        ReportDeletedKotDetails Obj = new ReportDeletedKotDetails();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnOtherExpenseRprt_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OtherExpenceReport");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        ReportOtherExpence Obj = new ReportOtherExpence();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnOtherIncomeRprt_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OtherIncomeReport");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {


                        ReportOtherIncome Obj = new ReportOtherIncome();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnStockRprt_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "StockReport");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        Stock Obj = new Stock();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.Show();

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Employee");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    Employee obj = new Employee();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReportPayable_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "PayableReceivableReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    ReportPayableRecievable obj = new ReportPayableRecievable();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnbankTransaction_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "BankTransaction");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    BankTrnsaction obj = new BankTrnsaction();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Customer");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    Customer obj = new Customer();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Dealer_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Dealer");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    Dealer obj = new Dealer();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_grn_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "GoodsReceipt");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    StockEntry obj = new StockEntry();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Designation_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Designation");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    Designation obj = new Designation();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_bak_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Bank");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    Bank obj = new Bank();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_tax_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "tax");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    Tax obj = new Tax();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_old_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "OldPayableReceivable");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    OldPayableReceivable obj = new OldPayableReceivable();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ReceiptVoucher");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    PaymentVoucher obj = new PaymentVoucher();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                     MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Reciept_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "PaymentVoucher");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    ReceiptVoucher obj = new ReceiptVoucher();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_BankTrns_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "BankTrnsaction");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    ReportBankTransaction obj = new ReportBankTransaction();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbtn_daybook_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "BankTrnsaction");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    DayBook obj = new DayBook();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeletePassword");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    DeletePasswordChange obj = new DeletePasswordChange();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPurchaseReport_Click(object sender, EventArgs e)
        {
            
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeletePassword");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    ReportGoodsRec obj = new ReportGoodsRec();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ProductStockEntry_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ProductStock");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    ProductStock obj = new ProductStock();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_DamageEntry_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ProductDamageEntry");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    ProductDamageEntry obj = new ProductDamageEntry();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProductStockReport_Click(object sender, EventArgs e)
        {

            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "ProductStockReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    ProductStockReport obj = new ProductStockReport();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_DiscountReport_Click(object sender, EventArgs e)
        {

            CloseOpenForms();
            DataTable dt = new DataTable();
            dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DiscountReport");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                {
                    DiscountReport obj = new DiscountReport();
                    obj.TopLevel = false;
                    obj.AutoScroll = true;
                    splitContainer1.Panel2.Controls.Add(obj);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Waiter_Click(object sender, EventArgs e)
        {
            
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Waiter");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        waiter Obj = new waiter();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.WindowState = FormWindowState.Minimized;
                        Obj.Show();
                        Obj.WindowState = FormWindowState.Normal;

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        

        }

        private void btndepartment_Click(object sender, EventArgs e)
        {
            try
            {
                CloseOpenForms();
                DataTable dt = new DataTable();
                dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "Department");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                    {

                        Department Obj = new Department();
                        Obj.TopLevel = false;
                        Obj.AutoScroll = true;
                        splitContainer1.Panel2.Controls.Add(Obj);
                        Obj.WindowState = FormWindowState.Minimized;
                        Obj.Show();
                        Obj.WindowState = FormWindowState.Normal;

                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You Have No Rights To Enter This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        

        

        }

        private void btn_printingfeatures_Click(object sender, EventArgs e)
        {
            Billing_Features bf = new Billing_Features();
            bf.ShowDialog();
        }

        private void btn_touch_Click(object sender, EventArgs e)
        {
            TouchBilling ts = new TouchBilling();
                ts.ShowDialog();
        }

        private void btn_dynamic_Click(object sender, EventArgs e)
        {
            Home_page fd = new Home_page();
            fd.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       




        
    }
}

    

