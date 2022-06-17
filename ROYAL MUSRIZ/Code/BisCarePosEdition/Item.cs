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
using System.Runtime.InteropServices;
namespace BisCarePosEdition
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void loadcombo()
        {
            DataSet ds4 = new DataSet();
            ds4 = obj.GetCategory(1);
            cmb_catname.DataSource = ds4.Tables[0];
            cmb_catname.DisplayMember = "Name";
            cmb_catname.ValueMember = "Id";
            DataRow dr4 = ds4.Tables[0].NewRow();
            dr4["Name"] = "--Select One--";
            dr4["Id"] = "0";
            ds4.Tables[0].Rows.InsertAt(dr4, 0);
            cmb_catname.SelectedIndex = 0;



            DataSet ds = new DataSet();
            ds = obj.GetUnit();
            Cmb_UnitType.DataSource = ds.Tables[0];
            Cmb_UnitType.DisplayMember = "Unit";
            Cmb_UnitType.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["Unit"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            Cmb_UnitType.SelectedIndex = 0;

            //DataSet ds1 = new DataSet();
            //ds1 = obj.GetBrand();
            //cmb_brandid.DataSource = ds1.Tables[0];
            //cmb_brandid.DisplayMember = "Name";
            //cmb_brandid.ValueMember = "Id";
            //DataRow dr1 = ds1.Tables[0].NewRow();
            //dr1["Name"] = "--Select One--";
            //dr1["Id"] = "0";
            //ds1.Tables[0].Rows.InsertAt(dr1, 0);
            //cmb_brandid.SelectedIndex = 0;

            DataSet ds2 = new DataSet();
            ds2 = obj.GetTax();
            cmb_taxid.DataSource = ds2.Tables[0];
            cmb_taxid.DisplayMember = "Name";
            cmb_taxid.ValueMember = "Id";
            DataRow dr1 = ds2.Tables[0].NewRow();
            dr1["Name"] = "--Select One--";
            dr1["Id"] = "0";
            ds2.Tables[0].Rows.InsertAt(dr1, 0);
            cmb_taxid.SelectedIndex = 0;


            DataSet ds5 = new DataSet();
            ds5 = obj.GetItem();
            Cmb_itemname.DataSource = ds5.Tables[0];
            Cmb_itemname.DisplayMember = "ItemName";
            Cmb_itemname.ValueMember = "Id";
            DataRow dr5 = ds5.Tables[0].NewRow();
            dr5["ItemName"] = "--Select One--";
            dr5["Id"] = "0";
            ds5.Tables[0].Rows.InsertAt(dr5, 0);
            Cmb_itemname.SelectedIndex = 0;

            DataSet s = new DataSet();
                s = obj.getdepartrment();
                cmb_department.DataSource = s.Tables[0];
                cmb_department.DisplayMember = "department";
                cmb_department.ValueMember = "Id";
                DataRow r = s.Tables[0].NewRow();
                r["department"] = "--Select One--";
                r["Id"] = "0";
                s.Tables[0].Rows.InsertAt(r, 0);
                cmb_department.SelectedIndex = 0;
                f = 1;
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
        int f = 0;
        private void Item_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                DataTable dt1 = new DataTable();
                dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Item");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                

                this.ActiveControl = cmb_catname;
                cmb_department.Enabled = true;
                cmb_department.SelectedValue= "0";
                txt_itemcode.Text = "";
                SqlDataReader dr11 = obj.GenerateItemCode();
                if (dr11.Read())
                {
                    txt_itemcode.Text = dr11[0].ToString();
                }



                DataSet ds4 = new DataSet();
                ds4 = obj.GetCategory(1);
                cmb_catname.DataSource = ds4.Tables[0];
                cmb_catname.DisplayMember = "Name";
                cmb_catname.ValueMember = "Id";
                DataRow dr4 = ds4.Tables[0].NewRow();
                dr4["Name"] = "--Select One--";
                dr4["Id"] = "0";
                ds4.Tables[0].Rows.InsertAt(dr4, 0);
                cmb_catname.SelectedIndex = 0;

                DataSet d1 = new DataSet();
                d1 = obj.GetUnit();
                Cmb_UnitType.DataSource = d1.Tables[0];
                Cmb_UnitType.DisplayMember = "Unit";
                Cmb_UnitType.ValueMember = "Id";
                DataRow dr = d1.Tables[0].NewRow();
                dr["Unit"] = "--Select One--";
                dr["Id"] = "0";
                d1.Tables[0].Rows.InsertAt(dr, 0);
                Cmb_UnitType.SelectedIndex = 0;

                DataSet ds2 = new DataSet();
                ds2 = obj.GetTax();
                cmb_taxid.DataSource = ds2.Tables[0];
                cmb_taxid.DisplayMember = "Name";
                cmb_taxid.ValueMember = "Id";
                DataRow dr1 = ds2.Tables[0].NewRow();
                dr1["Name"] = "--Select One--";
                dr1["Id"] = "0";
                ds2.Tables[0].Rows.InsertAt(dr1, 0);
                cmb_taxid.SelectedIndex = 0;

                DataSet s = new DataSet();
                s= obj.getdepartrment();
               

                cmb_department.DataSource = s.Tables[0];
                cmb_department.DisplayMember = "department";
                cmb_department.ValueMember = "id";


                DataRow d5 = s.Tables[0].NewRow();
                d5["department"] = "--Select One--";
                d5["id"] = "0";
                s.Tables[0].Rows.InsertAt(d5, 0);
                if (s.Tables[0].Rows.Count > 0)
                cmb_department.SelectedIndex = 1;
                else
                    cmb_department.SelectedIndex = 0;

                Cmb_itemname.Enabled = false;
                cmb_department.Enabled = true;
                Btn_Delete.Enabled = false;

                cmb_catname.Focus();
                Btn_Delete.Enabled = false;
                f = 1;

                txt_sellprice.Visible = true;
                lbl_Sell.Visible = true;

                lbl_cost.Visible = false;
                txt_codeprice.Visible = false;

             
                string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
             
                pb_photo.ImageLocation = FilePath;
                pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
             
                clear();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
        string s;
       
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void clear()
        {
            //pb_photo.Image = null;
            //pb_photo.Refresh();
            txt_barcode.Text = string.Empty;
            txt_codeprice.Text = "0.00";
            //txt_itemcode.Text = 
                //string.Empty;
            txt_itemname.Text = string.Empty;
            txt_arabic.Text = string.Empty;
            txt_sellprice.Text = "0.00";
            txt_homedelivery.Text = "0.00";
            txtSellPriceNonAC.Text="0.00";
            cmb_department.SelectedValue="0" ;
            cmb_department.Text="--select--";
            cmb_catname.SelectedValue = "0";
            chk_changeprice.Checked = false;
            cmb_taxid.SelectedValue = "0";

            Cmb_UnitType.SelectedValue = "0";
            cmb_catname.Focus();
            string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
            pb_photo.ImageLocation = FilePath;
            pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Txt_OrgsellPrice.Text = "0.00";
        }
        public string check()
        {
            string st = "0";
            if (cmb_catname.SelectedIndex < 1)
            {
                MessageBox.Show("Please select Category", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_catname.Focus();
                st = "1";
            }
            else
            {
                if (txt_itemcode.Text == "")
                {
                    MessageBox.Show("Please enter itemcode", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_itemcode.Focus();
                    st = "1";
                }
                else
                {
                    if (txt_itemname.Text == "")
                    {

                        MessageBox.Show("Please enter itemname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_itemname.Focus();
                        st = "1";
                    }
                    else
                    {
                        if (Convert.ToDouble(txt_sellprice.Text) == 0.00)
                        {
                            MessageBox.Show("Please enter  AC Sell Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_sellprice.Focus();
                            st = "1";
                        }

                        else
                        {

                            if (Convert.ToDouble(txtSellPriceNonAC.Text) == 0.00)
                            {
                                MessageBox.Show("Please enter Non AC Sell Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSellPriceNonAC.Focus();
                                st = "1";
                            }
                            else
                            {
                                if (cmb_department.SelectedIndex < 1)
                                {

                                    MessageBox.Show("Please enter Department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cmb_department.Focus();
                                    st = "1";
                                }
                                else
                                {
                                    if (Cmb_UnitType.SelectedIndex <= 0)
                                    {

                                        MessageBox.Show("Please select a unit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        Cmb_UnitType.Focus();
                                        st = "1";
                                    }
                                    else
                                    {
                                        if (rd_Ingradiant.Checked == true)
                                        {
                                            //if (Convert.ToDouble(txt_codeprice.Text) == 0)
                                            //{
                                            //    MessageBox.Show("Please enter CostPrice", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            //    txt_codeprice.Focus();
                                            //    st = "1";
                                            //}
                                        }
                                        if (rd_Prodect.Checked == true)
                                        {
                                            //if (Convert.ToDouble(txt_sellprice.Text) == 0)
                                            //{
                                            //    MessageBox.Show("Please enter AC Sell Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            //    txt_codeprice.Focus();
                                            //    st = "1";
                                            //}
                                            //else
                                            //{
                                            if (Convert.ToDouble(txtSellPriceNonAC.Text) == 0.00)
                                            {
                                                MessageBox.Show("Please enter Non AC Sell Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtSellPriceNonAC.Focus();
                                                st = "1";
                                            }
                                            else
                                            {
                                                //if (Convert.ToDouble(txtSellPriceNonAC.Text) > Convert.ToDouble(txt_sellprice.Text))
                                                //{
                                                //    MessageBox.Show("Non AC sell price must be lesser than AC sell price.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                //    txtSellPriceNonAC.Focus();
                                                //    st = "1";
                                                //}
                                                //else
                                                //{
                                                if (cmb_catname.SelectedIndex < 1)
                                                {
                                                    MessageBox.Show("Please enter department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    cmb_department.Focus();
                                                    st = "1";
                                                }

                                            }
                                        }
                                    }
                                    if (rd_countersale.Checked == true)
                                    {
                                        if (Convert.ToDouble(txtSellPriceNonAC.Text) == 0.00)
                                        {
                                            MessageBox.Show("Please enter Non AC Sell Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtSellPriceNonAC.Focus();
                                            st = "1";
                                        }
                                        //else
                                        //{
                                        //    if (Convert.ToDouble(txtSellPriceNonAC.Text) < Convert.ToDouble(txt_codeprice.Text))
                                        //    {
                                        //        MessageBox.Show("Sell price must be grater than Cost Price .", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        //        txtSellPriceNonAC.Focus();
                                        //        st = "1";
                                        //    }
                                        //}
                                    }
                                }
                            }
                        }
                    }
                }
                ////    }
                ////}
            }
            return st;
        }
       
        string pi;
      public  byte[] img;
      public int strv = 0;
        private void btn_save_Click(object sender, EventArgs e)
          {
            try
            {
               
                pb_photo.Refresh();
                if (rd_Prodect.Checked == true)
                {
                    pi = "1";
                }
                else if (rd_Ingradiant.Checked == true)
                {
                    pi = " 0";
                }
                else
                {
                    pi = "2";
                }

                if (rb_single.Checked == true)
                {
                    s = "0";
                }
                if (rb_multiple.Checked == true)
                {
                    s = "1";
                }
                if (openFileDialog1.FileName == "" || openFileDialog1.FileName == "openFileDialog1")
                {
                    string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                    FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                    img = new byte[FS.Length];
                    FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    pb_photo.ImageLocation = FilePath;
                    pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                    if (openFileDialog1.FileName != "NoFile")
                    {
                        FileStream FS = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        img = new byte[FS.Length];
                        FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    }
                    
                if (Rb_new.Checked == true)
                {

                    if (SaveStatus == "1")
                    {
                        string stat = check();
                        if (stat == "0")
                        {
                            strv = 0;
                            string msg = obj.InserorUpdateItem(cmb_catname.SelectedValue.ToString(), txt_itemcode.Text, txt_itemname.Text, "0",
                                Cmb_UnitType.SelectedValue.ToString(), txt_barcode.Text, txt_codeprice.Text, "0",txt_sellprice.Text, s, "0", "1", pi, txtSellPriceNonAC.Text,
                                cmb_department.SelectedValue.ToString() == "" ? "0" : cmb_department.SelectedValue.ToString(), txt_homedelivery.Text,
                                img, txt_arabic.Text,chk_changeprice.Checked==true?1:0);
                            if (msg == "0")
                            {
                                MessageBox.Show("Sorry,Item Name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_itemname.Focus();
                            }

                            if (msg == "1")
                            {
                                MessageBox.Show("Sorry,Item Code already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_itemcode.Focus();
                                pb_photo.Visible = true;
                                //openFileDialog1.Reset();
                            }
                            //if (msg == "2")
                            //{
                            //    MessageBox.Show("Sorry,BarCode already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //    txt_barcode.Focus();
                            //}
                            if (msg == "3")
                            {
                                MessageBox.Show("Item Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                openFileDialog1.FileName = "openFileDialog1";

                                if (rd_Prodect.Checked == true)
                                {
                                    loadcombo();
                                    DataSet ds5 = new DataSet();
                                    ds5 = obj.GetItem();
                                    Cmb_itemname.DataSource = ds5.Tables[0];
                                    Cmb_itemname.DisplayMember = "ItemName";
                                    Cmb_itemname.ValueMember = "Id";
                                    DataRow dr5 = ds5.Tables[0].NewRow();
                                    dr5["ItemName"] = "--Select One--";
                                    dr5["Id"] = "0";
                                    ds5.Tables[0].Rows.InsertAt(dr5, 0);
                                    Cmb_itemname.SelectedIndex = 0;
                                }
                                else if (rd_Ingradiant.Checked == true)
                                {
                                    product = 0;
                                    DataSet ds = new DataSet();
                                    ds = obj.GetCategory(product);
                                    f = 0;
                                    cmb_catname.DataSource = ds.Tables[0];
                                    cmb_catname.DisplayMember = "Name";
                                    cmb_catname.ValueMember = "Id";
                                    DataRow dr = ds.Tables[0].NewRow();
                                    dr["Name"] = "--Select One--";
                                    dr["Id"] = "0";
                                    ds.Tables[0].Rows.InsertAt(dr, 0);
                                    cmb_catname.SelectedIndex = 0;
                                    f = 1;
                                    txt_sellprice.Visible = false;
                                    lbl_Sell.Visible = false;
                                    lbl_cost.Visible = false;
                                    txt_codeprice.Visible = false;

                                }
                                else
                                {
                                    product = 2;
                                    DataSet ds = new DataSet();
                                    ds = obj.GetCategory(product);
                                    f = 0;
                                    cmb_catname.DataSource = ds.Tables[0];
                                    cmb_catname.DisplayMember = "Name";
                                    cmb_catname.ValueMember = "Id";
                                    DataRow dr = ds.Tables[0].NewRow();
                                    dr["Name"] = "--Select One--";
                                    dr["Id"] = "0";
                                    ds.Tables[0].Rows.InsertAt(dr, 0);
                                    cmb_catname.SelectedIndex = 0;
                                    f = 1;
                                }
                                clear();
                                SqlDataReader dr11 = obj.GenerateItemCode();
                                if (dr11.Read())
                                {
                                    txt_itemcode.Text = dr11[0].ToString();
                                }
                                cmb_catname.Focus();
                            }
                        }
                        strv = 1;
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Save Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (UpdateStatus == "1")
                    {
                        if (Cmb_itemname.SelectedIndex > 0)
                        {
                            string stat = check();

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
                            //    if (openFileDialog1.FileName != "NoFile")
                            //    {
                            //        FileStream FS = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                            //        img = new byte[FS.Length];
                            //        FS.Read(img, 0, Convert.ToInt32(FS.Length));
                            //    }
                            ImageConverter converter = new ImageConverter();
                            img = (byte[])converter.ConvertTo(pb_photo.Image, typeof(byte[]));

                            if (stat == "0")
                            {
                                strv = 0;
                                string msg = obj.InserorUpdateItem(cmb_catname.SelectedValue.ToString(), txt_itemcode.Text, txt_itemname.Text, "0",
                                    Cmb_UnitType.SelectedValue.ToString(), txt_barcode.Text, txt_codeprice.Text, "0", txt_sellprice.Text, s, 
                                    Cmb_itemname.SelectedValue.ToString(), "2", pi, txtSellPriceNonAC.Text, cmb_department.SelectedValue.ToString() == "" ? "0" : cmb_department.SelectedValue.ToString(),
                                    txt_homedelivery.Text, img, txt_arabic.Text, chk_changeprice.Checked == true ? 1 : 0);

                                if (msg == "0")
                                {
                                    MessageBox.Show("Sorry,Item Name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_itemname.Focus();
                                }
                                if (msg == "4")
                                {
                                    MessageBox.Show("Item Sucessfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    openFileDialog1.FileName = "";
                                    
                                    DataSet ds5 = new DataSet();
                                    ds5 = obj.GetItem();
                                    Cmb_itemname.DataSource = ds5.Tables[0];
                                    Cmb_itemname.DisplayMember = "ItemName";
                                    Cmb_itemname.ValueMember = "Id";
                                    DataRow dr5 = ds5.Tables[0].NewRow();
                                    dr5["ItemName"] = "--Select One--";
                                    dr5["Id"] = "0";
                                    ds5.Tables[0].Rows.InsertAt(dr5, 0);
                                    Cmb_itemname.SelectedIndex = 0;
                                    clear();
                                    Cmb_itemname.Focus();
                                    loadcombo();
                                    Rb_new.Checked = true;
                                }
                            }
                            strv = 1;
                        }
                        else
                        {
                            MessageBox.Show("Please select an Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cmb_itemname.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Do Not Have The Permission To Update Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rd_Prodect.Checked = true;
                }
                //
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        private void Rb_new_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ed = 0;
               loadcombo();
                clear();
                if (Rb_new.Checked == true)
                {

                    Cmb_itemname.Enabled = false;
                    Btn_Delete.Enabled = false;
                    txt_itemname.Focus();
                    Btn_Delete.Enabled = false;
                    clear();
                    SqlDataReader dr11 = obj.GenerateItemCode();
                    if (dr11.Read())
                    {
                        txt_itemcode.Text = dr11[0].ToString();
                        dr11.Close();
                    }                  
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int ed = 0;
        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            ed = 1;
            try
            {
                //f = 0;
                Btn_Delete.Enabled = true;
                loadcombo();

                if (rd_Ingradiant.Checked == true)
                {
                    DataSet ds5 = new DataSet();
                    ds5 = obj.GetItem(0);
                    Cmb_itemname.DataSource = ds5.Tables[0];
                    Cmb_itemname.DisplayMember = "ItemName";
                    Cmb_itemname.ValueMember = "Id";
                    DataRow dr5 = ds5.Tables[0].NewRow();
                    dr5["ItemName"] = "--Select One--";
                    dr5["Id"] = "0";
                    ds5.Tables[0].Rows.InsertAt(dr5, 0);
                    Cmb_itemname.SelectedIndex = 0;
                }
                else if (rd_Prodect.Checked == true)
                {
                    DataSet ds5 = new DataSet();
                    ds5 = obj.GetItem(1);
                    Cmb_itemname.DataSource = ds5.Tables[0];
                    Cmb_itemname.DisplayMember = "ItemName";
                    Cmb_itemname.ValueMember = "Id";
                    DataRow dr5 = ds5.Tables[0].NewRow();
                    dr5["ItemName"] = "--Select One--";
                    dr5["Id"] = "0";
                    ds5.Tables[0].Rows.InsertAt(dr5, 0);
                    Cmb_itemname.SelectedIndex = 0;
                }
                else
                {
                    DataSet ds5 = new DataSet();
                    ds5 = obj.GetItem(2);
                    Cmb_itemname.DataSource = ds5.Tables[0];
                    Cmb_itemname.DisplayMember = "ItemName";
                    Cmb_itemname.ValueMember = "Id";
                    DataRow dr5 = ds5.Tables[0].NewRow();
                    dr5["ItemName"] = "--Select One--";
                    dr5["Id"] = "0";
                    ds5.Tables[0].Rows.InsertAt(dr5, 0);
                    Cmb_itemname.SelectedIndex = 0;
                }
                clear();
                Cmb_itemname.Enabled = true;
                Cmb_itemname.Focus();
                rd_Prodect.Checked = true;
                //f = 0;
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Cmb_itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (f == 1)
                {

                    if (Convert.ToDouble(Cmb_itemname.SelectedValue.ToString() == "" ? "0" : Cmb_itemname.SelectedValue.ToString()) > 0)
                    {
                        DataTable dr = obj.GetItemDetail(Cmb_itemname.SelectedValue.ToString());
                        if (dr.Rows.Count > 0)
                        {
                            if (dr.Rows[0]["ItemStatus"].ToString() == "0")
                            {
                                rd_Ingradiant.Checked = true;
                            }
                            else if (dr.Rows[0]["ItemStatus"].ToString() == "1")
                            {
                                rd_Prodect.Checked = true;
                            }
                            else
                                rd_countersale.Checked = true;
                            // cmb_brandid.SelectedValue=dr[4].ToString();
                            cmb_catname.SelectedValue = Convert.ToInt32(dr.Rows[0]["CatId"]);
                            cmb_taxid.SelectedValue = dr.Rows[0]["TaxId"].ToString();
                            Cmb_UnitType.SelectedValue = dr.Rows[0]["UnitId"].ToString();
                            cmb_department.SelectedValue = dr.Rows[0]["department"] == "" ? "0" : dr.Rows[0]["department"];
                            txt_barcode.Text = dr.Rows[0]["Barcode"].ToString();
                            txt_codeprice.Text = dr.Rows[0]["CostPrice"].ToString();
                            txt_itemcode.Text = dr.Rows[0]["ItemCode"].ToString();
                            txt_itemname.Text = dr.Rows[0]["ItemName"].ToString();
                            txt_arabic.Text = dr.Rows[0]["Item_arabic"].ToString();
                            txt_sellprice.Text = dr.Rows[0]["SellPrice"].ToString();
                            txtSellPriceNonAC.Text = dr.Rows[0]["SellPriceNonAC"].ToString();
                            txt_homedelivery.Text = dr.Rows[0]["SellPriceHomeDelivery"].ToString();
                            if (Convert.ToInt32(dr.Rows[0]["ChangeSellpricestatus"].ToString()) == 0)
                            {
                                chk_changeprice.Checked = false;
                            }
                            else
                                chk_changeprice.Checked = true;

                            //MessageBox.Show(((byte[])dr.Rows[0]["photo"]).ToString());
                            SqlDataReader dr12 = obj.getimage(Cmb_itemname.SelectedValue.ToString());
                            byte[] data = (byte[])dr.Rows[0]["photo"];
                            if (dr.Rows[0]["photo"] != "0x")
                            {
                                img = (byte[])dr.Rows[0]["photo"];
                                MemoryStream ms = new MemoryStream((byte[])dr.Rows[0]["photo"]);
                                if (ms.Length == 0)
                                {
                                    string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                                    pb_photo.ImageLocation = FilePath;
                                    


                                }
                                else
                                {
                                    pb_photo.Image = Image.FromStream(ms);
                                    pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                                    pb_photo.Refresh();
                                }


                            }

                            if (txt_sellprice.Text != "")
                            {
                                if (decimal.Parse(txt_sellprice.Text) != 0)
                                {
                                    decimal orgPrice = (decimal.Parse(txt_sellprice.Text) * 105) / 100;
                                    Txt_OrgsellPrice.Text = orgPrice.ToString("F2");
                                }
                            }

                            Cmb_itemname.Focus();
                        }
                           
                      

                    }
                    else
                    {
                        clear();
                    }
                    //f = 0;
                }
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
                    if (Cmb_itemname.SelectedIndex > 0)
                    {
                        string st = obj.DeleteItem(Cmb_itemname.SelectedValue.ToString());
                        if (st == "0")
                        {
                            MessageBox.Show("Sorry this item already used.So you cannot delete it", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Item deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            DataSet ds5 = new DataSet();
                            ds5 = obj.GetItem(1);
                            Cmb_itemname.DataSource = ds5.Tables[0];
                            Cmb_itemname.DisplayMember = "ItemName";
                            Cmb_itemname.ValueMember = "Id";
                            DataRow dr5 = ds5.Tables[0].NewRow();
                            dr5["ItemName"] = "--Select One--";
                            dr5["Id"] = "0";
                            ds5.Tables[0].Rows.InsertAt(dr5, 0);
                            Cmb_itemname.SelectedIndex = 0;
                            clear();
                            Cmb_itemname.Focus();
                            Rb_new.Checked = true;
                            string FilePath = Application.StartupPath + " \\Images\\" + "Default Image.jpg";
                            FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                            img = new byte[FS.Length];
                            FS.Read(img, 0, Convert.ToInt32(FS.Length));
                            pb_photo.ImageLocation = FilePath;
                            pb_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cmb_itemname.Focus();
                    }
                }
                else
                {

                    MessageBox.Show("You Do Not Have The Permission To Delete Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_codeprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_codeprice.Text == "")
                {
                    txt_codeprice.Text = "0";
                }
                if (txt_codeprice.Text.StartsWith("0") == true && txt_codeprice.Text.EndsWith(".") != true)
                {
                    txt_codeprice.Text = Convert.ToDouble(txt_codeprice.Text).ToString();
                }
                string Str = txt_codeprice.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_codeprice.Select(txt_codeprice.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_codeprice.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_sellprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_sellprice.Text == "")
                {
                    txt_sellprice.Text = "0";
                }
                //if (txt_sellprice.Text.StartsWith("0") == true && txt_sellprice.Text.EndsWith(".") != true)
                //{
                //    txt_sellprice.Text = Convert.ToDouble(txt_sellprice.Text).ToString();
                //}
                string Str = txt_sellprice.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    // txt_sellprice.Text = Convert.ToDouble(txt_sellprice.Text).ToString();
                    txt_sellprice.Select(txt_sellprice.Text.Length, 0);
                   // txtSellPriceNonAC.Text = txt_sellprice.Text;
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_sellprice.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Cmb_itemname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.F1)
                {
                    ItemSearch obj = new ItemSearch();
                    obj.ShowDialog();
                    if (obj.dgr == DialogResult.OK)
                    {
                        Cmb_itemname.SelectedValue = obj.id;
                        Cmb_itemname.Focus();
                        Rb_edit.Checked = true;
                    }
                }
                if (e.KeyData == Keys.Enter)
                {
                    txt_itemcode.Focus();
                }
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
                Category c = new Category();
                c.ShowDialog();
                globalvariable.status = 1;
                if (rd_Prodect.Checked == true)
                {
                    product = 1;
                    globalvariable.productid = 1;
                    DataSet ds = new DataSet();
                    ds = obj.GetCategory(product);
                    f = 0;
                    cmb_catname.DataSource = ds.Tables[0];
                    cmb_catname.DisplayMember = "Name";
                    cmb_catname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_catname.SelectedIndex = 0;
                    f = 1;
                    txt_sellprice.Visible = false;
                    lbl_Sell.Visible = false;
                    lbl_cost.Visible = false;
                    txt_codeprice.Visible = false;
                }
                else if (rd_Ingradiant.Checked == true)
                {
                    product = 0;
                    globalvariable.productid = 0;
                    DataSet ds = new DataSet();
                    ds = obj.GetCategory(product);
                    f = 0;
                    cmb_catname.DataSource = ds.Tables[0];
                    cmb_catname.DisplayMember = "Name";
                    cmb_catname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_catname.SelectedIndex = 0;
                    f = 1;
                    txt_sellprice.Visible = false;
                    lbl_Sell.Visible = false;
                    lbl_cost.Visible = false;
                    txt_codeprice.Visible = false;
                }
                else
                {
                    product = 2;
                    globalvariable.productid = 2;
                    DataSet ds = new DataSet();
                    ds = obj.GetCategory(product);
                    f = 0;
                    cmb_catname.DataSource = ds.Tables[0];
                    cmb_catname.DisplayMember = "Name";
                    cmb_catname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_catname.SelectedIndex = 0;
                    f = 1;
                    //txt_sellprice.Visible = false;
                    //lbl_Sell.Visible = false;
                    //lbl_cost.Visible = f;
                    //txt_codeprice.Visible = false;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_newbrand_Click(object sender, EventArgs e)
        {
            Brand b = new Brand();
            b.ShowDialog();

            //DataSet ds1 = new DataSet();
            //ds1 = obj.GetBrand();
            //cmb_brandid.DataSource = ds1.Tables[0];
            //cmb_brandid.DisplayMember = "Name";
            //cmb_brandid.ValueMember = "Id";
            //DataRow dr1 = ds1.Tables[0].NewRow();
            //dr1["Name"] = "--Select One--";
            //dr1["Id"] = "0";
            //ds1.Tables[0].Rows.InsertAt(dr1, 0);
            //cmb_brandid.SelectedIndex = 0;
        }

        private void btn_NewUnit_Click(object sender, EventArgs e)
        {
            try
            {
                Unit u = new Unit();
                u.ShowDialog();

                DataSet ds = new DataSet();
                ds = obj.GetUnit();
                Cmb_UnitType.DataSource = ds.Tables[0];
                Cmb_UnitType.DisplayMember = "Unit";
                Cmb_UnitType.ValueMember = "Id";
                DataRow dr = ds.Tables[0].NewRow();
                dr["Unit"] = "--Select One--";
                dr["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                Cmb_UnitType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
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

        private void Cmb_UnitType_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Cmb_UnitType.DroppedDown)
            {
                Cmb_UnitType.Focus();

            }
        }

        private void Cmb_itemname_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Cmb_itemname.DroppedDown)
            {
                Cmb_itemname.Focus();

            }
        }

        private void cmb_taxid_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_taxid.DroppedDown)
            {
                cmb_taxid.Focus();

            }
        }

        private void txt_codeprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_sellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }
        int k = 0;

        private void btn_save_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
        }

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_save_Paint);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rb_new_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_catname.Focus();
            }
        }

        private void Rb_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Cmb_itemname.Focus();
            }
        }

        private void cmb_catname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (Convert.ToDouble(cmb_catname.SelectedValue) == 0)
                    cmb_catname.Focus();
                else
                    cmb_department.Focus();
                    //txt_itemcode.Focus();
                if (e.KeyData == Keys.Down)
                {
                    cmb_catname.Focus();
                }
            }
        }

        private void txt_itemcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_itemname.Focus();
            }
        }

        private void txt_itemname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_itemname.Text == "")
                    txt_itemname.Focus();
                else
                    //btn_browse.Focus();
                    Cmb_UnitType.Focus();
            }
        }

        private void Cmb_UnitType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (Convert.ToDouble(Cmb_UnitType.SelectedValue) == 0)
                    Cmb_UnitType.Focus();
                else
                    txtSellPriceNonAC.Focus();
                   // cmb_taxid.Focus();
                    //txt_sellprice.Focus();
            }
        }

        private void cmb_taxid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (rd_Ingradiant.Checked == true)
                    txt_codeprice.Focus();
                else
                    txt_sellprice.Focus();
            }
        }

        private void txt_codeprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_codeprice.Text == "0")
                    txt_codeprice.Focus();
                else
                    btn_save.Focus();
            }
        }

        private void txt_sellprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                if (txt_sellprice.Text == "0")
                    txt_sellprice.Focus();
                else
                    btn_save.Focus();
                    //txtSellPriceNonAC.Focus();
            }
        }

        private void rb_single_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tax t = new Tax();
                t.ShowDialog();
                DataSet ds2 = new DataSet();
                ds2 = obj.GetTax();
                cmb_taxid.DataSource = ds2.Tables[0];
                cmb_taxid.DisplayMember = "Name";
                cmb_taxid.ValueMember = "Id";
                DataRow dr1 = ds2.Tables[0].NewRow();
                dr1["Name"] = "--Select One--";
                dr1["Id"] = "0";
                ds2.Tables[0].Rows.InsertAt(dr1, 0);
                cmb_taxid.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        int product = 0;
        private void rd_Prodect_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_Prodect.Checked == true)
                {
                    product = 1;
                    DataSet ds = new DataSet();
                    ds = obj.GetCategory(product);
                    f = 0;
                    cmb_catname.DataSource = ds.Tables[0];
                    cmb_catname.DisplayMember = "Name";
                    cmb_catname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_catname.SelectedIndex = 0;
                    f = 1;

                    txt_sellprice.Visible = true;
                    lbl_Sell.Visible = true;

                    //lblSellNonAc.Visible = true;
                    //txtSellPriceNonAC.Visible = true;
                    lbl_cost.Visible = false;
                    txt_codeprice.Visible = false;
                  //txt_homedelivery.Visible = true;
                // lbl_delivery.Visible = true;

                    DataSet ds5 = new DataSet();
                    ds5 = obj.GetItem(1);
                    Cmb_itemname.DataSource = ds5.Tables[0];
                    Cmb_itemname.DisplayMember = "ItemName";
                    Cmb_itemname.ValueMember = "Id";
                    DataRow dr5 = ds5.Tables[0].NewRow();
                    dr5["ItemName"] = "--Select One--";
                    dr5["Id"] = "0";
                    ds5.Tables[0].Rows.InsertAt(dr5, 0);
                    Cmb_itemname.SelectedIndex = 0;
                }
                if(strv==0)
                clear();
                if (Rb_edit.Checked == false)
                {
                    SqlDataReader dr11 = obj.GenerateItemCode();
                    if (dr11.Read())
                    {
                        txt_itemcode.Text = dr11[0].ToString();
                    }
                    txt_itemname.Focus();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rd_Ingradiant_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_Ingradiant.Checked == true)
                {

                    product = 0;
                    DataSet ds = new DataSet();
                    ds = obj.GetCategory(product);
                    f = 0;
                    cmb_catname.DataSource = ds.Tables[0];
                    cmb_catname.DisplayMember = "Name";
                    cmb_catname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_catname.SelectedIndex = 0;
                    f = 1;
                    txt_sellprice.Visible = true;
                    lbl_Sell.Visible = true;

                    //lblSellNonAc.Visible = false;
                    //txtSellPriceNonAC.Visible = false;
                   //xt_homedelivery.Visible = false;
                  //lbl_delivery.Visible = false;
                    //lbl_cost.Visible = true;
                    //txt_codeprice.Visible = true;

                    DataSet ds5 = new DataSet();
                    ds5 = obj.GetItem(0);
                    Cmb_itemname.DataSource = ds5.Tables[0];
                    Cmb_itemname.DisplayMember = "ItemName";
                    Cmb_itemname.ValueMember = "Id";
                    DataRow dr5 = ds5.Tables[0].NewRow();
                    dr5["ItemName"] = "--Select One--";
                    dr5["Id"] = "0";
                    ds5.Tables[0].Rows.InsertAt(dr5, 0);
                    Cmb_itemname.SelectedIndex = 0;
                }
                clear();
                if (Rb_edit.Checked == false)
                {
                    SqlDataReader dr11 = obj.GenerateItemCode();
                    if (dr11.Read())
                    {
                        txt_itemcode.Text = dr11[0].ToString();
                        dr11.Close();
                    }
                    txt_itemname.Focus();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rd_Prodect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_catname.Focus();
            }
        }

        private void rd_Ingradiant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmb_catname.Focus();
            }
        }

        private void cmb_catname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_catname.DroppedDown)
            {
                cmb_catname.Focus();

            }
        }

        private void Cmb_itemname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Cmb_itemname.DroppedDown)
            {
                Cmb_itemname.Focus();

            }
        }

        private void Cmb_UnitType_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmb_taxid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lbl_cost_Click(object sender, EventArgs e)
        {

        }
        int m = 0;
        private void txtSellPriceNonAC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSellPriceNonAC.Text == "")
                {
                    txtSellPriceNonAC.Text = "0";
                }
                
                string Str = txtSellPriceNonAC.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txtSellPriceNonAC.Select(txtSellPriceNonAC.Text.Length, 0);
                    if (ed==0)
                    txt_sellprice.Text = txtSellPriceNonAC.Text;
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSellPriceNonAC.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_countersale.Checked == true)
                {

                    product = 2;
                    DataSet ds = new DataSet();
                    ds = obj.GetCategory(product);
                    f = 0;
                    cmb_catname.DataSource = ds.Tables[0];
                    cmb_catname.DisplayMember = "Name";
                    cmb_catname.ValueMember = "Id";
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["Name"] = "--Select One--";
                    dr["Id"] = "0";
                    ds.Tables[0].Rows.InsertAt(dr, 0);
                    cmb_catname.SelectedIndex = 0;

                    txt_sellprice.Visible = true;
                    lbl_Sell.Visible = true;

                    lblSellNonAc.Visible = true;
                    txtSellPriceNonAC.Visible = true;
                    //lbl_cost.Visible = true;
                    //txt_codeprice.Visible = true;

                    DataSet ds5 = new DataSet();
                    ds5 = obj.GetItem(2);
                    Cmb_itemname.DataSource = ds5.Tables[0];
                    Cmb_itemname.DisplayMember = "ItemName";
                    Cmb_itemname.ValueMember = "Id";
                    DataRow dr5 = ds5.Tables[0].NewRow();
                    dr5["ItemName"] = "--Select One--";
                    dr5["Id"] = "0";
                    ds5.Tables[0].Rows.InsertAt(dr5, 0);
                    Cmb_itemname.SelectedIndex = 0;
                    //txt_sellprice.Visible = false;
                    //lbl_Sell.Visible = false;
                    //lblSellNonAc.Visible = true;
                    //txtSellPriceNonAC.Visible = true;
                    lbl_cost.Visible = false;
                    txt_codeprice.Visible = false;
                  //txt_homedelivery.Visible = true;
                  //lbl_delivery.Visible = true;
                }
                clear();
                if (Rb_edit.Checked == false)
                {
                    SqlDataReader dr11 = obj.GenerateItemCode();
                    if (dr11.Read())
                    {
                        txt_itemcode.Text = dr11[0].ToString();
                        dr11.Close();
                    }
                    txt_itemname.Focus();
                }
                f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttn_reset_Click(object sender, EventArgs e)
        {
            clear();
            Rb_new.Checked = true;
            rd_Prodect.Checked = true;
            if (Rb_new.Checked == true)
            {
                SqlDataReader dr11 = obj.GenerateItemCode();
                if (dr11.Read())
                {
                    txt_itemcode.Text = dr11[0].ToString();
                }
            }
        }

        private void cmb_catname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_catname.Focus();
            if (f == 1)
            {
                DataTable dt = new DataTable();
                dt = obj.gettopmostitem(Convert.ToInt32(cmb_catname.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    cmb_department.SelectedValue = dt.Rows[0]["department"].ToString();
                    Cmb_UnitType.SelectedValue = dt.Rows[0]["UnitId"].ToString();
                }
            }
        }

        private void cmb_department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txt_itemcode.Focus();
                if (Convert.ToDouble(cmb_catname.SelectedValue) == 0)
                    cmb_catname.Focus();
                else
                    txt_itemcode.Focus();   
            }

            if (e.KeyData == Keys.Down)
            {
                cmb_department.Focus();
            }
        }

        private void cmb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Department dp = new Department();
            dp.ShowDialog();
            DataSet s = new DataSet();
            s = obj.getdepartrment();
            cmb_department.DataSource = s.Tables[0];
            cmb_department.DisplayMember = "department";
            cmb_department.ValueMember = "id";


            DataRow d5 = s.Tables[0].NewRow();
            d5["department"] = "--Select One--";
            d5["id"] = "0";
            s.Tables[0].Rows.InsertAt(d5, 0);
            cmb_department.SelectedIndex = 0;
            cmb_department.Focus();

        }

        private void cmb_department_Click(object sender, EventArgs e)
        {
        }

        private void cmb_department_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_homedelivery.Text == "")
                {
                   txt_homedelivery.Text = "0";
                }
                
                string Str = txt_homedelivery.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    txt_homedelivery.Select(txt_homedelivery.Text.Length, 0);
                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_homedelivery.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txtSellPriceNonAC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtSellPriceNonAC.Text == "")
                {
                    txtSellPriceNonAC.Focus();
                }
                else
                {
                    txt_sellprice.Focus();
                   // btn_save.Focus();
            }  
                }
        }

        private void txt_homedelivery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_homedelivery.Text == "")
                {
                    txt_homedelivery.Focus();
                }
                else
                {
                    btn_save.Focus();
                }
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            // string FilePath = Application.StartupPath + " \\Images.jpg";
             openFileDialog1.ShowDialog();
          //  openFileDialog1.FileName = Application.StartupPath;
            if(openFileDialog1.FileName!="openFileDialog1")
             pb_photo.ImageLocation = openFileDialog1.FileName;

             
        }

        private void btn_browse_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                Cmb_UnitType.Focus();
            }
        }

        private void Cmb_UnitType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_OrgsellPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Txt_OrgsellPrice.Text != "")
                {
                    decimal rate = decimal.Parse(Txt_OrgsellPrice.Text);

                    decimal taxable = (rate * 100) / 105;
                    txtSellPriceNonAC.Text = taxable.ToString("F4");
                    txt_sellprice.Text = taxable.ToString("F4");
                }
                else
                {
                    txtSellPriceNonAC.Text ="0.00";
                    txt_sellprice.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
    }
}
