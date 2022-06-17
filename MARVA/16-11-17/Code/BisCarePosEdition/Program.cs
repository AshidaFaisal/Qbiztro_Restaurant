using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BisCarePosEdition
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      // Application.Run(new DeletePasswordChange());
       Splash ObjSplash = new Splash();
       ObjSplash.ShowDialog();
       if (ObjSplash.dlgrslt == DialogResult.OK)
       {
           Theme ObjTheme = new Theme();
           ObjTheme.setTheme();
       p1: Login ObjLogin = new Login();
           Codebehind obj = new Codebehind();
           DialogResult r = ObjLogin.ShowDialog();
           if (r == DialogResult.OK)
           {
               Codebehind ObjCode = new Codebehind();
               SqlDataReader dr1 = ObjCode.GetRestuarant();
               if (!dr1.Read())
               {
                   Restuarant ObRest = new Restuarant();
                   ObRest.ShowDialog();
                   if (ObRest.DialogResult == DialogResult.OK)
                   {

                       //Home1 ObjHome = new Home1();
                       Home_page hp = new Home_page();
                       hp.ShowDialog();
                   }

               }
               else
               
               {
                   if (globalvariable.designation.ToUpper().ToString() == "CASHIER")
                   {
                       //if (globalvariable.StoreStatus.ToString() == "Open")
                       //{
                           while (Application.OpenForms.Count > 1)
                           {
                               Application.OpenForms[Application.OpenForms.Count - 1].Close();
                           }
                           int CounterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
                           //DataTable dt1 = new DataTable();
                           //dt1 = ObjCode.updatelogin(globalvariable.userid, DateTime.Now, Convert.ToDateTime(globalvariable.StoreDate), CounterId, "changecounter");
                           //if (dt1.Rows.Count > 0) 
                           ////{
                           //    if (dt1.Rows[0]["msg"].ToString() == "allow")
                           //    {
                                   DataTable dt = new DataTable();
                                   dt = ObjCode.GetFormUserRights(File.ReadAllText("user.txt"), "TouchBilling");
                                   //if (dt.Rows.Count > 0)
                                   //{
                                   //    if (dt.Rows[0]["ViewStatus"].ToString() == "1")
                                   //    {
                                            Home_page hp = new Home_page();
                                            hp.ShowDialog();
                                           //TouchBilling ob = new TouchBilling();
                                           //ob.ShowDialog();
                                       //}
                                       //else
                                       //{
                                       //    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                       //}
                                   //}
                                   //else
                                   //{
                                   //    MessageBox.Show("You Have No Permission To View This Window. Please Contact Administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   //}
                               //}
                               //else
                               //{
                               //    //SqlCommand com = new SqlCommand(new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString).ToString());
                               //    //com.CommandText = "delete from tbl_Login where Id in(select top 1 id from tbl_Login order by id desc)";
                               //    string m = dt1.Rows[0]["msg"].ToString();
                               //    if (m.Contains(","))
                               //        m = m.Replace(",", "\n\n    ");
                               //    MessageBox.Show(m, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               //}
                           //}
                           //CashierCounter cs = new CashierCounter();
                           //cs.ShowDialog();
                       //}
                       //else
                       //    MessageBox.Show("Sorry......Store Not Opened", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }

                   else
                   {
                       dr1.Close();
                       //// Home1 ObjHome = new Home1();
                       Home_page hp = new Home_page();
                       hp.ShowDialog();
                   }
               }
           }

           else if (r == DialogResult.No)
           {
               MessageBox.Show("Incorrect Username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //ObjLogin.ShowDialog();
               goto p1;
           }
       }
       else
       {
           MessageBox.Show("Liscense Key Not Found. Please Contact Loyal IT Solutions For Activation.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
       }
    }
}
