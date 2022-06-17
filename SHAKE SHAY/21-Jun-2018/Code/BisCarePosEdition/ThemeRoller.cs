using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BisCarePosEdition
{
    public partial class ThemeRoller : Form
    {
        public ThemeRoller()
        {
            InitializeComponent();
        }
        string FlatStl = "Flat", btnForeClr,btnBackClr,btnMouseOvr,lblForeClr,dgvGridClr,frmBackClr,MBBackClr,MBForColor,MBMouseOvr,MBFlatStyle;
        Theme ObjTheme = new Theme();
        int f = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                btnPreview.BackColor = colorDg.Color;                
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            
        }

        private void ThemeRoller_Load(object sender, EventArgs e)
        {
            ObjTheme.setTheme();
            ApplyTheme();
            cboxFlatStyle.SelectedIndex = 0;
            cboxMBFlatStyle.SelectedIndex = 0;
            btnForeClr = Theme.BtnForeColor;
            btnBackClr = Theme.BtnBackColor;
            btnMouseOvr = Theme.BtnMouseOver;
            lblForeClr = Theme.BtnForeColor;
            dgvGridClr = Theme.DgvBackColor;
            frmBackClr = Theme.FormColor;
            FlatStl = Theme.FlatStyle;
            MBBackClr = Theme.MBBackColor;
            MBForColor = Theme.MBForeColor;
            MBMouseOvr = Theme.MBMouseOvr;
            MBFlatStyle = Theme.MBFlatStyle;
            DataTable dt = ObjTheme.GetThemeNames();
            cboxLoadTheme.DataSource = dt;
            cboxLoadTheme.DisplayMember = "ThemeName";
            cboxLoadTheme.ValueMember = "Id";
            if (Theme.MBFlatStyle == "Flat")
            {
                btnMBPreview.FlatStyle = FlatStyle.Flat;
            }
            if (Theme.MBFlatStyle == "Standard")
            {
                btnMBPreview.FlatStyle = FlatStyle.Standard;
            }
            if (Theme.MBFlatStyle == "Pop up")
            {
                btnMBPreview.FlatStyle = FlatStyle.Popup;
            }
            if (Theme.MBFlatStyle == "System")
            {
                btnMBPreview.FlatStyle = FlatStyle.System;
            }
            btnMBPreview.ForeColor = Color.FromArgb(Convert.ToInt32(Theme.MBForeColor));
            btnMBPreview.BackColor = Color.FromArgb(Convert.ToInt32(Theme.MBBackColor));
            btnMBPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(Theme.MBMouseOvr));
            f = 1;
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

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void cboxFlatStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxFlatStyle.Text == "Flat")
            {
                FlatStl = "Flat";
                btnPreview.FlatStyle = FlatStyle.Flat;                
            }
            if (cboxFlatStyle.Text == "Standard")
            {
                FlatStl = "Standard";
                btnPreview.FlatStyle = FlatStyle.Standard;
            }
            if (cboxFlatStyle.Text == "Pop up")
            {
                FlatStl = "Pop up";
                btnPreview.FlatStyle = FlatStyle.Popup;
            }
            if (cboxFlatStyle.Text == "System")
            {
                FlatStl = "System";
                btnPreview.FlatStyle = FlatStyle.System;
            }
        }

        private void btnFore_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                btnPreview.ForeColor = colorDg.Color;
                btnForeClr = colorDg.Color.ToArgb().ToString();                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                btnPreview.BackColor = colorDg.Color;
                btnBackClr = colorDg.Color.ToArgb().ToString();
            }
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                btnPreview.FlatAppearance.MouseOverBackColor = colorDg.Color;
                btnMouseOvr = colorDg.Color.ToArgb().ToString();
            }
        }

        private void btnlblForeClr_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                lblPreview.ForeColor = colorDg.Color;
                lblForeClr = colorDg.Color.ToArgb().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                dgvPreview.BackgroundColor = colorDg.Color;
                dgvGridClr = colorDg.Color.ToArgb().ToString();                
            }
        }

        private void btnFormColor_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                gboxPreview.BackColor = colorDg.Color;
                frmBackClr = colorDg.Color.ToArgb().ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                string Msg = ObjTheme.NewTheme(txtName.Text, frmBackClr, btnBackClr, btnForeClr, btnMouseOvr, lblForeClr, dgvGridClr, cboxFlatStyle.Text, MBBackClr, MBForColor, MBMouseOvr, MBFlatStyle);
                if (Msg == "Exists")
                {
                    MessageBox.Show("This Theme name already exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Theme Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjTheme.setTheme();
                    ApplyTheme();
                    DataTable dt = ObjTheme.GetThemeDetails(cboxLoadTheme.SelectedValue.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        btnMBPreview.ForeColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBForeColor"]));
                        btnMBPreview.BackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBBackColor"]));
                        btnMBPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBMouseOvr"]));
                    }
                    f = 0;
                    DataTable dt1 = ObjTheme.GetThemeNames();
                    cboxLoadTheme.DataSource = dt1;
                    cboxLoadTheme.DisplayMember = "ThemeName";
                    cboxLoadTheme.ValueMember = "Id";
                    f = 1;
                }
            }
            else
            {
                MessageBox.Show("Please enter a Theme Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboxMBFlatStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMBFlatStyle.Text == "Flat")
            {
                MBFlatStyle = "Flat";
                btnMBPreview.FlatStyle = FlatStyle.Flat;
            }
            if (cboxMBFlatStyle.Text == "Standard")
            {
                MBFlatStyle = "Standard";
                btnMBPreview.FlatStyle = FlatStyle.Standard;
            }
            if (cboxMBFlatStyle.Text == "Pop up")
            {
                MBFlatStyle = "Pop up";
                btnMBPreview.FlatStyle = FlatStyle.Popup;
            }
            if (cboxMBFlatStyle.Text == "System")
            {
                MBFlatStyle = "System";
                btnMBPreview.FlatStyle = FlatStyle.System;
            }
        }

        private void btnMBFore_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                btnMBPreview.ForeColor = colorDg.Color;
                MBForColor = colorDg.Color.ToArgb().ToString();
            }
        }

        private void btnMBBack_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                btnMBPreview.BackColor = colorDg.Color;
                MBBackClr = colorDg.Color.ToArgb().ToString();
            }
        }

        private void btnMBMouse_Click(object sender, EventArgs e)
        {
            DialogResult dg = colorDg.ShowDialog();
            if (dg == DialogResult.OK)
            {
                btnMBPreview.FlatAppearance.MouseOverBackColor = colorDg.Color;
                MBMouseOvr = colorDg.Color.ToArgb().ToString();
            }
        }

        private void chkLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoad.Checked == true)
            {
                cboxLoadTheme.Enabled = true;
                btnSetTheme.Enabled = true;
                btnUpdateTheme.Enabled = true;
            }
            else
            {
                cboxLoadTheme.Enabled = false;
                btnSetTheme.Enabled = false;
                btnUpdateTheme.Enabled = false;
            }
        }

        private void btnSetTheme_Click(object sender, EventArgs e)
        {
            ObjTheme.setSavedTheme(cboxLoadTheme.SelectedValue.ToString());
            MessageBox.Show("Theme Successfully Applied.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ObjTheme.setTheme();
            ApplyTheme();
            DataTable dt = ObjTheme.GetThemeDetails(cboxLoadTheme.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                btnMBPreview.ForeColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBForeColor"]));
                btnMBPreview.BackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBBackColor"]));
                btnMBPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBMouseOvr"]));
            }
        }

        private void cboxLoadTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f == 1)
            {
                DataTable dt = ObjTheme.GetThemeDetails(cboxLoadTheme.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    FlatStl = dt.Rows[0]["FlatStyle"].ToString();
                    btnForeClr = dt.Rows[0]["BtnForeColor"].ToString();
                    btnBackClr = dt.Rows[0]["BtnBackColor"].ToString();
                    btnMouseOvr = dt.Rows[0]["BtnMouseOver"].ToString();
                    lblForeClr = dt.Rows[0]["LblForeColor"].ToString();
                    dgvGridClr = dt.Rows[0]["DgvBackColor"].ToString();
                    frmBackClr = dt.Rows[0]["FormColor"].ToString();
                    MBBackClr = dt.Rows[0]["MBBackColor"].ToString();
                    MBForColor = dt.Rows[0]["MBForeColor"].ToString();
                    MBMouseOvr = dt.Rows[0]["MBMouseOvr"].ToString();
                    MBFlatStyle = dt.Rows[0]["MBFlatStyle"].ToString();
                    gboxPreview.BackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["FormColor"]));
                    lblPreview.ForeColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["LblForeColor"]));
                    btnPreview.ForeColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["BtnForeColor"]));
                    btnPreview.BackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["BtnBackColor"]));
                    btnPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["BtnMouseOver"]));
                    btnMBPreview.ForeColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBForeColor"]));
                    btnMBPreview.BackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBBackColor"]));
                    btnMBPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBMouseOvr"]));
                    dgvPreview.BackgroundColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["DgvBackColor"]));
                    if (dt.Rows[0]["FlatStyle"].ToString() == "Flat")
                    {
                        btnPreview.FlatStyle = FlatStyle.Flat;
                    }
                    if (dt.Rows[0]["FlatStyle"].ToString() == "Standard")
                    {
                        btnPreview.FlatStyle = FlatStyle.Standard;
                    }
                    if (dt.Rows[0]["FlatStyle"].ToString() == "Pop up")
                    {
                        btnPreview.FlatStyle = FlatStyle.Popup;
                    }
                    if (dt.Rows[0]["FlatStyle"].ToString() == "System")
                    {
                        btnPreview.FlatStyle = FlatStyle.System;
                    }

                    if (dt.Rows[0]["MBFlatStyle"].ToString() == "Flat")
                    {
                        btnMBPreview.FlatStyle = FlatStyle.Flat;
                    }
                    if (dt.Rows[0]["MBFlatStyle"].ToString() == "Standard")
                    {
                        btnMBPreview.FlatStyle = FlatStyle.Standard;
                    }
                    if (dt.Rows[0]["MBFlatStyle"].ToString() == "Pop up")
                    {
                        btnMBPreview.FlatStyle = FlatStyle.Popup;
                    }
                    if (dt.Rows[0]["MBFlatStyle"].ToString() == "System")
                    {
                        btnMBPreview.FlatStyle = FlatStyle.System;
                    }
                }
            }
        }

        private void btnUpdateTheme_Click(object sender, EventArgs e)
        {
            if (cboxLoadTheme.SelectedValue.ToString() == "1")
            {
                MessageBox.Show("You cannot update default theme.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Msg = ObjTheme.UpdateTheme(cboxLoadTheme.SelectedValue.ToString(), cboxLoadTheme.Text, frmBackClr, btnBackClr, btnForeClr, btnMouseOvr, lblForeClr, dgvGridClr, cboxFlatStyle.Text, MBBackClr, MBForColor, MBMouseOvr, MBFlatStyle);
                if (Msg == "Exists")
                {
                    MessageBox.Show("This Theme name already exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Theme Successfully Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjTheme.setTheme();
                    ApplyTheme();
                    DataTable dt = ObjTheme.GetThemeDetails(cboxLoadTheme.SelectedValue.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        btnMBPreview.ForeColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBForeColor"]));
                        btnMBPreview.BackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBBackColor"]));
                        btnMBPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(Convert.ToInt32(dt.Rows[0]["MBMouseOvr"]));
                    }
                }
            }
        }
    }
}
