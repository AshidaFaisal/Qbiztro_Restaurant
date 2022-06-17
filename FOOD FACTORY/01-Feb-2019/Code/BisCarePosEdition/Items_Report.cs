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
    public partial class Items_Report : Form
    {
        public Items_Report()
        {
            InitializeComponent();
        }

        private void btn_viewreport_Click(object sender, EventArgs e)
        {

            FrmItemsReport ot = new FrmItemsReport();
            ot.ShowDialog();
            
            
          
        }
    }
}
