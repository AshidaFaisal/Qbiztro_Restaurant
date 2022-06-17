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
    public partial class waiters_list : Form
    {

        Codebehind obj = new Codebehind();
        public string waiter_name, wId;
       
        public waiters_list(string names)
        {
            names=wId;
            InitializeComponent();  
        }
        private void waiters_list_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = obj.GetWaiter();
            listBox_waiter.DataSource = ds.Tables[0];

            listBox_waiter.DisplayMember = "Name";
            listBox_waiter.ValueMember = "Id";
        }     
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox_waiter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }  
        private void listBox_waiter_DoubleClick(object sender, EventArgs e)
        {
             wId = listBox_waiter.SelectedValue.ToString() ;
           
            DataTable dt = new DataTable();
            dt = obj.getnames(wId);
            this.Close();       
        }      
        private void listBox_waiter_Enter(object sender, EventArgs e)
        {
            wId = listBox_waiter.SelectedValue.ToString();
          
                  
        }
        private void listBox_waiter_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {

                wId = listBox_waiter.SelectedValue.ToString();
                this.Close(); 
            }
            if (e.KeyData == Keys.Down)
            {
                listBox_waiter.Focus();
            }
            //wId = listBox_waiter.SelectedValue.ToString();

            //DataTable dt = new DataTable();
            //dt = obj.getnames(wId);
           
            //this.Close();
        }

        private void listBox_waiter_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
