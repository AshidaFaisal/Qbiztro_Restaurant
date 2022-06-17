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
public partial class NewForm : Form
{
public NewForm()
{
InitializeComponent();
}
Codebehind obj = new Codebehind();
string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
public int btnBackClr, lblForeClr;
private void btnFormColor_Click(object sender, EventArgs e)
{

DialogResult dg = colorDialog.ShowDialog();
if (dg == DialogResult.OK)
{
    btnFormColor.BackColor = colorDialog.Color;
    btnBackClr = colorDialog.Color.ToArgb();
}
}

private void chk_status_CheckedChanged(object sender, EventArgs e)
{

}

private void NewForm_Load(object sender, EventArgs e)
{

Cmb_formname.Enabled = false;
DataTable dt1 = new DataTable();
dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "NewForm");
SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();



DataSet ds5 = new DataSet();
ds5 = obj.getforms();
Cmb_formname.DataSource = ds5.Tables[0];
Cmb_formname.DisplayMember = "Formname";
Cmb_formname.ValueMember = "Id";
DataRow dr5 = ds5.Tables[0].NewRow();
dr5["Formname"] = "--Select One--";
dr5["Id"] = "0";
ds5.Tables[0].Rows.InsertAt(dr5, 0);
Cmb_formname.SelectedIndex = 0;

    DataSet ds6 = new DataSet();
    ds6 = obj.getparents();
    cbox_masters.Enabled = true;
    cbox_masters.DataSource = ds6.Tables[0];
    cbox_masters.DisplayMember = "ParentName";
    cbox_masters.ValueMember = "ParentId";
    DataRow dr7 = ds6.Tables[0].NewRow();
    dr7["ParentName"] = "--Select One--";
    dr7["ParentId"] = "0";
    ds6.Tables[0].Rows.InsertAt(dr7, 0);
    cbox_masters.SelectedIndex = 0;
    string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
    pb_photo.ImageLocation = FilePath;
    pb_photo.SizeMode = PictureBoxSizeMode.CenterImage;
    txt_formname.Focus();


}

private void btnlblForeClr_Click(object sender, EventArgs e)
{
DialogResult dres = colorDialog.ShowDialog();
if (dres == DialogResult.OK)
{
    lbl_forecolor.ForeColor = colorDialog.Color;
    lblForeClr = colorDialog.Color.ToArgb();

}
}

private void btn_cancel_Click(object sender, EventArgs e)
{
this.Close();
}

private void Rb_new_CheckedChanged(object sender, EventArgs e)
{
if (Rb_new.Checked == true)
{
    txt_formname.Text = "";
    //txt_parentid.Text = "";
    btnFormColor.BackColor = Button.DefaultBackColor;
    lbl_forecolor.ForeColor = Label.DefaultForeColor;
    chk_status.Checked = false;
    Cmb_formname.Text = "---select---";
    Cmb_formname.Enabled = false;
    Cmb_formname.SelectedIndex = 0;
    cbox_masters.SelectedIndex = 0;

}
}

private void Rb_edit_CheckedChanged(object sender, EventArgs e)
{
if (Rb_edit.Checked == true)
{
    Cmb_formname.Enabled = true;
    Cmb_formname.Focus();
    DataSet ds5 = new DataSet();
    ds5 = obj.getforms();
    Cmb_formname.DataSource = ds5.Tables[0];
    Cmb_formname.DisplayMember = "Formname";
    Cmb_formname.ValueMember = "Id";
    DataRow dr5 = ds5.Tables[0].NewRow();
    dr5["Formname"] = "--Select One--";
    dr5["Id"] = "0";
    ds5.Tables[0].Rows.InsertAt(dr5, 0);
    txt_formname.Text = "";
    cbox_masters.SelectedIndex = 0; 
    Cmb_formname.SelectedIndex = 0;
                
}
if (Rb_new.Checked == true)
{
    txt_formname.Focus();
    txt_formname.Text = "";
    //txt_parentid.Text = "";
    btnFormColor.BackColor = Button.DefaultBackColor;
    lbl_forecolor.ForeColor = Label.DefaultForeColor;
}
pb_photo.Image = null;
pb_photo.Refresh();
string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
pb_photo.ImageLocation = FilePath;
pb_photo.SizeMode = PictureBoxSizeMode.CenterImage;

}

