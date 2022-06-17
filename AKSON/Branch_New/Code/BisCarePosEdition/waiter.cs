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
    public partial class waiter : Form
    {
        public waiter()
        {
            InitializeComponent();

            // this.DoubleBuffered = true;
        }
        Codebehind obj = new Codebehind();
        public string id;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (radionew.Checked == true)
                {


                    if (SaveStatus == "1")
                    {
                        if (txt_wcode.Text == "")
                        {
                            MessageBox.Show("Please enter waiter code", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (txt_name.Text != "")
                        {


                            byte[] img = new byte[0];
                            string st = obj.insertemp("0", txt_wcode.Text, txt_name.Text, txt_remarks.Text, DateTime.Now, "1", "1", "1", "2", DateTime.Now, "2", "2", "2", "", img, "1");
                            MessageBox.Show("Waiter successfully created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //txt_name.Text = "";
                            //txt_wcode.Text = "";
                            //txt_remarks.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Please enter waiter name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_name.Focus();

                        }
                        


                            if (SaveStatus == "1")
                            {
                               
                                txt_name.Text = "";
                                txt_wcode.Text = "";
                                txt_remarks.Text = "";

                                DataSet ds = new DataSet();
                                ds = obj.GetWaiter();
                                listbox_waiter.DataSource = ds.Tables[0];
                                listbox_waiter.DisplayMember = "Name";
                                listbox_waiter.ValueMember = "Id";

                                //DataRow dr = ds.Tables[0].NewRow();
                                //dr["Waiter"] = "--Select One--";
                                //dr["Id"] = "0";
                                //ds.Tables[0].Rows.InsertAt(dr, 0);
                                //listbox_waiter.SelectedIndex = 0;
                                listbox_waiter.Enabled = true;
                                txt_wcode.Focus();
                            }
                          
                        
                    }

                    else
                    {

                        MessageBox.Show("You Do Not Have The Permission To Save Waiter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (radioediit.Checked == true)
                {
                    if (UpdateStatus == "1")
                    {
                        if (txt_name.Text == "")
                        {
                            MessageBox.Show("Please enter name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_name.Focus();

                        }


                        byte[] img = new byte[0];
                        string st = obj.updatewaiteremp(txt_name.Tag.ToString() ,"0", txt_wcode.Text, txt_name.Text, txt_remarks.Text, DateTime.Now, "1", "1", "1", "2", DateTime.Now, "2", "2", "2", "", img, "2");
                        if (UpdateStatus == "0")
                         {
                             MessageBox.Show("waiter name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                         else
                            if (UpdateStatus == "1")
                             {
                                 MessageBox.Show("waiter Updated successfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 txt_wcode.Text = "";
                                 txt_name.Text = "";
                                 txt_remarks.Text = "";
                                 DataSet ds = new DataSet();
                                 ds = obj.GetWaiter();
                                 listbox_waiter.DataSource = ds.Tables[0];
                                 listbox_waiter.DisplayMember = "Name";
                                 listbox_waiter.ValueMember = "Id";

                                 txt_wcode.Focus();
                             }
                        else
                             {

                                 MessageBox.Show("You Do Not Have The Permission To Update Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                             }















                    }
                }
            }

            
          




            //else
            //{

            //    if (radioediit.Checked == true)
            //    {
            //        if (UpdateStatus == "1")
            //        {
            //            if (txt_name.Text == "")
            //            {
            //                MessageBox.Show("Please enter name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                txt_name.Focus();

            //            }
            //            else
            //            {
            //                byte[] img = new byte[0];
            //                string st = obj.updatewaiteremp("0", txt_wcode.Text, txt_name.Text, txt_remarks.Text, DateTime.Now, "1", "1", "1", "2", DateTime.Now, "2", "2", "2", "", img,"2");

            //                if (st == "0")
            //                {
            //                    MessageBox.Show("waiter name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //                else
            //                    if (st == "1")
            //                    {
            //                        MessageBox.Show("waiter Updated successfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                        txt_name.Text = "";
            //                        txt_remarks.Text = "";
            //                        DataSet ds = new DataSet();
            //                        ds = obj.GetWaiter();
            //                        listbox_waiter.DataSource = ds.Tables[0];
            //                        listbox_waiter.DisplayMember = "Name";
            //                        listbox_waiter.ValueMember = "Id";

            //                        txt_wcode.Focus();
            //                    }
            //            }
            //        }




            //        else
            //        {

            //            MessageBox.Show("You Do Not Have The Permission To Update Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        }
            //    }
            //}





















            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }private void btn_save_Paint(object sender, PaintEventArgs e)
        {

        }

        int k = 0;
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
        private void waiter_Load(object sender, EventArgs e)
        {
            txt_wcode.Focus();
            try
            {
                ApplyTheme();
                DataTable dt1 = new DataTable();
                dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Waiter");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                this.ActiveControl = txt_name;
                DataSet ds = new DataSet();
                ds = obj.GetWaiter();
                listbox_waiter.DataSource = ds.Tables[0];
                listbox_waiter.DisplayMember = "Name";
                listbox_waiter.ValueMember = "Id";

                //DataRow dr = ds.Tables[0].NewRow();
                //dr["Waiter"] = "--Select One--";
                //dr["Id"] = "0";
                //ds.Tables[0].Rows.InsertAt(dr, 0);
                //listbox_waiter.SelectedIndex = 0;
                listbox_waiter.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteStatus == "1")
                {
                    if (listbox_waiter.Items.Count > 0)
                    {
                        string st = obj.DeleteWaiter(listbox_waiter.SelectedValue.ToString());
                        if (st == "0")
                        {
                            MessageBox.Show("Sorry,this waiter already used.So you cannot delete it", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Waiter deleted sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataSet ds = new DataSet();
                            ds = obj.GetWaiter();
                            listbox_waiter.DataSource = ds.Tables[0];
                            listbox_waiter.DisplayMember = "Name";
                            listbox_waiter.ValueMember = "Name";

                            //DataRow dr = ds.Tables[0].NewRow();
                            //dr["Waiter"] = "--Select One--";
                            //dr["Id"] = "0";
                            //ds.Tables[0].Rows.InsertAt(dr, 0);
                            //listbox_waiter.SelectedIndex = 0;
                            listbox_waiter.Enabled = true;
                            listbox_waiter.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a waiter for delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_name.Focus();
                    }
                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Delete Waiter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_remarks.Focus();
            }
        }

        private void txt_remarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void listbox_waiter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_delete.Focus();
            }
        }

        private void radioediit_CheckedChanged(object sender, EventArgs e)
        {
            if (radionew.Checked == true)
            {
                //cmb_tax.Enabled = true;
                //Btn_Delete.Enabled = true;
                txt_wcode.Focus();
                txt_name.Text = "";
                txt_remarks.Text = "";
                txt_wcode.Text = "";
            }
            else
            {
                //cmb_tax.Enabled = false;
             
                txt_wcode.Focus();
            }
        }

        private void radionew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                radioediit.Focus();
            }
        }

        private void radioediit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_wcode.Focus();
            }
        }

        private void txt_wcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_name.Focus();

            }






        }

        private void Waiter_Load_1(object sender, EventArgs e)
        {
            txt_wcode.Focus();
            try
            {
                ApplyTheme();
                DataTable dt1 = new DataTable();
                dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Waiter");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                this.ActiveControl = txt_name;
                DataSet ds = new DataSet();
                ds = obj.GetWaiter();
                listbox_waiter.DataSource = ds.Tables[0];
                listbox_waiter.DisplayMember = "Name";
                listbox_waiter.ValueMember = "Name";

                //DataRow dr = ds.Tables[0].NewRow();
                //dr["Waiter"] = "--Select One--";
                //dr["Id"] = "0";
                //ds.Tables[0].Rows.InsertAt(dr, 0);
                //listbox_waiter.SelectedIndex = 0;
                listbox_waiter.Enabled = true;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    if (DeleteStatus == "1")
                    {
                        if (listbox_waiter.Items.Count > 0)
                        {
                            string st = obj.DeleteWaitername(listbox_waiter.SelectedValue.ToString());
                            if (st == "0")
                            {
                                MessageBox.Show("Sorry,this waiter already used.So you cannot delete it", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Waiter deleted sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DataSet ds = new DataSet();
                                ds = obj.GetWaiter();
                                listbox_waiter.DataSource = ds.Tables[0];
                                listbox_waiter.DisplayMember = "Name";
                                listbox_waiter.ValueMember = "Id";

                                //DataRow dr = ds.Tables[0].NewRow();
                                //dr["Waiter"] = "--Select One--";
                                //dr["Id"] = "0";
                                //ds.Tables[0].Rows.InsertAt(dr, 0);
                                //listbox_waiter.SelectedIndex = 0;
                                listbox_waiter.Enabled = true;
                                listbox_waiter.Focus();
                                txt_name.Text = "";
                                txt_remarks.Text = "";
                                txt_wcode.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a waiter for delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_name.Focus();
                        }
                    }
                    else
                    {

                        MessageBox.Show("You Do Not Have The Permission To Delete Waiter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
                }
            }
        }

        private void waiter_Load_2(object sender, EventArgs e)
        {

            try
            {
                ApplyTheme();
                DataTable dt1 = new DataTable();
                dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Waiter");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                this.ActiveControl = txt_wcode;
                DataSet ds = new DataSet();
                ds = obj.GetWaiter();
                listbox_waiter.DataSource = ds.Tables[0];
                listbox_waiter.DisplayMember = "Name";
                listbox_waiter.ValueMember = "Id";

                //DataRow dr = ds.Tables[0].NewRow();
                //dr["Waiter"] = "--Select One--";
                //dr["Id"] = "0";
                //ds.Tables[0].Rows.InsertAt(dr, 0);
                //listbox_waiter.SelectedIndex = 0;
                listbox_waiter.Enabled = true;
                txt_wcode.Focus();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        string empcode, remarks;
        private void listbox_waiter_DoubleClick(object sender, EventArgs e)
        {
           
            if (radioediit.Checked == true)
            {
                DataTable dt = new DataTable();
                //dt = obj.getwaitername();
                dt = obj.getwaitername(listbox_waiter.Text);
                if (dt.Rows.Count > 0)
                {
                    txt_name.Tag = dt.Rows[0]["id"].ToString();
                    txt_wcode.Text = dt.Rows[0]["EmpCode"].ToString();
                    txt_name.Text = dt.Rows[0]["Name"].ToString();

                   txt_remarks.Text = dt.Rows[0]["remarks"].ToString();

                }


            }
        }

        private void txt_wcode_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_name.Focus();

            }


        }

        private void txt_name_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_remarks.Focus();
            }

        }

        private void listbox_waiter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radionew_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
   


