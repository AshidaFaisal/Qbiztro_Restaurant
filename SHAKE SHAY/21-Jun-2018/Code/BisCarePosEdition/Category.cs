using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;

namespace BisCarePosEdition
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            Rb_new.Checked = true;
            Rb_edit.Checked = false;
            rd_Product.Checked = true;
        }

        Codebehind cb = new Codebehind();
        //int mode = 0;
        int f = 0;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        public  void loadcombo()
        {
            
            DataSet ds = new DataSet();
            ds = cb.GetCategory(1);
            cmb_category.DataSource = ds.Tables[0];
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["Name"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_category.SelectedIndex = 0;
            f = 1;

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear()
        {
            //f = 0;
            pb_photo.Image = null;
            pb_photo.Refresh();
            string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
            pb_photo.ImageLocation = FilePath;
            pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        byte[] img;
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if (Rb_new.Checked == true)
            {
                if (openFileDialog1.FileName == "" || openFileDialog1.FileName=="openFileDialog1")
                {
                    string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                    FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                    img = new byte[FS.Length];
                    FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    pb_photo.ImageLocation = FilePath;
                    pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                    if (openFileDialog1.FileName != "")
                    {
                        FileStream FS = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        img = new byte[FS.Length];
                        FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    }

                if (SaveStatus == "1")
                {
                    if (txt_name.Text != "")
                    {
                        string msg = cb.InsertorUpdateCategory(txt_name.Text, "0", txt_remarks.Text, "0",product,img);
                        if (msg == "This category name already exists")
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        openFileDialog1.FileName = "openFileDialog1";
                        //  txt_name.Text = "";
                        if (rd_increadiant.Checked == true)
                            increadiantload();
                        else if(rd_countersale.Checked==true)
                            CounterSaleload();
                        else
                            productload();
                        txt_name.Text = "";
                        txt_remarks.Text = "";
                        txt_name.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Please enter category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //cmb_category.Focus();
                        txt_name.Focus();
                    }
                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Save Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (UpdateStatus == "1")
                {

                    Image s = pb_photo.Image;
                    //byte[] se = s;
                    //openFileDialog1.FileName = pb_photo.ImageLocation;
                    //if (openFileDialog1.FileName == "" || openFileDialog1.FileName == "openFileDialog1")
                    //{
                    //    string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                    //    FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                    //    img = new byte[FS.Length];
                    //    FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    //    pb_photo.ImageLocation = FilePath;
                    //    pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                    //}
                    //else
                    //    if (openFileDialog1.FileName != "")
                    //    {
                    ImageConverter converter = new ImageConverter();
                     img=(byte[])converter.ConvertTo(pb_photo.Image, typeof(byte[]));

                    //    }
                    if (cmb_category.SelectedIndex > 0)
                    {
                        if (txt_name.Text != "")
                        {
 //FileStream FS = new FileStream(pb_photo.ImageLocation, FileMode.Open, FileAccess.Read);
 //                   img = new byte[FS.Length];
 //                   FS.Read(img, 0, Convert.ToInt32(FS.Length));
                            string msg = cb.InsertorUpdateCategory(txt_name.Text, "1", txt_remarks.Text, cmb_category.SelectedValue.ToString(), product, img);
                            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Rb_new.Checked = true;
                            clear();
                            if (rd_increadiant.Checked == true)
                            {
                                increadiantload();
                            }
                            else
                                productload();
                            txt_name.Text = "";
                            txt_remarks.Text = "";
                            cmb_category.Focus();
                            string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                            //FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                            //img = new byte[FS.Length];
                            //FS.Read(img, 0, Convert.ToInt32(FS.Length));
                            //pb_photo.ImageLocation = FilePath;
                            //pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;

                        }
                        else
                        {
                            MessageBox.Show("Please enter category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmb_category.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("please select a category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_category.Focus();
                    }
                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Update Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            pb_photo.Refresh();
            //openFileDialog1.FileName = "";
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_edit.Checked == true)
            {
                cmb_category.Enabled = true;
                Btn_Delete.Enabled = true;
                rd_Product.Checked = true;
                cmb_category.Focus();
            }
            else
            {
                cmb_category.Enabled = false;
                Btn_Delete.Enabled = false;
                txt_name.Focus();
            }
            pb_photo.Image = null;
            pb_photo.Refresh();
            string FilePath = Application.StartupPath + "\\Images\\" + "Default Image.jpg";
            pb_photo.ImageLocation = FilePath;
            pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
       


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
        private void Category_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = cb.GetFormUserRights(File.ReadAllText("user.txt"), "Category");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
            this.ActiveControl = txt_name;
            loadcombo();
            txt_name.Focus();

            string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
            pb_photo.ImageLocation = FilePath;
            pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
            if (DeleteStatus == "1")
            {
                if (cmb_category.SelectedIndex > 0)
                {
                    string msg = cb.DeleteCategory(cmb_category.SelectedValue.ToString());
                    if (msg == "1")
                        MessageBox.Show("Category sucessfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sorry,Category already in use.So you can not delete this Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//  txt_name.Text = "";
                else
                {
                    MessageBox.Show("Please select a Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadcombo();
                if (rd_increadiant.Checked == true)
                {
                    increadiantload();
                }
                else
                    productload();
                txt_name.Text = "";
                txt_remarks.Text = "";
                cmb_category.Focus();
                txt_name.Text = "";
                txt_remarks.Text = "";
                cmb_category.Focus();
                string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                img = new byte[FS.Length];
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                pb_photo.ImageLocation = FilePath;
                pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;



            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }
        
        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
         {
           try
           {
               //pb_photo.Refresh();
            if (f == 1)
            { 
               DataTable dt = new DataTable();
               dt= cb.GetCategorybyId(cmb_category.SelectedValue.ToString());
               if(dt.Rows.Count>0)
               {
                   txt_name.Text = dt.Rows[0]["Name"].ToString();
                   txt_remarks.Text = dt.Rows[0]["Remarks"].ToString();
                   if ((dt.Rows[0]["photo"]) != "0x")//
                    {
                        img = (byte[])dt.Rows[0]["photo"];
                        MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["photo"]);

                        if (ms.Length == 0)
                        {
                            string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                            pb_photo.ImageLocation = FilePath;
                            ms.SetLength(0);


                        }
                        else
                        {
                            pb_photo.Image = Image.FromStream(ms);
                            pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb_photo.Refresh();
                        }


                    }
                   //pb_photo.Refresh();
                }
                else
                {
                    txt_name.Text ="";
                    txt_remarks.Text = "";
                }
            }
           }
           catch (Exception ex)
           {
               File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
           }


        }

        private void name(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_remarks.Focus();
            }
        }

        private void txt_remarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }

        }

        private void cmb_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_name.Focus();
            }
        }

        private void Rb_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_category.Focus();
            }
        }

        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            loadcombo();
            txt_name.Text = "";
            txt_remarks.Text = "";
            txt_name.Focus();
            clear();
            
        }

        private void cmb_category_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_category.DroppedDown)
            {
                cmb_category.Focus();
            }
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

        int product = 1;
        private void rd_Product_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Product.Checked == true)
            {

                productload();
            }
            txt_name.Text = "";
            txt_remarks.Text = "";
        }
        public void productload()
        {
            try
            {
            product = 1;
            DataSet ds = new DataSet();
            ds = cb.GetCategory(product);
            f = 0;
            cmb_category.DataSource = ds.Tables[0];
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["Name"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_category.SelectedIndex = 0;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }
        private void rd_increadiant_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rd_Product.Checked == false)
            {
                increadiantload();
            }
            txt_name.Text = "";
            txt_remarks.Text = "";
        }

        
        public void increadiantload()
        {
            try
            {
            product = 0;
            DataSet ds = new DataSet();
            ds = cb.GetCategory(product);
            f = 0;
            cmb_category.DataSource = ds.Tables[0];
            cmb_category.DisplayMember = "Name";
            cmb_category.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["Name"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_category.SelectedIndex = 0;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void cmb_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_category.DroppedDown)
            {
                cmb_category.Focus();

            }
        }

        private void rd_countersale_CheckedChanged(object sender, EventArgs e)
        {
            
                CounterSaleload();
           
            txt_name.Text = "";
            txt_remarks.Text = "";
        }
        public void CounterSaleload()
        {
            try
            {
                product = 2;
                DataSet ds = new DataSet();
                ds = cb.GetCategory(product);
                f = 0;
                cmb_category.DataSource = ds.Tables[0];
                cmb_category.DisplayMember = "Name";
                cmb_category.ValueMember = "Id";
                DataRow dr = ds.Tables[0].NewRow();
                dr["Name"] = "--Select One--";
                dr["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmb_category.SelectedIndex = 0;
                f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
           
            if (openFileDialog1.FileName != "openFileDialog1")
                pb_photo.ImageLocation = openFileDialog1.FileName;
        }
    }
}
