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
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


private void btn_save_Click(object sender, EventArgs e)
{

          try
            {
                if (radioNew.Checked == true)
                {


                    if (SaveStatus == "1")
                    {
                        if (txt_name.Text == "")
                        {
                            MessageBox.Show("Please enter table name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_name.Focus();
                        }
                        else
                        {
                            int ACStatus = 1;
                            if (rbtnNonAc.Checked == true)
                            {
                                ACStatus = 0;
                            }
                            string st = obj.SaveTable(txt_name.Text, txt_remarks.Text, ACStatus.ToString());
                            if (st == "0")
                            {
                                MessageBox.Show("Table name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (st == "1")
                                {
                                    MessageBox.Show("Table successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_name.Text = "";
                                    txt_remarks.Text = "";
                                    DataSet ds = new DataSet();
                                    ds = obj.GetTable();
                                    listbox_tables.DataSource = ds.Tables[0];
                                    listbox_tables.DisplayMember = "TableName";
                                    listbox_tables.ValueMember = "Id";

                                    //DataRow dr = ds.Tables[0].NewRow();
                                    //dr["TableName"] = "--Select One--";
                                    //dr["Id"] = "0";
                                    //ds.Tables[0].Rows.InsertAt(dr, 0);
                                    //listbox_tables.SelectedIndex = 0;
                                    txt_name.Focus();
                                }
                            }
                        }
                    }
                    else
                    {

                        MessageBox.Show("You Do Not Have The Permission To Save Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (radioEdit.Checked == true)
                {
                    if (UpdateStatus == "1")
                    {
                       if (txt_name.Text == "")
                        {
                            MessageBox.Show("Please enter table name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_name.Focus();
                        }
                        else
                        {
                            int ACStatus = 1;
                            if (rbtnNonAc.Checked == true)
                            {
                                ACStatus = 0;
                            }
                            string st = obj.UpdateTable(txt_name.Text, txt_remarks.Text, ACStatus.ToString(),txt_name.Tag.ToString());
                            if (st == "0")
                            {
                                MessageBox.Show("Table name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (st == "1")
                                {
                                    MessageBox.Show("Table Updated successfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_name.Text = "";
                                    txt_remarks.Text = "";
                                    DataSet ds = new DataSet();
                                    ds = obj.GetTable();
                                    listbox_tables.DataSource = ds.Tables[0];
                                    listbox_tables.DisplayMember = "TableName";
                                    listbox_tables.ValueMember = "Id";
                                    txt_name.Focus();
                                }
                            }
                        }
                    }
                    else
                    {

                        MessageBox.Show("You Do Not Have The Permission To Update Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    }
                }
       
      
   
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        //private void btn_save_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (SaveStatus == "1")
        //        {
        //            if (txt_name.Text == "")
        //            {
        //                MessageBox.Show("Please enter table name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                txt_name.Focus();
        //            }
        //            else
        //            {
        //                int ACStatus = 1;
        //                if (rbtnNonAc.Checked == true)
        //                {
        //                    ACStatus = 0;
        //                }
        //                string st = obj.SaveTable(txt_name.Text, txt_remarks.Text, ACStatus.ToString());
        //                if (st == "0")
        //                {
        //                    MessageBox.Show("Table name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //                else
        //                {
        //                    if (st == "1")
        //                    {
        //                        MessageBox.Show("Table successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        txt_name.Text = "";
        //                        txt_remarks.Text = "";
        //                        DataSet ds = new DataSet();
        //                        ds = obj.GetTable();
        //                        listbox_tables.DataSource = ds.Tables[0];
        //                        listbox_tables.DisplayMember = "TableName";
        //                        listbox_tables.ValueMember = "Id";

        //                        //DataRow dr = ds.Tables[0].NewRow();
        //                        //dr["TableName"] = "--Select One--";
        //                        //dr["Id"] = "0";
        //                        //ds.Tables[0].Rows.InsertAt(dr, 0);
        //                        //listbox_tables.SelectedIndex = 0;
        //                        txt_name.Focus();
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {

        //            MessageBox.Show("You Do Not Have The Permission To Save Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
        //    }
        //}
        int k=0;
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
        private void Tables_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Table");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

            this.ActiveControl = txt_name;
            DataSet ds = new DataSet();
            ds = obj.GetTable();
            listbox_tables.DataSource = ds.Tables[0];
            listbox_tables.DisplayMember = "TableName";
            listbox_tables.ValueMember = "Id";

            //DataRow dr = ds.Tables[0].NewRow();
            //dr["TableName"] = "--Select One--";
            //dr["Id"] = "0";
            //ds.Tables[0].Rows.InsertAt(dr, 0);
            //listbox_tables.SelectedIndex = 0;
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
                if (listbox_tables.Items.Count>0)
                {
                    string st = obj.DeletTable(listbox_tables.SelectedValue.ToString());
                    if (st == "0")
                    {
                       
                        MessageBox.Show("Sorry,this table already used.So you cannot delete it", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_name.Text = "";
                        txt_remarks.Text = "";
                    }
                    else
                    {
                        
                        MessageBox.Show("Table deleted sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_name.Text = "";
                        txt_remarks.Text = "";
                        DataSet ds = new DataSet();
                        ds = obj.GetTable();
                        listbox_tables.DataSource = ds.Tables[0];
                        listbox_tables.DisplayMember = "TableName";
                        listbox_tables.ValueMember = "Id";

                        //DataRow dr = ds.Tables[0].NewRow();
                        //dr["TableName"] = "--Select One--";
                        //dr["Id"] = "0";
                        //ds.Tables[0].Rows.InsertAt(dr, 0);
                        //listbox_tables.SelectedIndex = 0;
                        listbox_tables.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a table for delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_name.Focus();
                }
            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete Table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void listbox_tables_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void listbox_tables_DoubleClick(object sender, EventArgs e)
        {
              if (radioEdit.Checked == true)
            {
                DataTable dt = new DataTable();
               
                 dt = obj.GetTableDetails(listbox_tables.Text);
                if (dt.Rows.Count > 0)
                {

                    txt_name.Text = dt.Rows[0]["TableName"].ToString();
                    txt_remarks.Text = dt.Rows[0]["Remarks"].ToString();
                    string acStatus = dt.Rows[0]["ACStatus"].ToString();
                    txt_name.Tag = dt.Rows[0]["id"].ToString();
                    if (acStatus == "1")
                    {
                        rbtnAC.Checked = true;
                        rbtnNonAc.Checked = false;
                    }
                    else
                    {
                        rbtnNonAc.Checked = true;
                        rbtnAC.Checked = false;
                    }
                   

                }
               

            }
           
        }

        private void listbox_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void radioNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNew.Checked == true)
            {
                txt_name.Text = "";
                txt_remarks.Text = "";
            }

        }

        private void radioEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEdit.Checked == true)
            {
                txt_name.Text = "";
                txt_remarks.Text = "";

            }
        }

        private void rbtnAC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAC.Checked == true)
            {
                rbtnNonAc.Checked = false;
            }
        }

        private void rbtnNonAc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNonAc.Checked == true)
            {
                rbtnAC.Checked = false;
            }
        }








        }
    }

