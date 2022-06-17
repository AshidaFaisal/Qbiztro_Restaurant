using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Windows.Forms;

namespace BisCarePosEdition
{
    class MyClass
    {
        SqlConnection con;

        public void Opencon()
        {
            try
            {
                con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection2"].ConnectionString);
                if (con.State == ConnectionState.Open)
                //if (con.State == ConnectionState.Closed)
                {
                    con.Close();
                    //con.Open();
                }
                con.Open();
            }
            catch
            {
                con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
                if (con.State == ConnectionState.Open)
                //if (con.State == ConnectionState.Closed)              
                {
                    con.Close();
                    //con.Open();
                }
                con.Open();
            }
            //finally
            //{
            //    con.Close();
            //}
        }


        TextBox tb = new TextBox();
        TextBox txt = new TextBox();
        Label txtname1 = new Label();
        Button btn = new Button();
        ComboBox cb = new ComboBox();
        Label lb = new Label();



        // Numeric TextBox
        public void Numerictxt(Control c)
        {
            tb = ((TextBox)c);
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);

        }

        void tb_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        //Numeric TextBox with Decimals
        public void Decimaltxt(Control c)
        {
            txt = ((TextBox)c);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);

        }

        void txt_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }











        //fill ds
        public DataSet myDataSet(string myQuery)
        {
            Opencon();
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlDataAdapter add = new SqlDataAdapter(myQuery, con);
            DataSet dss = new DataSet();
            add.Fill(dss);
            return dss;
        }

        // FillCombobox
        public void FillCombobox(ComboBox com1, string tname, string fname)
        {
            MyClass cls = new MyClass();

            DataSet ds = cls.myDataSet("select " + "[" + fname + "]" + " from " + tname + "");
            com1.DisplayMember = "" + fname + "";
            com1.ValueMember = "" + fname + "";

            if (ds.Tables[0].Rows.Count > 0)
            {
                com1.DataSource = ds.Tables[0].DefaultView;
                com1.SelectedIndex = -1;
            }

        }


        //maxno
        public int getMax(string tblname, string fieldname)
        {
            Opencon();
            int max;
            SqlCommand cmd = new SqlCommand("select max(" + fieldname + "+1) from " + tblname + "", con);
            object objmax = cmd.ExecuteScalar();
            if (objmax == DBNull.Value)
            {
                max = 1;
            }
            else
            {
                max = Convert.ToInt32(objmax);
            }
            return max;
        }

        public void ClearControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    ClearControls(c);
                }
                else
                {
                    switch (c.GetType().ToString())
                    {

                        case "System.Windows.Forms.RichTextBox":
                            ((RichTextBox)c).Text = "";
                            break;
                        case "System.Windows.Forms.TextBox":
                            ((TextBox)c).Text = "";
                            break;
                        case "System.Windows.Forms.CheckBox":
                            ((CheckBox)c).Checked = false;
                            break;
                        case "System.Windows.Forms.RadioButton":
                            ((RadioButton)c).Checked = false;
                            break;
                        case "System.Windows.Forms.DateTimePicker":
                            ((DateTimePicker)c).Text = System.DateTime.Today.ToShortDateString();
                            break;
                        case "System.Windows.Forms.ComboBox":
                            ((ComboBox)c).Text = "";
                            ((ComboBox)c).SelectedIndex = -1;
                            break;
                        case "System.Windows.Forms.MaskedTextBox":
                            ((MaskedTextBox)c).Text = "  /  / ";
                            break;
                    }
                }
            }
        }

        public void ClearDoubleNumericTexBox(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    ClearDoubleNumericTexBox(c);
                }
                else
                {
                    switch (c.GetType().ToString())
                    {
                        case "System.Windows.Forms.TextBox":
                            ((TextBox)c).Text = "0.00";
                            break;
                    }
                }
            }
        }

        public void ClearLongNumericTexBox(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    ClearLongNumericTexBox(c);
                }
                else
                {
                    switch (c.GetType().ToString())
                    {
                        case "System.Windows.Forms.TextBox":
                            ((TextBox)c).Text = "0";
                            break;
                    }
                }
            }
        }

        public void DisableFormControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    DisableFormControls(c);
                }
                else
                {
                    switch (c.GetType().ToString())
                    {
                        case "System.Windows.Forms.TextBox":
                            ((TextBox)c).Enabled = false;
                            break;

                        case "System.Windows.Forms.DateTimePicker":
                            ((DateTimePicker)c).Enabled = false;
                            break;
                        case "System.Windows.Forms.GroupBox":
                            ((GroupBox)c).Enabled = false;
                            break;
                        case "System.Windows.Forms.ComboBox":
                            ((ComboBox)c).Enabled = false;
                            break;
                    }
                }
            }
        }




        public void EnableFormControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    EnableFormControls(c);
                }
                else
                {
                    switch (c.GetType().ToString())
                    {
                        case "System.Windows.Forms.TextBox":
                            ((TextBox)c).Enabled = true;
                            break;

                        case "System.Windows.Forms.DateTimePicker":
                            ((DateTimePicker)c).Enabled = true;
                            break;
                        case "System.Windows.Forms.GroupBox":
                            ((GroupBox)c).Enabled = true;
                            break;
                        case "System.Windows.Forms.ComboBox":
                            ((ComboBox)c).Enabled = true;
                            break;

                    }
                }
            }
        }




        public int CheckNull(Control parent, string text, KeyEventArgs e)
        {
            int i = 0;
            if (e.KeyCode == Keys.Enter)
            {
                switch (parent.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        if (((TextBox)parent).Text == "")
                        {
                            MessageBox.Show("Please enter " + text, "SAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ((TextBox)parent).Focus();
                            i = 1;
                        }
                        break;
                    case "System.Windows.Forms.ComboBox":
                        if (((ComboBox)parent).Text == "")
                        {
                            MessageBox.Show("Please select " + text, "SAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ((ComboBox)parent).Focus();
                            i = 1;
                        }
                        break;
                }

            }
            return i;
        }

        public void MessageBoxFunction(string msg, string type)
        {
            switch (type)
            {
                case "Ok":
                    MessageBox.Show(msg, "SAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "YesNo":
                    MessageBox.Show(msg, "SAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                case "OkError":
                    MessageBox.Show(msg, "SAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


        public void CheckDigit(Control parent)
        {
            string s = parent.Text;
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    if ((c == '.') || (c == ','))
                    {
                        // do nothing
                    }
                    else
                    {
                        MessageBox.Show("Please enter numbers only", "SAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        parent.Text = "";
                        parent.Focus();
                    }
                }
            }
        }

        public int CheckBeforeSaving(Control parent, string text)
        {
            int i = 0;
            switch (parent.GetType().ToString())
            {
                case "System.Windows.Forms.TextBox":
                    if (((TextBox)parent).Text == "")
                    {
                        MessageBox.Show("Please enter " + text, "SAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)parent).Focus();
                        i = 1;
                    }
                    break;
                case "System.Windows.Forms.ComboBox":
                    if (((ComboBox)parent).Text == "")
                    {
                        MessageBox.Show("Please select " + text, "SAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((ComboBox)parent).Focus();
                        i = 1;
                    }
                    break;
            }
            return i;
        }

        public void MoveToNextControl(Control parent, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = parent.GetType().ToString();
                switch (name)
                {
                    case "System.Windows.Forms.TextBox":
                        ((TextBox)parent).Focus();
                        break;
                    case "System.Windows.Forms.DateTimePicker":
                        ((DateTimePicker)parent).Focus();
                        break;
                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)parent).Focus();
                        break;
                    case "System.Windows.Forms.RadioButton":
                        ((RadioButton)parent).Focus();
                        break;
                    case "System.Windows.Forms.CheckBox":
                        ((CheckBox)parent).Focus();
                        break;
                    case "System.Windows.Forms.Button":
                        ((Button)parent).Focus();
                        break;
                }

            }
        }


        internal static void mygrid(Control ctrl)
        {
            if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
            {
                ((DataGridView)ctrl).EnableHeadersVisualStyles = false;
                ((DataGridView)ctrl).BackgroundColor = Color.White;
                ((DataGridView)ctrl).GridColor = Color.Gray;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.ForeColor = Color.SaddleBrown;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.SelectionForeColor = Color.Blue;
                ((DataGridView)ctrl).RowHeadersVisible = true;
                ((DataGridView)ctrl).RowHeadersWidth = 43;
                ((DataGridView)ctrl).RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                ((DataGridView)ctrl).RowsDefaultCellStyle.ForeColor = Color.Black;
                ((DataGridView)ctrl).ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                ((DataGridView)ctrl).RowsDefaultCellStyle.SelectionBackColor = Color.LightCyan;
                ((DataGridView)ctrl).RowsDefaultCellStyle.SelectionForeColor = Color.Blue;
                ((DataGridView)ctrl).RowTemplate.Height = 21;
                //dgv_Nomination.RowsDefaultCellStyle.BackColor = Color.White;
                //((DataGridView)ctrl).AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }
        internal static void DatagridDesign1(Control ctrl)
        {
            if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
            {
                ((DataGridView)ctrl).EnableHeadersVisualStyles = false;
                ((DataGridView)ctrl).BackgroundColor = Color.White;
                ((DataGridView)ctrl).GridColor = Color.Gray;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.ForeColor = Color.SaddleBrown;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.SelectionBackColor = Color.SkyBlue;

                ((DataGridView)ctrl).RowHeadersVisible = false;
                ((DataGridView)ctrl).RowHeadersWidth = 43;
                ((DataGridView)ctrl).RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                ((DataGridView)ctrl).RowsDefaultCellStyle.ForeColor = Color.Black;
                ((DataGridView)ctrl).ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                ((DataGridView)ctrl).RowsDefaultCellStyle.SelectionBackColor = Color.LightCyan;
                ((DataGridView)ctrl).RowsDefaultCellStyle.SelectionForeColor = Color.Blue;
                ((DataGridView)ctrl).RowTemplate.Height = 21;
                //dgv_Nomination.RowsDefaultCellStyle.BackColor = Color.White;
                //((DataGridView)ctrl).AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }

        //datagrid desighn for sales forms

        internal static void DatagridDesignSales(Control ctrl)
        {
            if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
            {
                ((DataGridView)ctrl).EnableHeadersVisualStyles = false;
                ((DataGridView)ctrl).BackgroundColor = Color.White;
                ((DataGridView)ctrl).GridColor = Color.Gray;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.ForeColor = Color.SaddleBrown;
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.SelectionForeColor = Color.Blue;
                ((DataGridView)ctrl).RowHeadersVisible = true;
                ((DataGridView)ctrl).RowHeadersWidth = 43;
                ((DataGridView)ctrl).RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                ((DataGridView)ctrl).RowsDefaultCellStyle.ForeColor = Color.Black;
                ((DataGridView)ctrl).ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                ((DataGridView)ctrl).RowsDefaultCellStyle.SelectionBackColor = Color.LightCyan;
                ((DataGridView)ctrl).RowsDefaultCellStyle.SelectionForeColor = Color.Blue;
                ((DataGridView)ctrl).RowTemplate.Height = 21;
                //dgv_Nomination.RowsDefaultCellStyle.BackColor = Color.White;
                //((DataGridView)ctrl).AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }
        internal static void DatagridDesignSales1(Control ctrl)
        {
            if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
            {
                ((DataGridView)ctrl).EnableHeadersVisualStyles = false;
                ((DataGridView)ctrl).BackgroundColor = Color.White;
                ((DataGridView)ctrl).GridColor = Color.Gray;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.ForeColor = Color.SaddleBrown;
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.SelectionBackColor = Color.CadetBlue;
                ((DataGridView)ctrl).RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                ((DataGridView)ctrl).RowsDefaultCellStyle.ForeColor = Color.Black;
                ((DataGridView)ctrl).ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                ((DataGridView)ctrl).RowsDefaultCellStyle.SelectionBackColor = Color.LightCyan;
                ((DataGridView)ctrl).RowsDefaultCellStyle.SelectionForeColor = Color.Blue;
                ((DataGridView)ctrl).RowTemplate.Height = 18;
            }
        }
        internal static void Gridstyle(Control ctrl)
        {
            if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
            {

                ((DataGridView)ctrl).EnableHeadersVisualStyles = false;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
                ((DataGridView)ctrl).ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
                ((DataGridView)ctrl).RowHeadersDefaultCellStyle.BackColor = Color.White;
                ((DataGridView)ctrl).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ((DataGridView)ctrl).RowHeadersVisible = false;
                ((DataGridView)ctrl).DefaultCellStyle.SelectionBackColor = Color.White;
                ////((DataGridView)ctrl).DefaultCellStyle.BackColor = Color.Transparent;
                ((DataGridView)ctrl).DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
                //((DataGridView)ctrl).AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ScrollBar;
                ((DataGridView)ctrl).DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
                ((DataGridView)ctrl).RowTemplate.Height = 30;
                //foreach (DataGridViewColumn col in ((DataGridView)ctrl).Columns)
                //{
                //    col.DefaultCellStyle.BackColor = Color.Transparent;
                //    col.DefaultCellStyle.SelectionBackColor = Color.Transparent;

                //}
            }
        }


        //check fill RichTextBox
        public static bool ChkrhEmpty(params System.Windows.Forms.RichTextBox[] rb)
        {
            int i;
            for (i = 0; i < rb.Length; i++)
            {
                if (rb[i].Text.Trim() == "")
                {
                    MessageBox.Show("Don't keep Field empty");
                    rb[i].Focus();
                    return false;
                }
            }
            return true;
        }
        //check fill textbox
        public static bool ChktxtEmpty(params System.Windows.Forms.TextBox[] tb)
        {
            int i;
            for (i = 0; i < tb.Length; i++)
            {
                if (tb[i].Text.Trim() == "")
                {
                    MessageBox.Show("Don't keep Field empty");
                    tb[i].Focus();
                    return false;
                }
            }
            return true;
        }

        //check fill combobox
        public static bool ChkcmbEmpty(params System.Windows.Forms.ComboBox[] cmb)
        {
            int i;
            for (i = 0; i < cmb.Length; i++)
            {
                if (cmb[i].Text.Trim() == "")
                {
                    MessageBox.Show("Don't keep field empty");
                    cmb[i].Focus();
                    return false;
                }
            }
            return true;
        }

        //

    }
}