private void txt_formname_KeyDown(object sender, KeyEventArgs e)
{
if (e.KeyData == Keys.Enter)
{
    if (txt_formname.Text == "")
    {
        txt_formname.Focus();
    }
    else
    {
        cbox_masters.Focus();               
    }
}

}

private void btnFormColor_KeyDown(object sender, KeyEventArgs e)
{
if (e.KeyData == Keys.Enter)
{
    btnlblForeClr.Focus();
}
}

private void btnlblForeClr_KeyDown(object sender, KeyEventArgs e)
{
if (e.KeyData == Keys.Enter)
{
    chk_status.Focus();
}
}

private void chk_status_KeyDown(object sender, KeyEventArgs e)
{
if (e.KeyData == Keys.Enter)
{
    btn_browse.Focus();
}
}

private void btn_browse_Click(object sender, EventArgs e)
{
openFileDialog1.ShowDialog();
if (openFileDialog1.FileName != "openFileDialog1")
{
    pb_photo.ImageLocation = openFileDialog1.FileName;
}
}
int i;
public string check()
{

    string Chkstatus = "1";
    try
    {
        if (txt_formname.Text == "")
        {
            MessageBox.Show("Please enter Form Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txt_formname.Focus();
            Chkstatus = " 0";
        }
        if (txt_displayname.Text == "")
        {
            MessageBox.Show("Please enter Display Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txt_formname.Focus();
            Chkstatus = " 0";
        }
        else
        {
            if (cbox_masters.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter the Form Master Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbox_masters.Focus();
                Chkstatus = "0";
            }
                 
        else
        {
            Chkstatus = "1";
        }
        }
    }
    catch (Exception ex)
    {
        File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
    }
    return Chkstatus;
}
public byte[] img;
public string status,msg,user;
private void btn_save_Click(object sender, EventArgs e)
{
          
try
{
    user = File.ReadAllText("user.txt");
    if (Rb_new.Checked == true)
    {
        if (openFileDialog1.FileName == "openFileDialog1")
        {
            string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
            FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            img = new byte[FS.Length];
            FS.Read(img, 0, Convert.ToInt32(FS.Length));
            pb_photo.ImageLocation = FilePath;
            pb_photo.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        else
            if (openFileDialog1.FileName != "NoFile")
            {
                FileStream FS = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                img = new byte[FS.Length];
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
            }
        if (chk_status.Checked == true)
        {
            status = "1";
        }
        else
        {
            status = "0";
        }
        if (btnBackClr == 0)
        { 
            btnBackClr = -8388544;
        }
        if (lblForeClr == 0)
        {
            lblForeClr = -12550016;
        }
        string st= check();
        if(st=="1")
        {
            if (SaveStatus == "1")
            {

                msg = obj.insertorupdateform("0", txt_formname.Text.ToString(), cbox_masters.SelectedValue.ToString(), img, status.ToString(), btnBackClr, lblForeClr, "1",user,txt_displayname.Text.ToString());

                if (msg == "1")
                {
                    MessageBox.Show("New Form Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_formname.Text = "";
                    pb_photo.Image = null;
                    pb_photo.Refresh();
                    string FilePaths = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
                    pb_photo.ImageLocation = FilePaths;
                    pb_photo.SizeMode = PictureBoxSizeMode.CenterImage;
                    Rb_new.Checked = true;
                    Cmb_formname.SelectedIndex = 0;
                    cbox_masters.SelectedIndex = 0;
                }
            }
        }
    }
    else
    {
        if (Rb_edit.Checked == true)
        {
            if (chk_status.Checked == true)
            {
                status = "1";
            }
            else
            {
                status = "0";
            }
            ImageConverter converter = new ImageConverter();
            img = (byte[])converter.ConvertTo(pb_photo.Image, typeof(byte[]));
            //if (openFileDialog1.FileName == "openFileDialog1")
            //{
            //    string FilePath = Application.StartupPath +                  " \\formimage\\" + "DefaultImage.ico";
            //    FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            //    img = new byte[FS.Length];
            //    FS.Read(img, 0, Convert.ToInt32(FS.Length));
            //    pb_photo.ImageLocation = FilePath;
            //    pb_photo.SizeMode = PictureBoxSizeMode.CenterImage;
                            
            //}
            //else
            //    if (openFileDialog1.FileName != "NoFile")
            //    {
            //        FileStream FS = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            //        img = new byte[FS.Length];
            //        FS.Read(img, 0, Convert.ToInt32(FS.Length));
            //    }
            if (UpdateStatus == "1")
            {
                msg = obj.insertorupdateform(Cmb_formname.SelectedValue.ToString(), txt_formname.Text.ToString(), cbox_masters.SelectedValue.ToString(), img, status, Convert.ToInt32(btnFormColor.BackColor.ToArgb()), Convert.ToInt32(lbl_forecolor.ForeColor.ToArgb()), "2", user, txt_displayname.Text.ToString());
            }
            if (msg == "2")
            {
                MessageBox.Show("New Form Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
               
                //pb_photo.Image = null;
                pb_photo.Refresh();
                string FilePath = Application.StartupPath + " \\formimage\\" + "DefaultImage.ico";
                pb_photo.ImageLocation = FilePath;
                pb_photo.SizeMode = PictureBoxSizeMode.CenterImage;
                Rb_new.Checked = true;   
                //txt_formname.Text = "";
                //cbox_masters.SelectedIndex = 0;
            }
        }
    }
}
catch (Exception ex)
{
    File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
}
}
       

private void Cmb_formname_SelectedIndexChanged(object sender, EventArgs e)
{
if (Rb_edit.Checked == true)
{
    if(Convert.ToDouble( Cmb_formname.SelectedValue.ToString())>0)
    {
    DataTable dt = new DataTable();
    dt = obj.getformproperties(Cmb_formname.SelectedValue.ToString());
    if (dt.Rows.Count > 0)
    {
        txt_formname.Text = dt.Rows[0]["Formname"].ToString();
        txt_displayname.Text = dt.Rows[0]["DisplayName"].ToString();
        cbox_masters.SelectedValue = dt.Rows[0]["ParentId"].ToString();
        btnFormColor.BackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["ButtonBackColor"]));
        lbl_forecolor.ForeColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["LabelForeColor"]));
        if (dt.Rows[0]["Status"].ToString() == "1")
        {
            chk_status.Checked = true;
        }
        else
        {
            chk_status.Checked = false;
        }
        if (dt.Rows[0]["Formicon"] != "0x")
        {
            img = (byte[])dt.Rows[0]["Formicon"];
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Formicon"]);
            if (ms.Length == 0)
            {
                string FilePath = Application.StartupPath + "\\formimage\\"+"DefaultImage.ico";
                pb_photo.ImageLocation = FilePath;
            }
            else
            {
                pb_photo.Image = Image.FromStream(ms);
                pb_photo.SizeMode = PictureBoxSizeMode.CenterImage;
                pb_photo.Refresh();
            }
            }
            }     
    }
}
}

private void Btn_Delete_Click(object sender, EventArgs e)
{
try
{
    if (Rb_edit.Checked == true)
    {
        if (DeleteStatus == "1")
        {
            if (Convert.ToDouble(Cmb_formname.SelectedValue.ToString()) > 0)
            {
                obj.deleteform(Cmb_formname.SelectedValue.ToString());
                MessageBox.Show("Form deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds5 = new DataSet();
                ds5 = obj.getforms();
                Cmb_formname.DataSource = ds5.Tables[0];
                Cmb_formname.DisplayMember = "Formname";
                Cmb_formname.ValueMember = "Id";
                DataRow dr5 = ds5.Tables[0].NewRow();
                dr5["Formname"] = "--Select One--";
                dr5["Id"] = "0";
                ds5.Tables[0].Rows.InsertAt(dr5, 0);
                txt_formname.Text = "";
                Rb_new.Checked = true;
                Cmb_formname.SelectedIndex = 0;
                cbox_masters.SelectedIndex = 0;
               

            }
            else
            {
                MessageBox.Show("Please select a Form Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_formname.Focus();
            }
        }
        else
        {

            MessageBox.Show("You Do Not Have The Permission To Delete This Form", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
catch (Exception ex)
{
    File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
}
}

private void txt_parentid_KeyDown(object sender, KeyEventArgs e)
{
if (e.KeyData == Keys.Enter)
{
    btnFormColor.Focus();
}
}

private void cbox_masters_SelectedIndexChanged(object sender, EventArgs e)
{
    cbox_masters.Focus();
}
}
}
