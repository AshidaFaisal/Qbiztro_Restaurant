using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;

namespace BisCarePosEdition
{
    public partial class DeleteKot : Form
    {
        public DeleteKot()
        {
            InitializeComponent();
        }
        Codebehind ObjCode = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        int f = 0,g=0;
        public void FloatValueValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
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
        private void SearchKot_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "DeleteKOT");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();


            this.ActiveControl = cboxTable;
            DataSet ds = new DataSet();
            ds = ObjCode.GetToken();
            cboxToken.DataSource = ds.Tables[0];
            cboxToken.DisplayMember = "Token";         
            DataRow dr = ds.Tables[0].NewRow();
            dr["Token"] = "--Select One--";           
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboxToken.SelectedIndex = 0;

            g = 1;

            DataSet ds1 = new DataSet();
            ds1 = ObjCode.GetTable();
            cboxTable.DataSource = ds1.Tables[0];
            cboxTable.DisplayMember = "TableName";
            cboxTable.ValueMember = "Id";
            DataRow dr1 = ds1.Tables[0].NewRow();
            dr1["TableName"] = "--Select One--";
            dr1["Id"] = "0";
            ds1.Tables[0].Rows.InsertAt(dr1, 0);
            cboxTable.SelectedIndex = 0;        

           
             
          grpTable.Enabled = true;
          grpToken.Enabled = false;
          
            f = 1;
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    dgv_SearchKOT.Rows.Clear();
        //    string queryStr = string.Empty;


        //    queryStr = "SELECT     dbo.tbKotMaster.Date, dbo.tbKotMaster.CustomerStatus, dbo.tbKotMaster.Token, dbo.tbKotMaster.TableId, dbo.tbKotMaster.WaiterId, dbo.tbKotMaster.CustomerName,dbo.tbKotDetails.kotId, dbo.tbKotDetails.ItemId, dbo.tbItem.ItemCode, dbo.tbItem.ItemName, dbo.tbKotDetails.Rate, dbo.tbKotDetails.Quantity,dbo.tbKotDetails.Amount, dbo.tbKotDetails.Id ";

        //        queryStr = queryStr + "FROM dbo.tbKotDetails INNER JOIN dbo.tbKotMaster ON dbo.tbKotDetails.kotId = dbo.tbKotMaster.Id INNER JOIN dbo.tbItem ON dbo.tbKotDetails.ItemId = dbo.tbItem.Id ";
        //        if (chkToken.Checked == true)
        //        {
        //            queryStr = queryStr + " and dbo.tbKotMaster.Token='"+cboxToken.Text+"'";
        //        }
        //        if (chkKOT.Checked == true)
        //        {
        //            queryStr = queryStr + " and dbo.tbKotDetails.kotId=" + txt_Kot.Text;
        //        }
        //        if (chkTable.Checked == true)
        //        {
        //            queryStr = queryStr + " and  dbo.tbKotMaster.TableId=" + cboxTable.SelectedValue.ToString();
        //        }
        //        if (chkWaiter.Checked == true)
        //        {
        //            queryStr = queryStr + " and  dbo.tbKotMaster.WaiterId=" + cboxWaiter.SelectedValue.ToString();
        //        }
        //        DataTable dt = ObjCode.KOTSearch(queryStr);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            dgv_SearchKOT.Rows.Add();
        //            dgv_SearchKOT[0, i].Value = i + 1;
        //            dgv_SearchKOT[1, i].Value = dt.Rows[i]["kotId"].ToString();
        //            if (dt.Rows[i]["CustomerStatus"].ToString() == "1")
        //            {
        //                dgv_SearchKOT[2, i].Value= "Dine In";
        //            }
        //            if (dt.Rows[i]["CustomerStatus"].ToString() == "2")
        //            {
        //                dgv_SearchKOT[2, i].Value = "Take Away";
        //            }
                   
        //            dgv_SearchKOT[3, i].Value = dt.Rows[i]["ItemCode"].ToString();
        //            dgv_SearchKOT[4, i].Value = dt.Rows[i]["ItemName"].ToString();
        //            dgv_SearchKOT[5, i].Value = dt.Rows[i]["Rate"].ToString();
        //            dgv_SearchKOT[6, i].Value = dt.Rows[i]["Quantity"].ToString();
        //            dgv_SearchKOT[7, i].Value = dt.Rows[i]["Amount"].ToString();
        //            dgv_SearchKOT[8, i].Value = dt.Rows[i]["Date"].ToString();
        //            dgv_SearchKOT[9, i].Value = dt.Rows[i]["CustomerName"].ToString();
        //            dgv_SearchKOT[10, i].Value = dt.Rows[i]["ID"].ToString();
        //        }
            
        //}

