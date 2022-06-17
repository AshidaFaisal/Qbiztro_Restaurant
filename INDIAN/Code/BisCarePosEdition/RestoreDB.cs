using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;

namespace BisCarePosEdition
{
    public partial class RestoreDB : Form
    {
        public RestoreDB()
        {
            InitializeComponent();
        }
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        Codebehind obj = new Codebehind();
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
        private void RestoreDB_Load(object sender, EventArgs e)
        {try
        {
            ApplyTheme();
            this.ActiveControl = txtPath;
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Restore");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();
        }
        catch (Exception ex)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
        }  
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
            if (ofdPath.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Path.GetExtension(ofdPath.FileName).ToString() == ".bak")
                {
                    txtPath.Text = ofdPath.FileName.ToString();
                }
                else
                {
                    MessageBox.Show("You Cannot Select this Type of File for Restore", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPath.Clear();
                }

            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public DialogResult dr;
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
            if (SaveStatus == "1")
            {
                if (txtPath.Text != "")
                {

                    obj.RestoreDB(txtPath.Text);
                    MessageBox.Show("Database Successfully Restored \n Please Restart Software", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Select The Backup Path", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("You Do Not Have The Permission To Restore DataBase", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_PaddingChanged(object sender, EventArgs e)
        {

        }
        int k=0;
        private void btnBrowse_Paint(object sender, PaintEventArgs e)
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


 

        private void btnBrowse_MouseEnter(object sender, EventArgs e)
        {
        k = 1;
        btnBrowse.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBrowse_Paint);
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btnBrowse.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBrowse_Paint);
        }
        
    }
}
