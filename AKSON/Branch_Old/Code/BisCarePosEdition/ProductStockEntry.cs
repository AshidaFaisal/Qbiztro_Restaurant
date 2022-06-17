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
    public partial class ProductStockEntry : Form
    {
        public ProductStockEntry()
        {
            InitializeComponent();
        }
        Codebehind objcode = new Codebehind();
       
        int f = 0;
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";

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

        public void loadcombo()
        {

            DataSet ds = new DataSet();
            ds = objcode.GetItem(1);
            cmb_ProductName.DataSource = ds.Tables[0];
            cmb_ProductName.DisplayMember = "ItemName";
            cmb_ProductName.ValueMember = "Id";
            DataRow dr = ds.Tables[0].NewRow();
            dr["ItemName"] = "--Select One--";
            dr["Id"] = "0";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb_ProductName.SelectedIndex = 0;
            f = 1;

        }
        public void Clear()
        {
            cmb_ProductName.SelectedValue = "0";
            txt_Quantity.Text = "0";
            txt_Remarks.Text = "";

        }
        public void Reset()
        {
            Clear();
            GridClear();
        }
        public void GridClear()
        {
          dgv_ProductStock.Rows.Clear();
        }

        private void ProductStockEntry_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
                DataTable dt1 = new DataTable();
                dt1 = objcode.GetFormUserRights(File.ReadAllText("user.txt"), "ProductStockEntry");
                SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
                UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
                DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
                loadcombo();
                txt_Quantity.Text = "0";
                txt_Remarks.Text = "";
                cmb_ProductName.Focus();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

          int i;
          public string check()
          {

              string status = "1";
              try
              {
                  if (cmb_ProductName.SelectedIndex <= 0)
                  {
                      status = "0";
                      MessageBox.Show("Please select item name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      cmb_ProductName.Focus();

                  }
                  else
                  {
                      if (txt_Quantity.Text == "0")
                      {
                          status = "0";
                          MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          txt_Quantity.Focus();

                      }
                      else
                      {
                          if (txt_Remarks.Text == "0")
                          {
                              status = "0";
                              MessageBox.Show("Please enter Rate", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              txt_Remarks.Focus();

                          }
                          else
                          {
                              status = "1";
                          }
                      }
                  }
                 
              }
              catch (Exception ex)
              {
                  File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
              }
              return status;
          }

          string addst = "0";
          private void btn_Add_Click(object sender, EventArgs e)
          {
              addst = "0";
              string st = check();
              if (addst == "0")
              {
                  dgv_ProductStock.Rows.Add();
                  i = dgv_ProductStock.Rows.Count - 1;
                  dgv_ProductStock[0, i].Value = i + 1;
                  dgv_ProductStock[1, i].Value = cmb_ProductName.Text;
                  dgv_ProductStock[2, i].Value = Convert.ToDouble(txt_Quantity.Text).ToString("F2");
                  dgv_ProductStock[3, i].Value = txt_Remarks.Text;
                  dgv_ProductStock[5, i].Value = cmb_ProductName.SelectedValue.ToString();

              }
              Clear();

          }
      
       
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveStatus == "1")
                {

                    if (dgv_ProductStock.Rows.Count > 0)
                    {

                        DataTable dt = objcode.InsertProductStockEntry(dtp_Date.Value, dgv_ProductStock[5, i].Value.ToString(), dgv_ProductStock[2, i].Value.ToString(), dgv_ProductStock[3, i].Value.ToString());
                        MessageBox.Show("Product Stock Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        MessageBox.Show("Please add Items for Product Stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_ProductName.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Save Product Stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                GridClear();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteStatus == "1")
                {
                   objcode.DeleteProductStockEntry(cmb_ProductName.SelectedValue.ToString());
                    MessageBox.Show("Product Stock Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Delete Product Stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

       

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ProductStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4 && e.RowIndex >= 0)
                {
                    int i = e.RowIndex;

                    dgv_ProductStock.Rows.Remove(dgv_ProductStock.Rows[e.RowIndex]);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

       

    }
}
