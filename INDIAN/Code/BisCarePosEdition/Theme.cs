using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace BisCarePosEdition
{
    class Theme
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        SqlCommand cmd;
        public void Opencon()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
            }
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", DateTime.Now.ToString() + " - Connection in Version Updation" + Environment.NewLine + ex.ToString() + Environment.NewLine);
            }
        }
        public static string ThemeId;
        public static string FormColor;
        public static string BtnBackColor;
        public static string BtnForeColor;
        public static string BtnMouseOver;
        public static string LblForeColor;
        public static string DgvBackColor;
        public static string FlatStyle;
        public static string MBBackColor;
        public static string MBForeColor;       
        public static string MBMouseOvr;
        public static string MBFlatStyle;
        public void setTheme()
        {
            Opencon();
            cmd = new SqlCommand("spSelectTheme", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ThemeId = dt.Rows[0]["Id"].ToString();
                FormColor = dt.Rows[0]["FormColor"].ToString();
                BtnBackColor = dt.Rows[0]["BtnBackColor"].ToString();
                BtnForeColor = dt.Rows[0]["BtnForeColor"].ToString();
                BtnMouseOver = dt.Rows[0]["BtnMouseOver"].ToString();
                LblForeColor = dt.Rows[0]["LblForeColor"].ToString();
                DgvBackColor = dt.Rows[0]["DgvBackColor"].ToString();
                FlatStyle = dt.Rows[0]["FlatStyle"].ToString();
                MBBackColor = dt.Rows[0]["MBBackColor"].ToString();
                MBForeColor = dt.Rows[0]["MBForeColor"].ToString();
                MBMouseOvr = dt.Rows[0]["MBMouseOvr"].ToString();
                MBFlatStyle = dt.Rows[0]["MBFlatStyle"].ToString();
            }         
        }
        public string NewTheme(string ThemeName1, string FormColor1, string BtnBackColor1, string BtnForeColor1, string BtnMouseOver1, string LblForeColor1, string DgvBackColor1, string FlatStyle1, string MBBackColor1, string MBForeColor1, string MBMouseOvr1, string MBFlatStyle1)
        {
            Opencon();
            cmd = new SqlCommand("spNewTheme", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ThemeName", ThemeName1);
            cmd.Parameters.AddWithValue("@FormColor", FormColor1);
            cmd.Parameters.AddWithValue("@BtnBackColor", BtnBackColor1);
            cmd.Parameters.AddWithValue("@BtnForeColor", BtnForeColor1);
            cmd.Parameters.AddWithValue("@BtnMouseOver", BtnMouseOver1);
            cmd.Parameters.AddWithValue("@LblForeColor", LblForeColor1);
            cmd.Parameters.AddWithValue("@DgvBackColor", DgvBackColor1);
            cmd.Parameters.AddWithValue("@FlatStyle", FlatStyle1);
            cmd.Parameters.AddWithValue("@MBBackColor", MBBackColor1);
            cmd.Parameters.AddWithValue("@MBForeColor", MBForeColor1);
            cmd.Parameters.AddWithValue("@MBMouseOvr", MBMouseOvr1);
            cmd.Parameters.AddWithValue("@MBFlatStyle", MBFlatStyle1);
            return cmd.ExecuteScalar().ToString();
        }
        public string UpdateTheme(string Id,string ThemeName1, string FormColor1, string BtnBackColor1, string BtnForeColor1, string BtnMouseOver1, string LblForeColor1, string DgvBackColor1, string FlatStyle1, string MBBackColor1, string MBForeColor1, string MBMouseOvr1, string MBFlatStyle1)
        {
            Opencon();
            cmd = new SqlCommand("spUpdateTheme", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@ThemeName", ThemeName1);
            cmd.Parameters.AddWithValue("@FormColor", FormColor1);
            cmd.Parameters.AddWithValue("@BtnBackColor", BtnBackColor1);
            cmd.Parameters.AddWithValue("@BtnForeColor", BtnForeColor1);
            cmd.Parameters.AddWithValue("@BtnMouseOver", BtnMouseOver1);
            cmd.Parameters.AddWithValue("@LblForeColor", LblForeColor1);
            cmd.Parameters.AddWithValue("@DgvBackColor", DgvBackColor1);
            cmd.Parameters.AddWithValue("@FlatStyle", FlatStyle1);
            cmd.Parameters.AddWithValue("@MBBackColor", MBBackColor1);
            cmd.Parameters.AddWithValue("@MBForeColor", MBForeColor1);
            cmd.Parameters.AddWithValue("@MBMouseOvr", MBMouseOvr1);
            cmd.Parameters.AddWithValue("@MBFlatStyle", MBFlatStyle1);
            return cmd.ExecuteScalar().ToString();
        }
        public DataTable GetThemeDetails(string Id)
        {
            Opencon();
            cmd = new SqlCommand("spGetThemeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetThemeNames()
        {
            Opencon();
            cmd = new SqlCommand("spSelectAllThemes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void setSavedTheme(string Id)
        {
            Opencon();
            cmd = new SqlCommand("spSetSavedTheme", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
        }
    }
}
