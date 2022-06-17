using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace BisCarePosEdition
{
    public partial class Country : Form
    {
        public Country()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
     
        private void bttn_save_Click(object sender, EventArgs e)
        {
            try
            {
            if (Rb_new.Checked == true)
            {
                if (txt_Coutryname.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Country Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Coutryname.Focus();
                }
                else
                {

                    string s = obj.SaveCountry(txt_Coutryname.Text);
                    if (s == "0")
                    {
                        MessageBox.Show("Country Name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Country successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Coutryname.Text = string.Empty;
                        Rb_new.Checked = true;

                    }
                }
            }
            else
            {
                if (Cmb_Nationality.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please select a Country", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cmb_Nationality.Focus();
                }
                else
                {
                    if (txt_Coutryname.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter Country Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Coutryname.Focus();
                    }
                    else
                    {
                        string s1 = obj.UpdateCountry(txt_Coutryname.Text, Cmb_Nationality.SelectedValue.ToString());
                        if (s1 == "0")
                        {
                            MessageBox.Show("Country Name already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Country successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cmb_Nationality.SelectedIndex = 0;
                            txt_Coutryname.Text = string.Empty;
                            Rb_new.Checked = true;
                            
                        }
                    }
                }
            }
            DataSet ds2 = new DataSet();
            ds2 = obj.GetCountry();
            Cmb_Nationality.DataSource = ds2.Tables[0];
            Cmb_Nationality.DisplayMember = "Country";
            Cmb_Nationality.ValueMember = "Id";
            DataRow drr2 = ds2.Tables[0].NewRow();
            drr2["Country"] = "--Select One--";
            drr2["Id"] = "0";
            ds2.Tables[0].Rows.InsertAt(drr2, 0);
            Cmb_Nationality.SelectedIndex = 0;
            Cmb_Nationality.Enabled = false;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
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
        private void Country_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();

            DataSet ds2 = new DataSet();
            ds2 = obj.GetCountry();
            Cmb_Nationality.DataSource = ds2.Tables[0];
            Cmb_Nationality.DisplayMember = "Country";
            Cmb_Nationality.ValueMember = "Id";
            DataRow drr2 = ds2.Tables[0].NewRow();
            drr2["Country"] = "--Select One--";
            drr2["Id"] = "0";
            ds2.Tables[0].Rows.InsertAt(drr2, 0);
            Cmb_Nationality.SelectedIndex = 0;
            Cmb_Nationality.Enabled = false;
            bttn_delete.Enabled = false;
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Cmb_Nationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            txt_Coutryname.Text = "";
            if (f == 1)
            {
                SqlDataReader dr = obj.GetCountryById(Cmb_Nationality.SelectedValue.ToString());

                if (dr.Read())
                {
                    txt_Coutryname.Text = dr[1].ToString();
                }
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

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            try
            {
            if (Cmb_Nationality.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Country", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cmb_Nationality.Focus();
            }
            else
            {
                obj.DeleteCountry(Cmb_Nationality.SelectedValue.ToString());
                MessageBox.Show("Country successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cmb_Nationality.SelectedIndex = 0;
                txt_Coutryname.Text = string.Empty;
            }
            DataSet ds2 = new DataSet();
            ds2 = obj.GetCountry();
            Cmb_Nationality.DataSource = ds2.Tables[0];
            Cmb_Nationality.DisplayMember = "Country";
            Cmb_Nationality.ValueMember = "Id";
            DataRow drr2 = ds2.Tables[0].NewRow();
            drr2["Country"] = "--Select One--";
            drr2["Id"] = "0";
            ds2.Tables[0].Rows.InsertAt(drr2, 0);
            Cmb_Nationality.SelectedIndex = 0;
            Cmb_Nationality.Enabled = false;
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
            txt_Coutryname.Text = "";
            if (Rb_new.Checked == true)
            {
                Cmb_Nationality.Enabled = false;
                bttn_delete.Enabled = false;
            }
            else
            {
                Cmb_Nationality.Enabled = true;
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Rb_edit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            
            txt_Coutryname.Text = "";
            if (Rb_edit.Checked == true)
            {
                Cmb_Nationality.Enabled = true;
                Cmb_Nationality.SelectedIndex = 0;
                bttn_delete.Enabled = true;
               
            }
            else
            {
                Cmb_Nationality.Enabled = false;
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }
    }
}
