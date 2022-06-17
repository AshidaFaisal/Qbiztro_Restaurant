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

namespace BisCarePosEdition
{
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();
        string SaveStatus = "0", UpdateStatus = "0", DeleteStatus = "0";
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int counterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
           try
           {
            if (counterId == 0)
            {

                if (SaveStatus == "1")
                {
                    if (txt_countername.Text == string.Empty)
                    {
                        MessageBox.Show("Please Enter Counter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_countername.Focus();
                    }
                    else
                    {
                        string msg = obj.InsertCounter(txt_countername.Text, txt_remarks.Text);
                        if (msg == "0")
                        {
                            MessageBox.Show("This Counter Name Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.WriteAllText("counter.txt", msg);
                            // obj.SaveWindow(DateTime.Now, "Counter", File.ReadAllText("user.txt"), "Save");
                            MessageBox.Show("Counter Successfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //clear();
                    }
                }
                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Save Counter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                if (UpdateStatus == "1")
                {
                    if (txt_countername.Text == string.Empty)
                    {
                        MessageBox.Show("Please Enter Counter Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_countername.Focus();
                    }
                    else
                    {
                        string msg = obj.UpdateCounter(counterId.ToString(), txt_countername.Text, txt_remarks.Text);
                        // obj.SaveWindow(DateTime.Now, "Counter", File.ReadAllText("user.txt"), "Update");
                        MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear();
                    }
                }
                else
                {
                    MessageBox.Show("You Do Not Have The Permission To Update Counter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private void Counter_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyTheme();
            DataTable dt1 = new DataTable();
            dt1 = obj.GetFormUserRights(File.ReadAllText("user.txt"), "Counter");
            SaveStatus = dt1.Rows[0]["SaveStatus"].ToString();
            UpdateStatus = dt1.Rows[0]["UpdateStatus"].ToString();
            DeleteStatus = dt1.Rows[0]["DeleteStatus"].ToString();


            int counterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
            if (counterId == 0)
            {

            }
            else
            {

                DataTable dt = new DataTable();
                dt = obj.EditCounter(counterId.ToString());
                if (dt.Rows.Count > 0)
                {
                    txt_countername.Text = dt.Rows[0]["counter_name"].ToString();
                    txt_remarks.Text = dt.Rows[0]["remarks"].ToString();

                    f = 1;
                }
            }
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }


        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int k = 0;
        private void btn_Save_Paint(object sender, PaintEventArgs e)
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

        private void btn_Save_MouseEnter(object sender, EventArgs e)
        {
            k = 1;
            btn_Save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Save_Paint);
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            k = 0;
            btn_Save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Save_Paint);

        }

        private void txt_countername_KeyDown(object sender, KeyEventArgs e)
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
                btn_Save.Focus();
            }
        }
    }

}