        //private void chkKOT_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkKOT.Checked == true)
        //    {
        //        grp_Kot.Enabled = true;
        //    }
        //    else
        //    {
        //        grp_Kot.Enabled = false;
        //    }

        //}

        //private void chkToken_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkToken.Checked == true)
        //    {
        //        grpToken.Enabled = true;
        //    }
        //    else
        //    {
        //        grpToken.Enabled = false;
        //    }
        //}

        //private void chkTable_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkTable.Checked == true)
        //    {
        //        grpTable.Enabled = true;
        //    }
        //    else
        //    {
        //        grpTable.Enabled = false;
        //    }

        //}

        //private void chkWaiter_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkWaiter.Checked == true)
        //    {
        //        grpWaiter.Enabled = true;
        //    }
        //    else
        //    {
        //        grpWaiter.Enabled = false;
        //    }
        //}

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int t1 = 0;
        private void cboxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboxTable.SelectedIndex == 0)
            //{
            //    cboxTableKOT.Text = "";
            //}
           try
           {
            dgv_SearchKOT.Rows.Clear();
            cboxTableKOT.Text = "";
            dgv_test.Rows.Clear();
            if (f == 1)
            {
                DataSet ds1 = new DataSet();
                ds1 = ObjCode.GetKOTByTable(cboxTable.SelectedValue.ToString());
                cboxTableKOT.DataSource = ds1.Tables[0];
                cboxTableKOT.DisplayMember = "Id";
                cboxTableKOT.ValueMember = "Id";
              
                t1 = 1;               
            }
           }
           catch (Exception ex)
           {
               File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
           }


        }
        int t2 = 0;
        private void cboxToken_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            cboxTokenKOT.Text = "";
            dgv_SearchKOT.Rows.Clear();
            dgv_test.Rows.Clear();
            if (g == 1)
            {
                DataSet ds1 = new DataSet();
                ds1 = ObjCode.GetKOTByToken(cboxToken.Text);
                cboxTokenKOT.DataSource = ds1.Tables[0];
                cboxTokenKOT.DisplayMember = "Id";
                cboxTokenKOT.ValueMember = "Id";
              

                //grpTable.Enabled = false;

               

                t2 = 1;
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void cboxTableKOT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            dgv_SearchKOT.Rows.Clear();
            if((t1==1))
            {
            DataTable dt = ObjCode.KOTSearchByKotID(cboxTableKOT.SelectedValue.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_SearchKOT.Rows.Add();
                dgv_SearchKOT[0, i].Value = i + 1;
                dgv_SearchKOT[1, i].Value = dt.Rows[i]["Id"].ToString();
                dgv_SearchKOT[2, i].Value = dt.Rows[i]["ItemCode"].ToString();
                dgv_SearchKOT[3, i].Value = dt.Rows[i]["ItemName"].ToString();
                dgv_SearchKOT[4, i].Value = dt.Rows[i]["Quantity"].ToString();
                dgv_SearchKOT[5, i].Value = dt.Rows[i]["Date"].ToString();
            }
               
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


            
        }

        private void cboxTokenKOT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            dgv_SearchKOT.Rows.Clear();
            if (t2 == 1)
            {
                DataTable dt = ObjCode.KOTSearchByKotID(cboxTokenKOT.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_SearchKOT.Rows.Add();
                    dgv_SearchKOT[0, i].Value = i + 1;
                    dgv_SearchKOT[1, i].Value = dt.Rows[i]["Id"].ToString();
                    dgv_SearchKOT[2, i].Value = dt.Rows[i]["ItemCode"].ToString();
                    dgv_SearchKOT[3, i].Value = dt.Rows[i]["ItemName"].ToString();
                    dgv_SearchKOT[4, i].Value = dt.Rows[i]["Quantity"].ToString();
                    dgv_SearchKOT[5, i].Value = dt.Rows[i]["Date"].ToString();
                }

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }
        string custname, custmon, custemil, totalamnt, billingstatus, tableid, waiterid, customerstatus, Token, kotno, kotid;
        DateTime date;
        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
            if (DeleteStatus == "1")
            {
                if (dgv_SearchKOT.Rows.Count > 0)
                {

                    SqlDataReader dt = ObjCode.GetAllKOTMasterDetails(dgv_SearchKOT[1, 0].Value.ToString());
                    if (dt.Read())
                    {
                        custname = dt[1].ToString();
                        custmon = dt[3].ToString();
                        custemil = dt[2].ToString();
                        totalamnt = dt[4].ToString();
                        billingstatus = dt[5].ToString();
                        tableid = dt[6].ToString();
                        waiterid = dt[7].ToString();
                        customerstatus = dt[8].ToString();
                        Token = dt[9].ToString();
                        date = Convert.ToDateTime(dt[10].ToString());
                        kotno = dt[0].ToString();
                    dt.Close();
                    }
                    string id = ObjCode.InsertDeletedKotMaster(custname, custmon, custemil, totalamnt, billingstatus, tableid, waiterid, customerstatus, Token, Convert.ToDateTime(date), kotno);
                    DataTable dt1 = ObjCode.GetAllKOTDetails(dgv_SearchKOT[1, 0].Value.ToString());
                    for (int s = 0; s < dt1.Rows.Count; s++)
                    {
                        dgv_test.Rows.Add();
                        dgv_test[0, s].Value = dt1.Rows[s]["kotId"].ToString();
                        dgv_test[1, s].Value = dt1.Rows[s]["ItemId"].ToString();
                        dgv_test[2, s].Value = dt1.Rows[s]["Quantity"].ToString();
                        dgv_test[3, s].Value = dt1.Rows[s]["Rate"].ToString();
                        dgv_test[4, s].Value = dt1.Rows[s]["Amount"].ToString();
                    }
                    for (int j = 0; j < dgv_test.Rows.Count; j++)
                    {
                        ObjCode.InsertDeletedKotDetail(id, dgv_test[1, j].Value.ToString(), dgv_test[2, j].Value.ToString(), dgv_test[3, j].Value.ToString(), dgv_test[4, j].Value.ToString());
                    }
                    ObjCode.DeleteKot(dgv_SearchKOT[1, 0].Value.ToString());
                    MessageBox.Show("KOT successfully deleted ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a KOT for delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cboxTable.SelectedIndex = 0;
                //cboxToken.Text = "";

                DataSet ds = new DataSet();
                ds = ObjCode.GetToken();
                cboxToken.DataSource = ds.Tables[0];
                cboxToken.DisplayMember = "Token";
                DataRow dr = ds.Tables[0].NewRow();
                dr["Token"] = "--Select One--";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cboxToken.SelectedIndex = 0;

                DataSet ds1 = new DataSet();
                ds1 = ObjCode.GetTable();
                cboxTable.DataSource = ds1.Tables[0];
                cboxTable.DisplayMember = "TableName";
                cboxTable.ValueMember = "Id";
                DataRow dr1 = ds1.Tables[0].NewRow();
                dr1["TableName"] = "--Select One--";
                dr1["Id"] = "0";
                ds1.Tables[0].Rows.InsertAt(dr1, 0);
                cboxTable.SelectedIndex = 0;

                //g = 1;
                dgv_SearchKOT.Rows.Clear();
                cboxTableKOT.Text = "";
                cboxTokenKOT.Text = "";
                rd_table.Checked = true;
                cboxTable.Focus();

            }
            else
            {

                MessageBox.Show("You Do Not Have The Permission To Delete KOT", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        
        private void rd_table_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_table.Checked == true)
            {
                grpTable.Enabled = true;
                grpToken.Enabled = false;
            }
            else
            {
                grpTable.Enabled = false;
                grpToken.Enabled = true;
            }
        }

        private void rd_token_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_token.Checked == true)
            {
                grpTable.Enabled = false;
                grpToken.Enabled = true;
            }
            else
            {
                grpTable.Enabled = true;
                grpToken.Enabled = false;
            }
        }

        private void rd_table_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cboxTable.Focus();
            }
        }

        private void rd_token_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cboxToken.Focus();
            }
        }

        private void cboxTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cboxTableKOT.Focus();
            }
        }

        private void cboxToken_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cboxTokenKOT.Focus();
            }
        }

        private void cboxTableKOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dgv_SearchKOT.Focus();
            }
        }

        private void cboxTokenKOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dgv_SearchKOT.Focus();
            }
        }

        private void dgv_SearchKOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_del.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rd_token_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rd_token.Checked == true)
            {
                grpTable.Enabled = false;
                grpToken.Enabled = true;
                cboxToken.SelectedIndex = 0;
                cboxTable.SelectedIndex = 0; 
               
            }
            else
            {
                grpTable.Enabled = true;
                grpToken.Enabled = false;
            }
        }

        private void rd_table_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rd_table.Checked == true)
            {
                grpTable.Enabled = true;
                grpToken.Enabled = false;
                cboxToken.SelectedIndex = 0;
                cboxTable.SelectedIndex = 0; 
                cboxTable.Focus();
            }
            else
            {
                grpTable.Enabled = false;
                grpToken.Enabled = true;
                cboxToken.Focus();

            }
        }
        int k = 0;
        private void btn_del_Paint(object sender, PaintEventArgs e)
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

        private void btn_del_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_del.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_del_Paint);
        }

        private void btn_del_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_del.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_del_Paint);
        }
    }
}
