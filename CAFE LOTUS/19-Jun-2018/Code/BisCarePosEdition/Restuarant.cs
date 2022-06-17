using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace BisCarePosEdition
{
    public partial class Restuarant : Form
    {
        public Restuarant()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        //string InvoiceStatus;
        //string Empstatus;
        public DialogResult dr1;
        byte[] logo;
        byte[] invHdr;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        int f = 0;
        int EmpStat = 0;
        int Invoicestatus = 0;
        int DealerStatus = 0;
        int CustStatus = 0;
       // int dnstatus = 0;
        public int ChkStatus()
        {

            int msg = 0;
            if ((rd_autoInv.Checked == true) && (txt_inPr.Text != string.Empty))
            {
                Invoicestatus = 1;
            }
            else
            {
                if (rd_manualInv.Checked == true)
                {
                    Invoicestatus = 0;
                }
                else
                {
                    Invoicestatus = 0;
                    msg = 1;
                }
            }

           
            if ((rd_autoEmp.Checked == true) && (txt_empprefix.Text != string.Empty))
            {
                EmpStat = 1;
            }
            else
            {
                if (rd_ManualEmp.Checked == true)
                {
                    EmpStat = 0;
                }
                else
                {
                    EmpStat = 0;
                    msg = 1;
                }
            }

            if ((rd_AutoCust.Checked == true) && (txt_custPrefix.Text != string.Empty))
            {
                CustStatus = 1;
            }
            else
            {
                if (rd_ManualCust.Checked == true)
                {
                    CustStatus = 0;
                }
                else
                {
                    CustStatus = 0;
                    msg = 1;
                }
            }

            if ((rd_AutoDealer.Checked == true) && (txt_DealerPrefix.Text != string.Empty))
            {
                DealerStatus = 1;
            }
            else
            {
                if (rd_ManualDealer.Checked == true)
                {
                    DealerStatus = 0;
                }
                else
                {
                    DealerStatus = 0;
                    msg = 1;
                }
            }

            return msg;
        }
        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int depvalue;
                if (chkdepartwise.Checked == true)
                {

                    depvalue = 1;
                }
                else
                {
                    depvalue = 0;
                }
                //if (SaveStatus == "1")
                //{
                    if (txt_companyname.Text == "")
                    {
                        MessageBox.Show("Please Enter CompanyName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_companyname.Focus();
                    }

                    else
                    {
                        if (txt_telephone.Text == "")
                        {
                            MessageBox.Show("Please Enter TelephoneNo", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_telephone.Focus();
                        }

                        else
                        {
                            if (txt_currency.Text == "")
                            {
                                MessageBox.Show("Please Enter Currency", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_currency.Focus();
                            }
                            else
                            {
                                if (txt_subcurrency.Text == "")
                                {
                                    MessageBox.Show("Please Enter Subcurrency", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_subcurrency.Focus();
                                }

                                else
                                {
                                    if (f == 0)
                                    {
                                        if (OFDLogo.FileName == "NoFile")
                                        {
                                            MessageBox.Show("Please Select A Logo", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            FileStream FS = new FileStream(OFDLogo.FileName, FileMode.Open, FileAccess.Read);
                                            logo = new byte[FS.Length];
                                            FS.Read(logo, 0, Convert.ToInt32(FS.Length));
                                        }
                                        if (OFDInvoiceHeader.FileName == "NoFile")
                                        {
                                            MessageBox.Show("Please Select Invoice Header", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            FileStream FS1 = new FileStream(OFDInvoiceHeader.FileName, FileMode.Open, FileAccess.Read);
                                            invHdr = new byte[FS1.Length];
                                            FS1.Read(invHdr, 0, Convert.ToInt32(FS1.Length));
                                        }
                                        

                                        int chkmsg = ChkStatus();
                                        if (chkmsg == 0)
                                        {

                                            obj.InsertSettings(Invoicestatus, txt_inPr.Text, txt_Inst.Text,EmpStat,txt_empprefix.Text,txt_empstarting.Text,CustStatus,txt_custPrefix.Text,txt_CustStarting.Text,DealerStatus,txt_DealerPrefix.Text,txt_dealerStarting.Text);

                                            obj.InsertRestuarant(txt_companyname.Text, txt_legalname.Text, txt_address.Text, txt_telephone.Text, txt_website.Text, txt_email.Text, txt_currency.Text,
                                                txt_subcurrency.Text, txt_openingbal.Text, logo, invHdr,depvalue.ToString());
                                            MessageBox.Show("Restuarant Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();

                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Enter Prefix Values To Corresponding Automatic Fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }

                                    else
                                    {

                                        if (OFDLogo.FileName != "NoFile")
                                        {

                                            FileStream FS = new FileStream(OFDLogo.FileName, FileMode.Open, FileAccess.Read);
                                            logo = new byte[FS.Length];
                                            FS.Read(logo, 0, Convert.ToInt32(FS.Length));
                                        }
                                        if (OFDInvoiceHeader.FileName != "NoFile")
                                        {
                                            FileStream FS1 = new FileStream(OFDInvoiceHeader.FileName, FileMode.Open, FileAccess.Read);
                                            invHdr = new byte[FS1.Length];
                                            FS1.Read(invHdr, 0, Convert.ToInt32(FS1.Length));
                                        }
                                        obj.UpdateRestuarant(txt_companyname.Text, txt_legalname.Text, txt_address.Text, txt_telephone.Text, txt_website.Text, txt_email.Text, txt_currency.Text,
                                        txt_subcurrency.Text, txt_openingbal.Text, logo, invHdr,depvalue.ToString());
                                        MessageBox.Show("Restuarant Details Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                            }
                        }
                    }
                   
                //}


                //else
                //{
                //    MessageBox.Show("You Do Not Have The Permission To Save Restuarant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
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
        private void Restuarant_Load(object sender, EventArgs e)
        {

            ApplyTheme();
            try
            {
                grp_Inv.Enabled = true;
                grp_emp.Enabled = true;
                grp_cust.Enabled = true;
                grp_dealer.Enabled = true;
                DataTable dt1 = new DataTable();
                dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Restore");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();

                SqlDataReader dr1 = obj.GetSettings();
                if (dr1.Read())
                {
                    if (dr1[1].ToString() == "1")
                    {
                        rd_autoInv.Checked = true;
                    }
                    else
                    {
                        rd_manualInv.Checked = true;
                    }
                    txt_inPr.Text = dr1[3].ToString();
                    txt_Inst.Text = dr1[2].ToString();
                    if (dr1[4].ToString() == "1")
                    {
                        rd_autoEmp.Checked = true;
                    }
                    else
                    {
                        rd_ManualEmp.Checked = true;
                    }
                    txt_empprefix.Text = dr1[6].ToString();
                    txt_empstarting.Text = dr1[5].ToString();
                    if (dr1[10].ToString() == "1")
                    {
                        rd_AutoDealer.Checked = true;
                    }
                    else
                    {
                        rd_ManualDealer.Checked = true;
                    }
                    txt_DealerPrefix.Text = dr1[12].ToString();
                    txt_dealerStarting.Text = dr1[11].ToString();
                    if (dr1[7].ToString() == "1")
                    {
                        rd_AutoCust.Checked = true;
                    }
                    else
                    {
                        rd_ManualCust.Checked = true;
                    }
                    txt_custPrefix.Text = dr1[9].ToString();
                    txt_CustStarting.Text = dr1[8].ToString();
                    txt_Inst.Enabled = false;
                    txt_inPr.Enabled = false;
                    grp_Inv.Enabled = false;
                    grp_emp.Enabled = false;
                    grp_cust.Enabled = false;
                    grp_dealer.Enabled = false;
                    dr1.Close();
                }
                this.ActiveControl = txt_companyname;
                SqlDataReader dr = obj.GetRestuarant();
                if (dr.Read())
                {
                    txt_companyname.Text = dr[1].ToString();
                    txt_address.Text = dr[3].ToString();
                    txt_currency.Text = dr[7].ToString();
                    txt_email.Text = dr[6].ToString();
                    txt_legalname.Text = dr[2].ToString();
                    txt_openingbal.Text = dr[9].ToString();
                    txt_subcurrency.Text = dr[8].ToString();
                    txt_telephone.Text = dr[4].ToString();
                    txt_website.Text = dr[5].ToString();
                    logo = (byte[])dr[10];
                    invHdr = (byte[])dr[11];

                    MemoryStream ms = new MemoryStream((byte[])dr[10]);
                    Pb_logo.Image = Image.FromStream(ms);
                    Pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb_logo.Refresh();

                    MemoryStream ms1 = new MemoryStream((byte[])dr[11]);
                    pbInvoice.Image = Image.FromStream(ms1);
                    pbInvoice.SizeMode = PictureBoxSizeMode.Zoom;
                    pbInvoice.Refresh();
                    rd_autoInv.Enabled = false;
                    rd_manualInv.Enabled = false;
                    f = 1;
                  
                    dr.Close();
                }

                else
                {
                    string FilePath = AppDomain.CurrentDomain.BaseDirectory + "Default Image.jpg";

                    OFDLogo.FileName = FilePath;
                    Pb_logo.ImageLocation = OFDLogo.FileName;

                    OFDInvoiceHeader.FileName = FilePath;
                    pbInvoice.ImageLocation = OFDInvoiceHeader.FileName;
                }
                txt_Inst.Enabled = false;
                txt_inPr.Enabled = false;
                txt_empstarting.Enabled = false;
                txt_empprefix.Enabled = false;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_logobrse_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFDLogo.ShowDialog() == DialogResult.OK)
                {
                    Pb_logo.ImageLocation = OFDLogo.FileName;
                    Pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
                    Pb_logo.Refresh();
                    bttn_invcbrse.Focus();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_invcbrse_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFDInvoiceHeader.ShowDialog() == DialogResult.OK)
                {
                    pbInvoice.ImageLocation = OFDInvoiceHeader.FileName;
                    pbInvoice.SizeMode = PictureBoxSizeMode.Zoom;
                    pbInvoice.Refresh();
                    bttn_save.Focus();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_logoclr_Click(object sender, EventArgs e)
        {
            try
            {
                string FilePath = AppDomain.CurrentDomain.BaseDirectory + "Default Image.jpg";

                OFDLogo.FileName = FilePath;
                Pb_logo.ImageLocation = OFDLogo.FileName;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void bttn_invcclr_Click(object sender, EventArgs e)
        {
            try
            {
                string FilePath = AppDomain.CurrentDomain.BaseDirectory + "Default Image.jpg";



                OFDInvoiceHeader.FileName = FilePath;
                pbInvoice.ImageLocation = OFDInvoiceHeader.FileName;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_companyname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_legalname.Focus();
            }
        }

        private void txt_legalname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_address.Focus();
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_telephone.Focus();
            }
        }

        private void txt_telephone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_website.Focus();
            }
        }

        private void txt_website_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_email.Focus();
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_currency.Focus();
            }
        }

        private void txt_currency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_subcurrency.Focus();
            }
        }

        private void txt_subcurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_openingbal.Focus();
            }
        }

        private void txt_openingbal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_logobrse.Focus();
            }
        }
        int k = 1;
        private void bttn_logobrse_Paint(object sender, PaintEventArgs e)
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

        private void bttn_logobrse_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            bttn_logobrse.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_logobrse_Paint);
        }

        private void bttn_logobrse_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            bttn_logobrse.Paint += new System.Windows.Forms.PaintEventHandler(this.bttn_logobrse_Paint);
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txt_telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void txt_openingbal_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txt_openingbal.Text == "")
                {
                    txt_openingbal.Text = "0";
                }
                string Str = txt_openingbal.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                }
                else
                {
                    MessageBox.Show("Invalid Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_openingbal.Text = "0";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void txt_openingbal_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatValueValidate(e);
        }

        private void rd_manualInv_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_manualInv.Checked == true)
            {
                txt_Inst.Enabled = false;
                txt_inPr.Enabled = false;
                txt_inPr.Focus();
            }


        }

        private void rd_autoInv_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_autoInv.Checked == true)
            {
                txt_Inst.Enabled = true;
                txt_inPr.Enabled = true;
                txt_inPr.Focus();
            }
        }

        private void txt_telephone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //txt_telephone.Text = Convert.ToDouble(txt_telephone.Text).ToString();
                string Str = txt_telephone.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {

                    //txt_telephone.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(txt_telephone.Text), 2, MidpointRounding.AwayFromZero));
                    //txt_telephone.Select(txt_telephone.Text.Length, 0);




                    //////////////txt_totalAmount.Text = Convert.ToString(decimal.Round(Convert.ToDecimal((Convert.ToDouble(txt_Quantity.Text)) * (Convert.ToDouble(txt_Rate.Text))), 2, MidpointRounding.AwayFromZero));

                    //////////////txt_total.Text = string.Format("{0:0.00}", Convert.ToDouble(txt_total.Text));
                  

                }
            }

            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void rd_ManualEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ManualEmp.Checked == true)
            {
                txt_empstarting.Enabled = false;
                txt_empprefix.Enabled = false;
            }
        }

        private void rd_autoEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_autoEmp.Checked == true)
            {
                txt_empstarting.Enabled = true;
                txt_empprefix.Enabled = true;
                txt_empprefix.Focus();
            }
        }

        private void rd_ManualCust_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ManualCust.Checked == true)
            {
                txt_custPrefix.Enabled = false;
                txt_CustStarting.Enabled = false;
                txt_CustStarting.Focus();
            }
        }

        private void rd_AutoCust_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_AutoCust.Checked == true)
            {
                txt_custPrefix.Enabled = true;
                txt_CustStarting.Enabled = true;
                txt_custPrefix.Focus();
            }
        }

        private void rd_ManualDealer_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ManualDealer.Checked == true)
            {
                txt_DealerPrefix.Enabled = false;
                txt_dealerStarting.Enabled = false;
                txt_DealerPrefix.Focus();
            }
        }

        private void rd_AutoDealer_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_AutoDealer.Checked == true)
            {
                txt_DealerPrefix.Enabled = true;
                txt_dealerStarting.Enabled = true;
                txt_DealerPrefix.Focus();
            }
        }
    }
}
