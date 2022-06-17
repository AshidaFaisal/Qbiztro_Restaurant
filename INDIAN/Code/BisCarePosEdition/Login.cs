using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Net;


namespace BisCarePosEdition
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Codebehind obj = new Codebehind();

        private void Login_Load(object sender, EventArgs e)
        
        
        
        {
            txt_username.Focus();
            checremember.Checked = false;
            DataTable dt1 = new DataTable();
                dt1=obj.getid();  
            txt_username.Text= File.ReadAllText("lastlogin.txt");
            txt_password.Text = obj.Decrypt(File.ReadAllText("password.txt"), "Loyal");
            if (txt_password.Text != "")
            {
                checremember.Checked = true;
            }
               
        }
        internal static string username, Password;
        public string pass;
        public int  chksataus=0 ;
        static internal string loginuser;
        static internal string loginuserid;
        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {

                Login55();
               
               
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void Login55()
        {
            try
            {

                //DateTime DateTimeLimit = DateTime.Parse("20/Dec/2020");

                //if (DateTimeLimit > DateTime.Now)
                //{
                    if (checremember.Checked == true)
                    {
                        pass = obj.EncodePassword(txt_password.Text, "Loyal");
                        File.WriteAllText("lastlogin.txt", txt_username.Text);
                        File.WriteAllText("password.txt", pass);
                        chksataus = 1;
                    }
                    else
                    {
                        File.WriteAllText("lastlogin.txt", txt_username.Text);
                        File.WriteAllText("password.txt", "");
                    }
                    int CounterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
                    pass = obj.EncodePassword(txt_password.Text, "Loyal");


                    LoginCheck();
                //}
                //else
                //{
                //    MessageBox.Show("Config file missing. Please contact administrator", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    // MessageBox.Show("License Expired. Please contact Loyal IT Solutions.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}


               // CheckLicence();



            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private void CheckLicence()
        {
            try
            {
                DataTable DtProdOnline = new DataTable();
                decimal ExPiryStOffline = 1; string ClientCode = "";

                DataTable DtProdOffline = obj.CompanyIsActiveView();

                if (DtProdOffline.Rows.Count > 0)
                {

                    ExPiryStOffline = decimal.Parse(DtProdOffline.Rows[0]["ISActive"].ToString());
                    ClientCode = DtProdOffline.Rows[0]["ClientCode"].ToString();
                }

                bool chackInterNetStatus = CheckForInternetConnection();
                if (chackInterNetStatus == true)
                {
                    DtProdOnline = obj.ProductActivationViewAll(ClientCode);


                    if (DtProdOnline.Rows.Count > 0)
                    {
                        int IsActive = int.Parse(DtProdOnline.Rows[0]["IsActive"].ToString());
                        obj.UpdateClientActiveStatus(IsActive);
                    }
                }

                DtProdOffline = obj.CompanyIsActiveView();

                if (DtProdOffline.Rows.Count > 0)
                {

                    ExPiryStOffline = decimal.Parse(DtProdOffline.Rows[0]["ISActive"].ToString());
                    ClientCode = DtProdOffline.Rows[0]["ClientCode"].ToString();
                }

                if (ExPiryStOffline == 1)
                {
                    if (checremember.Checked == true)
                    {
                        pass = obj.EncodePassword(txt_password.Text, "Loyal");
                        File.WriteAllText("lastlogin.txt", txt_username.Text);
                        File.WriteAllText("password.txt", pass);
                        chksataus = 1;
                    }
                    else
                    {
                        File.WriteAllText("lastlogin.txt", txt_username.Text);
                        File.WriteAllText("password.txt", "");
                    }
                    int CounterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
                    pass = obj.EncodePassword(txt_password.Text, "Loyal");


                    LoginCheck();
                }
                else
                {
                    MessageBox.Show("License Expired. Please contact Loyal IT Solutions.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - " + this.Name + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }

        private void LoginCheck()
        {
            //loginuser = txt_username.Text;
            int CounterId = Convert.ToInt32(File.ReadAllText("counter.txt"));
            DataTable dt = obj.login(txt_username.Text, pass, DateTime.Now, 0, CounterId, Convert.ToInt32(File.ReadAllText("user.txt")), chksataus);
            if (dt.Rows.Count > 0)
            {
                if (dt.Columns.Count == 1)
                {
                    MessageBox.Show("Mismatch In Passwords.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    loginuserid = dt.Rows[0]["user_id"].ToString();
                    File.WriteAllText("user.txt", dt.Rows[0]["user_id"].ToString());
                    loginuser = txt_username.Text;
                    globalvariable.setuserid = dt.Rows[0]["user_id"].ToString();
                    globalvariable.setusername = dt.Rows[0]["username"].ToString();
                    globalvariable.setdesignation = dt.Rows[0]["designation_name"].ToString();
                    globalvariable.StoreDate = dt.Rows[0]["StoreDate"].ToString();
                    globalvariable.StoreStatus = dt.Rows[0]["StoreStatus"].ToString();
                    // globalvariable.Dummy = dt.Rows[0]["Dummy"].ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.No;
                // MessageBox.Show("User Name or Password Incorrect");
                this.Close();
            }
        }
       
 
        internal static string usreid;
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                txt_password.Focus();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyData == Keys.Enter)
                btn_Login.Focus();
        }

        private void checremember_CheckedChanged(object sender, EventArgs e)
        {
            //if (checremember.Checked == true)
            //{
            //    string pass = obj.EncodePassword(txt_password.Text, "Loyal");
            //   // File.WriteAllText("password.txt", pass);
            //}
            //else
            //{
            //    checremember.Checked = false;
            //}
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            txt_password.Text = "";
        }
    }
}
