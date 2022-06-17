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
    public partial class frm_pendingkotprint : Form
    {
        public frm_pendingkotprint()
        {
            InitializeComponent();
        }

        private void frm_pendingkotprint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
