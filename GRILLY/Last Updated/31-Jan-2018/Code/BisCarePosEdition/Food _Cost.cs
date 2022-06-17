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
    public partial class Food__Cost : Form
    {
        public Food__Cost()
        {
            InitializeComponent();
        }
        Codebehind objcode = new Codebehind();
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
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        int f = 0;
        private void Food__Cost_Load(object sender, EventArgs e)
        {
           
            try
            {

                ApplyTheme();
                this.ActiveControl = cmb_mainitem_id;
                DataTable dt1 = new DataTable();
                dt1 = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "ItemMapping");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                DataSet ds = new DataSet();
                ds = objcode.GETMainitemid();
                cmb_mainitem_id.DataSource = ds.Tables[0];
                cmb_mainitem_id.DisplayMember = "ItemName";
                cmb_mainitem_id.ValueMember = "Id";
                DataRow dr1 = ds.Tables[0].NewRow();
                dr1["ItemName"] = "--Select One--";
                dr1["Id"] = "0";
                ds.Tables[0].Rows.InsertAt(dr1, 0);
                cmb_mainitem_id.SelectedIndex = 0;
                DataSet ds1 = new DataSet();
                ds1 = objcode.GETSubitemid();
                cmb_subitem_id.DataSource = ds1.Tables[0];
                cmb_subitem_id.DisplayMember = "ItemName";
                cmb_subitem_id.ValueMember = "Id";
                DataRow dr2 = ds1.Tables[0].NewRow();
                dr2["ItemName"] = "--Select One--";
                dr2["Id"] = "0";
                ds1.Tables[0].Rows.InsertAt(dr2, 0);
                cmb_subitem_id.SelectedIndex = 0;
                f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void cmb_mainitem_id_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmb_mainitem_id.DroppedDown)
            {
                cmb_mainitem_id.Focus();
            }
        }
        double pr = 0;
        double qt = 0;
        double fc = 0;
        private void Calculate_Foodcost()
        {
            for (int i = 0; i < Gv_itemmapp.Rows.Count; i++)
            {
                fc += Convert.ToDouble(Gv_itemmapp["FoodCost", i].Value.ToString());
            }
            txt_cost.Text = fc.ToString("F2");
        }
        private void cmb_mainitem_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            fc = 0;
            try
            {
                if (f == 1 && Convert.ToInt32(cmb_mainitem_id.SelectedValue) > 0)
                {
                    DataTable dt = objcode.SelectSubItems(Convert.ToInt32(cmb_mainitem_id.SelectedValue));
                    Gv_itemmapp.Rows.Clear();
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Gv_itemmapp.Rows.Add();
                            Gv_itemmapp[0, i].Value = dt.Rows[i]["Id"].ToString();
                            Gv_itemmapp[1, i].Value = dt.Rows[i]["ItemName"].ToString();
                            if (dt.Rows[i]["Unit"].ToString().ToLower() == "kg")
                                Gv_itemmapp[2, i].Value = "gram";
                            else if (dt.Rows[i]["Unit"].ToString().ToLower() == "gram")
                                Gv_itemmapp[2, i].Value = "gram";
                            else
                                Gv_itemmapp[2, i].Value =  dt.Rows[i]["Unit"].ToString();

                            Gv_itemmapp[3, i].Value = dt.Rows[i]["Quantity"].ToString();
                            Gv_itemmapp[4, i].Value = dt.Rows[i]["ProductId"].ToString();
                            Gv_itemmapp[5, i].Value = dt.Rows[i]["IngredientId"].ToString();
                            Gv_itemmapp["Costprice", i].Value = dt.Rows[i]["LastCostPrice"].ToString() == "" ? "0" : dt.Rows[i]["LastCostPrice"].ToString();
                            if (dt.Rows[i]["Unit"].ToString().ToLower() =="kg") 
                            Gv_itemmapp["FoodCost", i].Value = ((Convert.ToDouble(Gv_itemmapp["Costprice", i].Value) /1000) * 
                                Convert.ToDouble(Gv_itemmapp[3, i].Value)).ToString("F2");
                            else  if (dt.Rows[i]["Unit"].ToString().ToLower() == "gram")
                                Gv_itemmapp["FoodCost", i].Value = ((Convert.ToDouble(Gv_itemmapp["Costprice", i].Value) / 1000) *
                                Convert.ToDouble(Gv_itemmapp[3, i].Value)).ToString("F2");
                            else
                                Gv_itemmapp["FoodCost", i].Value = ((Convert.ToDouble(Gv_itemmapp["Costprice", i].Value)) *
                                Convert.ToDouble(Gv_itemmapp[3, i].Value)).ToString("F2");

                        }
                    Calculate_Foodcost();
                    } 
                }
                fc = 0;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btn_savefood_Click(object sender, EventArgs e)
        {
            if (Gv_itemmapp.Rows.Count > 0)
            {
                for (int i = 0; i < Gv_itemmapp.Rows.Count; i++)
                {
                    objcode.insertfoodcost(Gv_itemmapp["FoodCost", i].Value.ToString(), Convert.ToInt32(Gv_itemmapp[4, i].Value), Convert.ToInt32(Gv_itemmapp[5, i].Value));
                }
                objcode.updatefoodcost(txt_cost.Text.ToString()==""?"0":txt_cost.Text.ToString(),Convert.ToInt32(cmb_mainitem_id.SelectedValue.ToString()));
                MessageBox.Show("Food Cost Saved Sucessfully.", "message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
