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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        public DialogResult dlgrslt;
        private void Splash_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.timer2.Enabled = true;
            this.timer2.Interval = 4000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblmsg.Text = "Authenticating....";
            lblFirstMsg.Visible = false;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (File.Exists("C:\\PerfLogs\\Microsoft\\windows.file"))
            {
                dlgrslt = DialogResult.OK;
            }
            else
            {
                dlgrslt = DialogResult.Cancel;
            }
            this.Close();
        }
     
    }
}
