using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
namespace BisCarePosEdition
{
    class Codebehind
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        SqlCommand cmd;
        DataSet ds = new DataSet();
        public void Opencon()
        {
            if (con.State == ConnectionState.Open)
                
                con.Close();
            con.Open();
        }
        public string GetACoountType(string useid)
        {
            Opencon();
            cmd = new SqlCommand("spGetAccountTypeByUid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid",useid);
          return  cmd.ExecuteScalar().ToString();
        }
        public DataTable ReportofStock()
        {
            Opencon();
            cmd = new SqlCommand("spGetStock", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private const int keysize = 256;
        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");

        public  string EncodePassword(string plainText, string passPhrase)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
            {
                byte[] keyBytes = password.GetBytes(keysize / 8);
                using (RijndaelManaged symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.Mode = CipherMode.CBC;
                    using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                byte[] cipherTextBytes = memoryStream.ToArray();
                               // int i = BitConverter.ToInt32(cipherTextBytes, 0);
                                //return i ;
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public string Decrypt(string cipherText, string passPhrase)
        {
            if (cipherText != "")
            {
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
                {
                    byte[] keyBytes = password.GetBytes(keysize / 8);
                    using (RijndaelManaged symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.Mode = CipherMode.CBC;
                        using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes))
                        {
                            using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                                {
                                    byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                                    int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                    return  Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                                }
                            }
                        }
                    }
                }
            }
            return "";
        }

        public string EncodePassword1(string password, string salt)
        {
            Opencon();
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] src = Encoding.Unicode.GetBytes(salt);
            byte[] dst = new byte[src.Length + bytes.Length];
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public DataTable ReportSalesByDate(int mode, int status, DateTime st, DateTime en, int saletype)
        {
            Opencon();
            cmd = new SqlCommand("spGetDailySaleReportByDate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sttus", status);
            cmd.Parameters.AddWithValue("@end", en);
            cmd.Parameters.AddWithValue("@start", st);
            cmd.Parameters.AddWithValue("@mode", mode);
            //cmd.Parameters.AddWithValue("@item", item);
            //cmd.Parameters.AddWithValue("@waiter", waite);
            cmd.Parameters.AddWithValue("@saletype", saletype);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public DataTable ReportSalesByDateComplimentary(int mode, int status, DateTime st, DateTime en,int saletype)
        {
            Opencon();
            cmd = new SqlCommand("spGetDailySaleReportByDateCompliment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sttus", status);
            cmd.Parameters.AddWithValue("@end", en);
            cmd.Parameters.AddWithValue("@start", st);
            cmd.Parameters.AddWithValue("@mode", mode);
            cmd.Parameters.AddWithValue("@saletype", saletype);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ReportofsalesDaily(int mode, int status)
        {
                 Opencon();
                 cmd = new SqlCommand("spGetDailySaleReport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sttus", status);
           // cmd.Parameters.AddWithValue("@enddate", end);
           // cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@mode", mode);
            //cmd.Parameters.AddWithValue("@item", item);
            //cmd.Parameters.AddWithValue("@waiter", waite);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ReportofDeletedInvoice(DateTime start , DateTime end)
        {
            Opencon();
            cmd = new SqlCommand("spReportDeletedInvoice", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", start);
            // cmd.Parameters.AddWithValue("@enddate", end);
            // cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@enddte", end);
            //cmd.Parameters.AddWithValue("@item", item);
            //cmd.Parameters.AddWithValue("@waiter", waite);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ReportofDeletedInvoiceComplimentary(DateTime start, DateTime end)
        {
            Opencon();
            cmd = new SqlCommand("spReportDeletedInvoiceCompliment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", start);
            // cmd.Parameters.AddWithValue("@enddate", end);
            // cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@enddte", end);
            //cmd.Parameters.AddWithValue("@item", item);
            //cmd.Parameters.AddWithValue("@waiter", waite);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public DataTable ReportofSales(DateTime start, DateTime end, int cat, int mode, int item, int waite, int saletype,int user)
        {
            Opencon();
            cmd = new SqlCommand("spSalesReport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", start);
            cmd.Parameters.AddWithValue("@enddte", end);
            cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@mode", mode);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@waiter", waite);
            cmd.Parameters.AddWithValue("@saletype", saletype);
            cmd.Parameters.AddWithValue("@Userid", user);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ReportofSalesComplimentary(DateTime start, DateTime end, int cat, int mode, int item, int waite, int saletype, int user)
        {
            Opencon();
            cmd = new SqlCommand("spSalesReportCompliment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", start);
            cmd.Parameters.AddWithValue("@enddte", end);
            cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@mode", mode);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@waiter", waite);
            cmd.Parameters.AddWithValue("@saletype", saletype);
            cmd.Parameters.AddWithValue("@Userid", user);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ReportOtherIncome(DateTime start, DateTime end, string type, int mode)
        {
            Opencon();
            cmd = new SqlCommand("spReportOtherIncome", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", start);
            cmd.Parameters.AddWithValue("@enddate", end);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@mode", mode);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable  ReportOtherExpense(DateTime start, DateTime end,string type,int mode)
        {
            Opencon();
            cmd = new SqlCommand("spReportOtherExpence", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", start);
            cmd.Parameters.AddWithValue("@enddate", end);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@mode", mode);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TOUCHGETDETAILS(string invoice, int mode)
        {
            Opencon();
            cmd = new SqlCommand("TOUCHGETDETAILS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@invno", invoice);
            cmd.Parameters.AddWithValue("@mode", mode);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable UPDATETOUCHPAYMENTS(string invoice, double cash,double card)
        {
            Opencon();
            cmd = new SqlCommand("UPDATETOUCHPAYMENTS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@invno", invoice);
            cmd.Parameters.AddWithValue("@CashAmt", cash);
            cmd.Parameters.AddWithValue("@CardAmt", card);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable ReportDeletedkot(DateTime start, DateTime end)
        {
            Opencon();
            cmd = new SqlCommand("spReportDeletedKotDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate",start);
            cmd.Parameters.AddWithValue("@enddte", end);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getprinterfeatures()
        {
            Opencon();
            cmd = new SqlCommand("spgetprinterfeatures", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetStoreStatus()
        {
            Opencon();
            cmd = new SqlCommand("SP_GetStoreStatus", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string InsertorUpdateUnit(string unit,string mode,string id)
        {
            Opencon();
            cmd = new SqlCommand("spInsertUnit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@mode", mode);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteScalar().ToString();
        }
        public string insertorupdatebilling(string billno,string waiter,string table,string billname,string count,
        string counter,string ad1,string ad2,string ad3,string ad4,string ad5,string g1,string g2,string sno,string iname,
        string qty,string pr,string amnt,string icode,string adfont,string gfont,string datest,string cashier,string logo,string currency)
        {
            Opencon();
            cmd = new SqlCommand("spinsertupdateprintingfts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("", id);
            cmd.Parameters.AddWithValue("@BillNo", billno);
            cmd.Parameters.AddWithValue("@waiter", waiter);
            cmd.Parameters.AddWithValue("@table", table);
            cmd.Parameters.AddWithValue("@billname", billname);
            cmd.Parameters.AddWithValue("@pcount", count);
            cmd.Parameters.AddWithValue("@counter", counter);
            cmd.Parameters.AddWithValue("@address1", ad1);
            cmd.Parameters.AddWithValue("@address2", ad2);
            cmd.Parameters.AddWithValue("@address3", ad3);
            cmd.Parameters.AddWithValue("@address4", ad4);
            cmd.Parameters.AddWithValue("@addres5", ad5);
            cmd.Parameters.AddWithValue("@greeting1", g1);
            cmd.Parameters.AddWithValue("@greeting2", g2);
            cmd.Parameters.AddWithValue("@Slno", sno);
            cmd.Parameters.AddWithValue("@Itemname", iname);
            cmd.Parameters.AddWithValue("@Quantity", qty);
            cmd.Parameters.AddWithValue("@Price", pr);
            cmd.Parameters.AddWithValue("@Amount", amnt);
            cmd.Parameters.AddWithValue("@Itemcode", icode);
            cmd.Parameters.AddWithValue("@AddressFont", adfont);
            cmd.Parameters.AddWithValue("@GreetingFont", gfont);
            cmd.Parameters.AddWithValue("@datest", datest);
            cmd.Parameters.AddWithValue("@cashier", cashier);
            cmd.Parameters.AddWithValue("@logo", logo);
            cmd.Parameters.AddWithValue("@currency", currency);
            return cmd.ExecuteScalar().ToString();

        }
        public string updatebillingfeatures(string billno, string waiter, string table, string billname, string count,
      string counter, string ad1, string ad2, string ad3, string ad4, string ad5, string g1, string g2, string sno, string iname,
      string qty, string pr, string amnt, string icode, string adfont, string gfont, string datest, string cashier,string logo,string currency)
        {
            Opencon();
            cmd = new SqlCommand("spupdateprinterfeatures", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("", id);
            cmd.Parameters.AddWithValue("@BillNo", billno);
            cmd.Parameters.AddWithValue("@waiter", waiter);
            cmd.Parameters.AddWithValue("@table", table);
            cmd.Parameters.AddWithValue("@billname", billname);
            cmd.Parameters.AddWithValue("@pcount", count);
            cmd.Parameters.AddWithValue("@counter", counter);
            cmd.Parameters.AddWithValue("@address1", ad1);
            cmd.Parameters.AddWithValue("@address2", ad2); 
            cmd.Parameters.AddWithValue("@address3", ad3);
            cmd.Parameters.AddWithValue("@address4", ad4);
            cmd.Parameters.AddWithValue("@addres5", ad5);
            cmd.Parameters.AddWithValue("@greeting1", g1);
            cmd.Parameters.AddWithValue("@greeting2", g2);
            cmd.Parameters.AddWithValue("@Slno", sno);
            cmd.Parameters.AddWithValue("@Itemname", iname);
            cmd.Parameters.AddWithValue("@Quantity", qty);
            cmd.Parameters.AddWithValue("@Price", pr);
            cmd.Parameters.AddWithValue("@Amount", amnt);
            cmd.Parameters.AddWithValue("@Itemcode", icode);
            cmd.Parameters.AddWithValue("@AddressFont", adfont);
            cmd.Parameters.AddWithValue("@GreetingFont", gfont);
            cmd.Parameters.AddWithValue("@datest", datest);
            cmd.Parameters.AddWithValue("@cashier", cashier);
            cmd.Parameters.AddWithValue("@logo", logo);
            cmd.Parameters.AddWithValue("@currency", currency);
            return cmd.ExecuteScalar().ToString();

        }
        public string insertorupdateform(string id,string formname, string parentid, byte[] photo, string status, int btnbackclr, int labelforclr, string mode,
            string user,string display)
        {
            Opencon();
            cmd = new SqlCommand("spinsertorupdateform", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@FormName", formname);
            cmd.Parameters.AddWithValue("@ParentId", parentid);
            cmd.Parameters.AddWithValue("@FormImage", photo);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@buttonBackcolor", btnbackclr);
            cmd.Parameters.AddWithValue("@labelforecolor", labelforclr);
            cmd.Parameters.AddWithValue("@mode", mode);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@DisplayName", display);
            return cmd.ExecuteScalar().ToString();
            }
        public string deleteform(string Formid)
        {
            Opencon();
            cmd=new SqlCommand("spdeleteform",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@formid",Formid);
            return cmd.ExecuteScalar().ToString();
        }
        public DataSet GetUnit()
        {
            Opencon();
            cmd = new SqlCommand("spGetUnit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;

        }
        public DataSet getforms()
        {
            Opencon();
            cmd = new SqlCommand("spGetForms", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;

        }

        public string GetUnitbyId(string id)
        {
            Opencon();
            cmd = new SqlCommand("spGetUnitById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteScalar().ToString();

        }
        public string DeleteUnit(string id)
        {
            Opencon();
            cmd = new SqlCommand("spDeleteUnit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteScalar().ToString();
        }
        public string InsertBrand(string brand, string remarks)
        {
            Opencon();
            cmd = new SqlCommand("spInsertBrand", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", brand);
            cmd.Parameters.AddWithValue("@remarks", remarks);         
            return cmd.ExecuteScalar().ToString();
        }
        public string UpdateBrand(string brand, string remarks,string id)
        {
            Opencon();
            cmd = new SqlCommand("spUpdateBrand", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@brand", brand);
            cmd.Parameters.AddWithValue("@remarks", remarks);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteScalar().ToString();
        }
        public string DeleteBrand(string id)
        {
            Opencon();
            cmd = new SqlCommand("spDeleteBrand", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteScalar().ToString();
        }
        public DataSet GetBrand()
        {
            Opencon();
            cmd = new SqlCommand("spGetBrand",con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public SqlDataReader GetBrandDetail(string id)
        {
            Opencon();
            cmd = new SqlCommand("spGetBrandDetails",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr=cmd.ExecuteReader();
            return dr;
        }
          public SqlDataReader GetUnitDetail(string id)
        {
            Opencon();
            cmd = new SqlCommand("spGetUnitDetails",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr=cmd.ExecuteReader();
            return dr;
        }
          //public DataSet GetTax()
          //{
          //    Opencon();
          //    cmd = new SqlCommand("spGetTax", con);
          //    cmd.CommandType = CommandType.StoredProcedure;
          //    DataSet ds = new DataSet();
          //    SqlDataAdapter da = new SqlDataAdapter(cmd);
          //    da.Fill(ds);
          //    return ds;

          //}
          public DataSet InsertStoreOpenNCloed(string UserId, DateTime date, DateTime Storedate, string status, string mode)
          {
              Opencon();
              cmd = new SqlCommand("Sp_savestore", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@UserId", UserId);
              cmd.Parameters.AddWithValue("@Date", date);
              cmd.Parameters.AddWithValue("@StoreDate", Storedate);
              cmd.Parameters.AddWithValue("@status ", status);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }
          public string InserorUpdateItem(string catid, string itemcode, string itemname, string brandid, string unitid, string barcode, string costprice,
          string taxid, string selprice, string itemtype, string id, string mode, string ItemSt, string SellPriceNonAC, string department, string sellpricehome,
              byte[] photo, string itemarabic,int pricechangestatus)
          {
              Opencon();
              cmd = new SqlCommand("spInsertorUpdateItm", con);
              cmd.CommandType = CommandType.StoredProcedure;

              cmd.Parameters.AddWithValue("@catid", catid);
              cmd.Parameters.AddWithValue("@itemcode", itemcode);
              cmd.Parameters.AddWithValue("@itemname", itemname);
              cmd.Parameters.AddWithValue("@brandid", brandid);
              cmd.Parameters.AddWithValue("@unitid", unitid);
              cmd.Parameters.AddWithValue("@barcode", barcode);
              cmd.Parameters.AddWithValue("@costprice", costprice);
              cmd.Parameters.AddWithValue("@taxid", taxid);
              cmd.Parameters.AddWithValue("@sellprice", selprice);
              cmd.Parameters.AddWithValue("@itemtype", itemtype);
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@Itemst", ItemSt);
              cmd.Parameters.AddWithValue("@SellPriceNonAC", SellPriceNonAC);
              cmd.Parameters.AddWithValue("@department", department);
              cmd.Parameters.AddWithValue("@SellPriceHome", sellpricehome);
              cmd.Parameters.AddWithValue("@photo", photo);
              cmd.Parameters.AddWithValue("@itemarabic", itemarabic);
              cmd.Parameters.AddWithValue("@Pricechangestatus", pricechangestatus);
              return cmd.ExecuteScalar().ToString();
          }

        ///////////////////////HISHAM////////////////////////////////////////////


          //public void FloatValueValidate(KeyPressEventArgs e)
          //{
          //    if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)
          //        e.Handled = false;
          //    else
          //        e.Handled = true;
          //}
          public DataSet GetTax()
          {
              Opencon();
              cmd = new SqlCommand("spGetTax", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;

          }
          public SqlDataReader GetExpenceById(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetExpenceById", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public string DeleteExpence(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteExpence", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();

          }
          public void InsertExpence( string expence, DateTime date, string discription, string amount)
          {
              Opencon();
              cmd = new SqlCommand("spInsertExpence", con);
              cmd.CommandType = CommandType.StoredProcedure;            
              cmd.Parameters.AddWithValue("@expence", expence);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@discription", discription);
              cmd.Parameters.AddWithValue("@amount", amount);            
              cmd.ExecuteNonQuery();

          }

          public DataSet GetExpence()
          {
              Opencon();
              cmd = new SqlCommand("spGetExpence", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }
          public DataTable getparentid(string formname)
          {
              Opencon();
              cmd = new SqlCommand("spgetparentid", con);
              cmd.Parameters.AddWithValue("@formname", formname);
              DataTable dt = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(dt);
              return dt;        
          }
          public void DeleteIncome(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteIncome", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.ExecuteNonQuery();

          }
          public void DeleteExpense(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteExpence", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.ExecuteNonQuery();

          }
          public SqlDataReader GetIncomeById(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetIncomeById", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }

          public string InsertorUpdateIncome(string mode, string income, DateTime date, string discription, string amount, string id)
          {
              Opencon();
              cmd = new SqlCommand("spInsertIncome", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@income", income);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@discription", discription);
              cmd.Parameters.AddWithValue("@amount", amount);
              cmd.Parameters.AddWithValue("@mode", mode);
              return cmd.ExecuteScalar().ToString();
          }

          public DataSet GetIncome()
              {    
              Opencon();
              cmd = new SqlCommand("spGetIncome", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }
          public SqlDataReader GetTaxbyId(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetTaxbyId", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;

          }
          public string DeleteTax(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteTax", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public string InsertorUpdateTax(string name, string percentage, string mode, string id)
          {
              Opencon();
              cmd = new SqlCommand("spInsertTax", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@tax", name);
              cmd.Parameters.AddWithValue("@percent", percentage);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }

          public string DeleteCategory(String id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteCategory", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public DataTable GetCategorybyId(String id)
          {
              Opencon();

              cmd = new SqlCommand("spGetCategorybyId", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;   
          }
          public SqlDataReader getimage(String itemid)
          {
              Opencon();
              cmd = new SqlCommand("spgetimage", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@itemid", itemid);
              SqlDataReader da = cmd.ExecuteReader();
              return da;
          }
          public SqlDataReader getdepartmentbyid(string id)
          {
              Opencon();

              cmd = new SqlCommand("spgetdepartmentbyid", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader da = cmd.ExecuteReader();
              //da.Fill(ds);
              return da;
          }
          public SqlDataReader getdep()
          {
              Opencon();

              cmd = new SqlCommand("spdep", con);
              cmd.CommandType = CommandType.StoredProcedure;
             // cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader da = cmd.ExecuteReader();
              //da.Fill(ds);
              return da;
          }
             




          
          public DataSet GetCategory()
          {
              Opencon();
              cmd = new SqlCommand("spGetCategory", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;


          }
          public DataSet GetCategory(int product)
          {
              Opencon();
              cmd = new SqlCommand("spGetCategorybyProduct", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@productid", product);
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;


          }
          public string InsertorUpdateCategory(string category, string mode, string remarks, string id, int product, byte[] photo)
          {
              Opencon();
              cmd = new SqlCommand("spInsertCategory", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@category", category);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              cmd.Parameters.AddWithValue("@productstatus", product);
              cmd.Parameters.AddWithValue("@photo", photo);
              return cmd.ExecuteScalar().ToString();
          }
		
        ///////////////////////////////////////////remya////////////

          public DataTable GetItemDetail(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetItemDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
             // SqlDataReader dr = cmd.ExecuteReader();
              return dt;
          }
          public DataTable GetSt(int itemcode)
          {
              Opencon();
              cmd = new SqlCommand("GetSt", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@itemcode", itemcode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              
              return dt;
          }
          public DataTable getformproperties(string formid)
          {
              Opencon();
              cmd = new SqlCommand("spGetFormDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@FormId", formid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable gettopmostitem(int catid)
          {
              Opencon();
              cmd = new SqlCommand("gettopmostitem", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@catid", catid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }



          public SqlDataReader GetItemDetail1(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetItemDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public DataSet GetItem()
          {
              Opencon();
              cmd = new SqlCommand("spGetItem", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;

          }
          public DataSet GetItem(int product)
          {
              Opencon();
              cmd = new SqlCommand("spGetItembyproduct", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@pid", product);
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;

          }
          public string DeleteItem(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDelItem",con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public DataSet GetItemCode()
          {
              Opencon();
              cmd = new SqlCommand("spGetItemCode", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;             
          }
         public DataSet GetItemCodeForStock()
          {
              Opencon();
              cmd = new SqlCommand("spGetItemCodeforStock", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;              
          }

          public DataTable SearchItem(string txt,string itemid,string cat,string mode)
          {
              Opencon();
              cmd=new SqlCommand("SpSearchItem",con);
              cmd.CommandType=CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Keyword", txt);
              cmd.Parameters.AddWithValue("@id", itemid);
              //cmd.Parameters.AddWithValue("@brand", brand);
              cmd.Parameters.AddWithValue("@cat", cat);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da=new SqlDataAdapter(cmd);
                 DataTable dt=new DataTable();
              da.Fill(dt);
              return dt;
          }

          public SqlDataReader GetCostPrice(string id)
          {
              Opencon();
              cmd=new SqlCommand("spGetCostPrice",con);
              cmd.CommandType=CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id",id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }


        
          public DataSet GetItemnamestock()
          {
              Opencon();
              cmd = new SqlCommand("spGetItemnameFromStock", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;


          }
          public DataTable SearchStiock( string mode,string start,string end,string id)
          {
              Opencon();
              cmd = new SqlCommand("spSearchStock", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@startdate", start);
              cmd.Parameters.AddWithValue("@enddate", end);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable GetStockDetails( string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetStockDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@sid", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable GetProductStockDetails(string id)
          {
              Opencon();
              cmd = new SqlCommand("SP_GetProductStockDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@sid", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable GetProductDamageDetails(string id)
          {
              Opencon();
              cmd = new SqlCommand("SP_GetProductDamageDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@sid", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
       
          public string DeleteStockMaster(String id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteStockMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public string SaveTable(string name,string remarks,string ACStatus)
          {
              Opencon();
              cmd = new SqlCommand("spSaveTable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              cmd.Parameters.AddWithValue("@ACStatus", ACStatus);
              return cmd.ExecuteScalar().ToString();
          }


          public string UpdateTable(string name, string remarks, string ACStatus, string ID)
          {
              Opencon();
              cmd = new SqlCommand("UpdateTable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              //cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              cmd.Parameters.AddWithValue("@ACStatus", ACStatus);
              cmd.Parameters.AddWithValue("@Id", ID);
              return cmd.ExecuteScalar().ToString();
          }
          public DataTable GetTableDetails(string TableName)
          {
              Opencon();
              cmd = new SqlCommand("SP_GetTableDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@TableName", TableName);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          public DataTable InsertProductStockEntry (DateTime Date, string Product_Id, string Quantity, string Remarks)
          {
              Opencon();
              cmd = new SqlCommand("SP_InsertProductStockEntry",con);
              cmd.CommandType = CommandType.StoredProcedure;
         
              cmd.Parameters.AddWithValue("@Date", Date);
              cmd.Parameters.AddWithValue("@Product_ID", Product_Id);
              cmd.Parameters.AddWithValue("@Quantity", Quantity);
              cmd.Parameters.AddWithValue("@Remarks",Remarks);

              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          public DataTable InsertDamageEntry(DateTime Date, string Item_Id, string Quantity, string Remarks)
          {
              Opencon();
              cmd = new SqlCommand("SP_InsertDamageEntry", con);
              cmd.CommandType = CommandType.StoredProcedure;

              cmd.Parameters.AddWithValue("@Date", Date);
              cmd.Parameters.AddWithValue("@Item_ID", Item_Id);
              cmd.Parameters.AddWithValue("@Quantity", Quantity);
              cmd.Parameters.AddWithValue("@Remarks", Remarks);

              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public int DeleteProductStockEntry(string Id)
          {
              Opencon();
              cmd = new SqlCommand("SP_DeleteProductStockEntry", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Id);
              return Convert.ToInt32(cmd.ExecuteScalar().ToString());
          }
          public int DeleteDamageEntry(string Id)
          {
              Opencon();
              cmd = new SqlCommand("SP_DeleteProductDamageEntry", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Id);
              return Convert.ToInt32(cmd.ExecuteScalar().ToString());
          }
          public string SaveWaiter(string code,string name, string remarks)
          {
              Opencon();
              cmd = new SqlCommand("spSaveWaiter", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@code", code);
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              return cmd.ExecuteScalar().ToString();
          }
          

          public DataSet GetTable()
          {
              Opencon();
              cmd = new SqlCommand("spGetTable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;


          }
          public DataSet GetWaitername(string name)
          {
              Opencon();

              cmd = new SqlCommand("[spwaitername]", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Name", name);
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;



          }
          public DataSet GetWaiter()
          {
              Opencon();

              cmd = new SqlCommand("[spGetWaiter]", con);
              cmd.CommandType = CommandType.StoredProcedure;
             // cmd.Parameters.AddWithValue("@Name", name);
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;



          }

          public SqlDataReader GetItemSellPrice(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetSellPrice", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public SqlDataReader GETdept(String id)
          {
              Opencon();
              cmd = new SqlCommand("spGETdept", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;

          }


          public SqlDataReader GetProductStock(string ItemId)
          {
              Opencon();
              cmd = new SqlCommand("SP_GetProductStock", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@ItemId", ItemId);
              SqlDataReader dr1 = cmd.ExecuteReader();
              return dr1;
          }
          public string InsertKotMaster(string custname, string custmob, string custemail, string totalamount, string billingst, string table, string waiter,string custstat,string token,DateTime date1,string department,string TokenStatus )
          {
              Opencon();
              cmd = new SqlCommand("spSaveKotMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@custname", custname);
              cmd.Parameters.AddWithValue("@custmob", custmob);
              cmd.Parameters.AddWithValue("@custemail", custemail);
              cmd.Parameters.AddWithValue("@totalAmount", totalamount);
              cmd.Parameters.AddWithValue("@billingStatus", billingst);
              cmd.Parameters.AddWithValue("@tableId", table);
              cmd.Parameters.AddWithValue("@WaiterId", waiter);
              cmd.Parameters.AddWithValue("@custstatus", custstat);
              cmd.Parameters.AddWithValue("@Token", token);
              cmd.Parameters.AddWithValue("@date", date1);
              cmd.Parameters.AddWithValue("@department", department);
              cmd.Parameters.AddWithValue("@TokenStatus", TokenStatus);
  
  
              return cmd.ExecuteScalar().ToString();
          }
          public void InsertKotDetail(string kotId, string ItemId, string Quantity, string Rate, string Amount)
          {
            Opencon();
            cmd=new SqlCommand("spInsertKotDetail",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kotid",kotId);
            cmd.Parameters.AddWithValue("@itemid",ItemId);
            cmd.Parameters.AddWithValue("@quantity",Quantity);
            cmd.Parameters.AddWithValue("@rate",Rate);
            cmd.Parameters.AddWithValue("@amount", Amount);  
            cmd.ExecuteNonQuery();
          }
          public DataTable GetKotDetails(string tableid)
          {
              Opencon();
              cmd = new SqlCommand("spGetKotDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@table", tableid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable Getchildbuttons(string userId,string parentid)
        {
              Opencon();
              cmd = new SqlCommand("spviewbuttons", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@userId", userId);
              cmd.Parameters.AddWithValue("@parentId", parentid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

        }

          public DataTable openformsbyid(string id)
          {
              Opencon();
              cmd = new SqlCommand("spgetform", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }




          public DataTable getitemdepartment()
          {
              Opencon();
              cmd = new SqlCommand("spgetitemdepartment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              //cmd.Parameters.AddWithValue("@table", tableid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable getgroupbydepartment(string id)
          {
              Opencon();
              cmd = new SqlCommand("spgetgroupbydept");
              cmd.Parameters.AddWithValue("@id",id);
              SqlDataAdapter da = new SqlDataAdapter();
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public string InsertorUpdatedepartment(string department,string remarks,string mode, string id)
        {
             Opencon();
            SqlCommand  cmd=new SqlCommand("spInsertupdatedepartment",con);
              cmd.CommandType=CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@department",department);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@Id", id);
              return cmd.ExecuteScalar().ToString();
        
              
              
        }
        public string deletedepartment(string Id)
        {
            Opencon();
            cmd = new SqlCommand("spdeletedepartment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
           return cmd.ExecuteScalar().ToString();
        
        }
        public DataSet getdepartrment()
        {
            Opencon();
            cmd = new SqlCommand("getdepartment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;




        }
          public SqlDataReader GetWaiterbyTable(string tableid)
          {
              Opencon();
              cmd = new SqlCommand("spGetWaiterbyTable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@table", tableid);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public string InsertInvoiceMaster(string inNo, DateTime date, string custname, string custmob, string custemail,
              int status, string total, int compliment, string discount, string paidamnt, string custst, string custid, string userid,
              string packingcharge, int billtype, DateTime storedate, int paymode, string cashamt, string cardamt,string billingmode,string tax)
          {
              Opencon();
              cmd = new SqlCommand("spInsertInvoiceMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceno", inNo);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@custname", custname);
              cmd.Parameters.AddWithValue("@custMob", custmob);
              cmd.Parameters.AddWithValue("@custemail", custemail);
              cmd.Parameters.AddWithValue("@status", status);
              cmd.Parameters.AddWithValue("@totalAmount", total);
              cmd.Parameters.AddWithValue("@compliment", compliment);
              cmd.Parameters.AddWithValue("@discount", discount);
              cmd.Parameters.AddWithValue("@PaidAmount", paidamnt);
              cmd.Parameters.AddWithValue("@CustomerId", custid);
              cmd.Parameters.AddWithValue("@CustStatus", custst);
              cmd.Parameters.AddWithValue("@UserId", globalvariable.userid);
              cmd.Parameters.AddWithValue("@PckCharge", packingcharge);
              cmd.Parameters.AddWithValue("@billtype", billtype);
              cmd.Parameters.AddWithValue("@storedate", storedate);
              cmd.Parameters.AddWithValue("@Paymode", paymode);
              cmd.Parameters.AddWithValue("@CashAmt", cashamt);
              cmd.Parameters.AddWithValue("@CardAmt", cardamt);
              cmd.Parameters.AddWithValue("@BillingMode", billingmode);
              cmd.Parameters.AddWithValue("@tax", tax);
              return cmd.ExecuteScalar().ToString();
          }
          public void InsertInvoiceDetails(string inid, string itemid, string quantity, string rate, string amount, string kotid,string tableid,string waiterid,string token)
          {
              Opencon();
              cmd=new SqlCommand("spInsertInvoiceDetails",con);
              cmd.CommandType=CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoice",inid);
               cmd.Parameters.AddWithValue("@itemid",itemid);
               cmd.Parameters.AddWithValue("@quantity",quantity);
               cmd.Parameters.AddWithValue("@rate",rate);
               cmd.Parameters.AddWithValue("@amount", amount);
               cmd.Parameters.AddWithValue("@KotId", kotid);
               cmd.Parameters.AddWithValue("@tableid", tableid);
               cmd.Parameters.AddWithValue("@waiterId", waiterid);
               cmd.Parameters.AddWithValue("@token", token);
                int k=  cmd.ExecuteNonQuery();

          }


          public DataTable GetKotDetailsByToken(string token,string billst)
          {
              Opencon();
              cmd = new SqlCommand("spGetKotDetailsByToken", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@token", token);
              cmd.Parameters.AddWithValue("@TokenStatus", billst);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable SpGetInvoiceMasterAmounts(int mode, int status, DateTime st, DateTime en)
          {
              Opencon();
              cmd = new SqlCommand("SpGetInvoiceMasterAmounts", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@sttus", status);
              cmd.Parameters.AddWithValue("@start", st);
              cmd.Parameters.AddWithValue("@end", en);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public void InsertSettings(int Inst, string Inpref, string instart, int empst, string emppref, string empstart, int Custst, string custpref, string custstart, int dealerst, string dealerpref, string dealerstart)
          {
              Opencon();
              cmd = new SqlCommand("spInsertSetings", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@instatus", Inst);
              cmd.Parameters.AddWithValue("@inPrefix", Inpref);
              cmd.Parameters.AddWithValue("@instarting", instart);
              cmd.Parameters.AddWithValue("@empStatus", empst);
              cmd.Parameters.AddWithValue("@empPrefix", emppref);
              cmd.Parameters.AddWithValue("@empStarting", empstart);
              cmd.Parameters.AddWithValue("@custStatus", Custst);
              cmd.Parameters.AddWithValue("@custPrefix", custpref);
              cmd.Parameters.AddWithValue("@custStarting", custstart);
              cmd.Parameters.AddWithValue("@dealerStatus", dealerst);
              cmd.Parameters.AddWithValue("@dealerPrefix", dealerpref);
              cmd.Parameters.AddWithValue("@dealerStarting", dealerstart);              
              cmd.ExecuteNonQuery();
          }
          public SqlDataReader GetSettings()
          {
              Opencon();
              cmd = new SqlCommand("spGetSetttings", con);
              cmd.CommandType = CommandType.StoredProcedure;            
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public SqlDataReader GetInvoiceNo()
          {
              Opencon();
              cmd = new SqlCommand("spGetInvoiceNo", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@char", "1");
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public SqlDataReader GenerateItemCode()
          {
              Opencon();
              cmd = new SqlCommand("spGenerateItemCode", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }

          public DataTable GetPendingKOTDineIn()
          {
              Opencon();
              cmd = new SqlCommand("spGetPendingKOTDineIn", con);
              cmd.CommandType = CommandType.StoredProcedure;           
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable PendingKOTDineIn(string rowinde)
          {
              Opencon();
              cmd = new SqlCommand("spGetPendingKOTDineIn", con);
              cmd.CommandType = CommandType.StoredProcedure;          
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

        public DataTable GetPendingKOTTakeAway()
          {
              Opencon();
              cmd = new SqlCommand("spGetPendingKOTTakeAway", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable InvoiceSearch(string Query)
          {
              Opencon();
              cmd = new SqlCommand(Query, con);              
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable KOTSearch(string Query)
          {
              Opencon();
              cmd = new SqlCommand(Query, con);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataSet GetInvoiceCombo()
          {
              Opencon();
              cmd = new SqlCommand("spGetInvoiceNoCombo", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;

          }
          public DataSet GetInvoiceComboPaymode()
          {
              Opencon();
              cmd = new SqlCommand("spGetInvoiceNoComboPaymode", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;

          }

          public DataSet GetToken()
          {
              Opencon();
              cmd = new SqlCommand("spGetToken", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;


          }
          public DataSet GetKOTByTable(string tab)
          {
              Opencon();
              cmd = new SqlCommand("spGetKotByTable", con);
              cmd.Parameters.AddWithValue("@tab",tab);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;


          }
          public DataSet GetKOTByToken(string tok)
          {
              Opencon();
              cmd = new SqlCommand("spGetKotByToken", con);
              cmd.Parameters.AddWithValue("@toke", tok);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }
          public DataTable KOTSearchByKotID(string ID)
          {
              Opencon();
              cmd = new SqlCommand("spGetKOTDetailsByKOT", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@KOTID", ID);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public void DeleteKot(string id)
          {
              Opencon();
              cmd=new SqlCommand("spDeleteKot",con);
              cmd.CommandType=CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@kot", id);
              cmd.ExecuteNonQuery();
          }
          public void DeleteKotDetaile(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteKotDetaile", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@kot", id);
              cmd.ExecuteNonQuery();
          }
          public void DeleteKotMaster(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteKotMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@kot", id);
              cmd.ExecuteNonQuery();
          }
          public DataTable InvoiceDatails(string InNo)
          {
              Opencon();
              cmd = new SqlCommand("spGetInvoiceDetaills", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceNo", InNo);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public SqlDataReader GetInvoiceMasterDetail(string InNo)
          {
              Opencon();
              cmd = new SqlCommand("spGeyInvoiceMasterDetail", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceNo", InNo);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public void DeleteBill(string ID)
          {
              Opencon();
              cmd=new SqlCommand("spDeleteBill",con);
              cmd.CommandType=CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceId", ID);
              cmd.ExecuteNonQuery();
          }
          public string GetBillingSt(string ID)
          {
              Opencon();
              cmd = new SqlCommand("spGetBillingSt", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceId", ID);
              return cmd.ExecuteScalar().ToString();
          }
          public DataTable GetAllKOTDetails(string ID)
          {
              Opencon();
              cmd = new SqlCommand("spGetAllKotDetail", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@KotNo", ID);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public SqlDataReader GetAllKOTMasterDetails(string ID)
          {
              Opencon();
              cmd = new SqlCommand("spGetAllKotMasterDetail", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@KotNo", ID);
             // SqlDataAdapter da = new SqlDataAdapter(cmd);
            //  DataTable dt = new DataTable();
              SqlDataReader dr = cmd.ExecuteReader();
              //da.Fill(dt);
              return dr;
          }
          
          public string InsertDeletedKotMaster(string custname, string custmob, string custemail, string totalamount, string billingst, string table, string waiter, string custstat, string token, DateTime date1,string kot)
          {
              Opencon();
              cmd = new SqlCommand("spInsertDeletedKotMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@custname", custname);
              cmd.Parameters.AddWithValue("@custmob", custmob);
              cmd.Parameters.AddWithValue("@custemail", custemail);
              cmd.Parameters.AddWithValue("@totalAmount", totalamount);
              cmd.Parameters.AddWithValue("@billingStatus", billingst);
              cmd.Parameters.AddWithValue("@tableId", table);
              cmd.Parameters.AddWithValue("@WaiterId", waiter);
              cmd.Parameters.AddWithValue("@custstatus", custstat);
              cmd.Parameters.AddWithValue("@Token", token);
              cmd.Parameters.AddWithValue("@date", date1);
              cmd.Parameters.AddWithValue("@Kot", kot);
              return cmd.ExecuteScalar().ToString();
          }
          public void InsertDeletedKotDetail(string kotId, string ItemId, string Quantity, string Rate, string Amount)
          {
              Opencon();
              cmd = new SqlCommand("spInsertDeletedKotDetail", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@kotid", kotId);
              cmd.Parameters.AddWithValue("@itemid", ItemId);
              cmd.Parameters.AddWithValue("@quantity", Quantity);
              cmd.Parameters.AddWithValue("@rate", Rate);
              cmd.Parameters.AddWithValue("@amount", Amount);
              cmd.ExecuteNonQuery();
          }
          public SqlDataReader GetAllInvoiceMasterDetails(string ID)
          {
              Opencon();
              cmd = new SqlCommand("spGetAllInvoiceMasterDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@InvoiceNo", ID);              
              SqlDataReader dr = cmd.ExecuteReader();             
              return dr;
          }
          public DataTable GetAllInvoiceDetails(string ID)
          {
              Opencon();
              cmd = new SqlCommand("spGetAllInvoiceDetail", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@InvoiceNo", ID);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public string InsertDeletedInvoiceMaster(string inNo, DateTime date, string custname, string custmob, string custemail, string status, string total,string invoiceId,string comp,string disc) 
          {
              Opencon();
              cmd = new SqlCommand("spInsertDeletedInvoiceMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceno", inNo);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@custname", custname);
              cmd.Parameters.AddWithValue("@custMob", custmob);
              cmd.Parameters.AddWithValue("@custemail", custemail);
              cmd.Parameters.AddWithValue("@status", status);
              cmd.Parameters.AddWithValue("@totalAmount", total);
              cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);
              cmd.Parameters.AddWithValue("@Comliment", comp);
              cmd.Parameters.AddWithValue("@discount", disc);
              return cmd.ExecuteScalar().ToString();
          }
          public void InsertDeletedInvoiceDetails(string inid, string itemid, string quantity, string rate, string amount, string kotid, string tableid, string waiterid, string token)
          {
              Opencon();
              cmd = new SqlCommand("spInsertDeletedInvoiceDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoice", inid);
              cmd.Parameters.AddWithValue("@itemid", itemid);
              cmd.Parameters.AddWithValue("@quantity", quantity);
              cmd.Parameters.AddWithValue("@rate", rate);
              cmd.Parameters.AddWithValue("@amount", amount);
              cmd.Parameters.AddWithValue("@KotId", kotid);
              cmd.Parameters.AddWithValue("@tableid", tableid);
              cmd.Parameters.AddWithValue("@waiterId", waiterid);
              cmd.Parameters.AddWithValue("@token", token);
              cmd.ExecuteNonQuery();
          }
          public string DeletTable(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteTable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public string DeleteWaiter(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteWaiter", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public string DeleteWaitername(string name)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteWaitername", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Name", name);
              return cmd.ExecuteScalar().ToString();
          }

          public DataSet GetOtherIncomeType()
          {
              Opencon();
              cmd = new SqlCommand("spGetOtherIncomeType", con);
              //cmd.Parameters.AddWithValue("@toke", tok);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }
          public DataSet GetOtherExpenceType()
          {
              Opencon();
              cmd = new SqlCommand("spGetOtherExpenceType", con);
              //cmd.Parameters.AddWithValue("@toke", tok);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }
          public void InsertOtherIncome(DateTime date, string Amount, string IncomeType,string Description)
          {
              Opencon();
              cmd = new SqlCommand("spInsertIncome", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@income", IncomeType);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@amount", Amount);
              cmd.Parameters.AddWithValue("@discription", Description);
              cmd.ExecuteNonQuery();
          }
          public DataTable SearchOtherIncome(string start,string end,string type,string mode)
          {
              Opencon();
              cmd = new SqlCommand("spGetOtherIncomeDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@start", start);
              cmd.Parameters.AddWithValue("@end", end);
              cmd.Parameters.AddWithValue("@type", type);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public DataTable SearchOtherExpence(string start, string end, string type, string mode)
          {
              Opencon();
              cmd = new SqlCommand("spGetExpenceDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@start", start);
              cmd.Parameters.AddWithValue("@end", end);
              cmd.Parameters.AddWithValue("@type", type);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public void UpdateOtherIncome(DateTime date, string Amount, string IncomeType, string Description,string id)
          {
              Opencon();
              cmd = new SqlCommand("spUpdateOtherIncome", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@income", IncomeType);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@amount", Amount);
              cmd.Parameters.AddWithValue("@discription", Description);
              cmd.ExecuteNonQuery();
          }
          public void UpdateOtherExpence(DateTime date, string Amount, string IncomeType, string Description, string id)
          {
              Opencon();
              cmd = new SqlCommand("spUpdateOtherExpence", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@income", IncomeType);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@amount", Amount);
              cmd.Parameters.AddWithValue("@discription", Description);
              cmd.ExecuteNonQuery();
          }
          public SqlDataReader GetOtherIncomeById(string ID)
          {
              Opencon();
              cmd = new SqlCommand("spGetOtherIncomeById", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", ID);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }


        /// <summary>
        /// //////////////////////////////////////////////////////////////user///////////////////////////////////
        /// </summary>
        /// <returns></returns>
         public DataTable EditUser(string userid)
        {
            Opencon();
            cmd = new SqlCommand("SP_EDIT_USER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERID", userid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
          public DataSet GetUsername()
          {
              Opencon();
              cmd = new SqlCommand("SP_GETUSERNAME", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }
          public string InsertUserAccount(string acctype, string username, string password, string name, string contactno, string designationid)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_USERACCOUNT", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@acctype", acctype);
              cmd.Parameters.AddWithValue("@username", username);
              cmd.Parameters.AddWithValue("@password", password);
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@contactno", contactno);
              cmd.Parameters.AddWithValue("@designationid", designationid);
              cmd.Parameters.AddWithValue("@status", 1);
              return cmd.ExecuteScalar().ToString();
          }

          public void DeleteUser(string id)
          {
              Opencon();
              cmd = new SqlCommand("sp_Del_USER", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.ExecuteNonQuery();
          }
          public string UpdateUser(string userid, string acctype, string username, string password, string name, string contactno, string designation)
          {
              Opencon();
              cmd = new SqlCommand("SP_UPDATE_USER", con);
              cmd.CommandType = CommandType.StoredProcedure;
              //  cmd.Parameters.AddWithValue("SP_UPDATE_USER",userid);
              cmd.Parameters.AddWithValue("@userid", userid);
              cmd.Parameters.AddWithValue("@acctype", acctype);
              cmd.Parameters.AddWithValue("@username", username);
              cmd.Parameters.AddWithValue("@password", password);
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@contactno", contactno);
              cmd.Parameters.AddWithValue("@designation", designation);

              return cmd.ExecuteScalar().ToString();

          }

        ////////////////////////////////////////////////deigntion/////////////////////////////////

          public DataSet GetDesignation()
          {
              Opencon();
              cmd = new SqlCommand("spGetDesignation", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;


          }
          public string InsertDesignation(string designationname, string remarks, string designation_id, int mode)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_DESIGNATION", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@designationname", designationname);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              cmd.Parameters.AddWithValue("@designation_id", designation_id);
              cmd.Parameters.AddWithValue("@mode", mode);
              return cmd.ExecuteScalar().ToString();
          }
          public string DeleteDesignation(string id)
          {
              Opencon();
              cmd = new SqlCommand("sp_Del_Designation", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public DataTable selectdesignation(string designationid)
          {
              Opencon();
              cmd = new SqlCommand("sp_selectdesigntn", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@designation_id", designationid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              ad.Fill(dt);
              return dt;
          }

        ///////////////////////////////////////useraccounttype/////////////////////////

          public DataSet Getusertype()
          {
              Opencon();
              cmd = new SqlCommand("Sp_Getusertype", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }
          public string insertuseracctype(string useracctype, string remarks, string Acc_id, int mode)
          {
              Opencon();
              cmd = new SqlCommand("Sp_SAVE_ACCTYPE", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Acc_type", useracctype);
              cmd.Parameters.AddWithValue("@Remarks", remarks);
              cmd.Parameters.AddWithValue("@Acc_id", Acc_id);
              cmd.Parameters.AddWithValue("@mode", mode);
              return cmd.ExecuteScalar().ToString();

          }
          public DataTable Selectusertype(string usertypeid)
          {
              Opencon();
              cmd = new SqlCommand("SP_EditUserType", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@UserAcc_id", usertypeid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public DataTable GetFormUserRights(string Id, string Form)
          {
             
              Opencon();
              cmd = new SqlCommand("spGetFormUserRights", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Id);
              cmd.Parameters.AddWithValue("@Form", Form);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
             
          }
        /////////////////////////////userrights//////////////////////////////////////////

          public DataTable GetUser()
          {
              Opencon();
              cmd = new SqlCommand("spGetUser", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable ds = new DataTable();
              da.Fill(ds);
              return ds;
          }
          public DataSet GetUserForRightSettings()
          {
              Opencon();
              cmd = new SqlCommand("spGetUserForRightSettings", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }
          public DataTable GetUserRights(string UserId)
          {
              Opencon();
              cmd = new SqlCommand("spGetUserRights", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@UserId", UserId);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable GetFormNames()
          {
              Opencon();
              cmd = new SqlCommand("spGetFormName", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable getid()
          {
              Opencon();
              cmd = new SqlCommand("spgetsatatus", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public void InsertUserRightSettings(string UserId, string FormId, string ViewStatus, string SaveStatus, string UpdateStatus, string DeleteStatus)
          {
              Opencon();
              cmd = new SqlCommand("spInsertUserRightSettings", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@UserId", UserId);
              cmd.Parameters.AddWithValue("@FormId", FormId);
              cmd.Parameters.AddWithValue("@ViewStatus", ViewStatus);
              cmd.Parameters.AddWithValue("@SaveStatus", SaveStatus);
              cmd.Parameters.AddWithValue("@UpdateStatus", UpdateStatus);
              cmd.Parameters.AddWithValue("@DeleteStatus", DeleteStatus);
            
              cmd.ExecuteNonQuery();
          }
          public void DeleteUserRightSettings(string UserId)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteUserSettings", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@UserId", UserId);
              cmd.ExecuteNonQuery();
          }
    
          public DataTable login(string username, string password, DateTime logintime, int status, int counterid, int user_id,int chkstatus)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_LOGIN", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@username", username);
              cmd.Parameters.AddWithValue("@password", password);
              cmd.Parameters.AddWithValue("@logintime", logintime);
              cmd.Parameters.AddWithValue("@status", status);
              cmd.Parameters.AddWithValue("@counterid", counterid);
              cmd.Parameters.AddWithValue("@user_id", user_id);
              cmd.Parameters.AddWithValue("@chkstaus", chkstatus);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public string InsertCounter(string countername, string remarks)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_COUNTER", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@countername", countername);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              return cmd.ExecuteScalar().ToString();
          }
          public string UpdateCounter(string Counter_id, string countername, string remarks)
          {
              Opencon();
              cmd = new SqlCommand("sp_UpdateCounter", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@counter_id", Counter_id);
              cmd.Parameters.AddWithValue("@counter_name", countername);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              return cmd.ExecuteScalar().ToString();
          }
          public DataTable updatelogin(string userid, DateTime log_out_time, DateTime Storedate, int counterId, string mode)
          {

              Opencon();
              cmd = new SqlCommand("Sp_UpdateLogin", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@userid", userid);
              cmd.Parameters.AddWithValue("@log_out_time", log_out_time);
              cmd.Parameters.AddWithValue("@Storedate", Storedate);
              cmd.Parameters.AddWithValue("@counterId", counterId);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public DataTable EditCounter(string Counter_id)
          {
              Opencon();
              cmd = new SqlCommand("sp_EditCounter", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@counter_id", Counter_id);
              DataTable dt = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(dt);
              return dt;

          }
          public void ClearTrnsactions()
          {
              Opencon();
              cmd = new SqlCommand("spClearTransactions",con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.ExecuteNonQuery();
          }
          public void BackUp(string Path)
          {
              Opencon();
              cmd = new SqlCommand("spDBBackup", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Path", Path);
              cmd.ExecuteNonQuery();
          }
          public void RestoreDB(string Path)
          {
              con.Close();
              SqlConnection MasterCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MasterConnection"].ConnectionString);
              MasterCon.Open();



              cmd = new SqlCommand("USE MASTER;ALTER DATABASE dbbizcarepos SET SINGLE_user WITH ROLLBACK IMMEDIATE;RESTORE DATABASE dbbizcarepos FROM DISK = '" + Path + "' WITH REPLACE;ALTER DATABASE DB_biscarepro SET multi_user WITH ROLLBACK IMMEDIATE;", MasterCon);

              
              //cmd = new SqlCommand("spDBRestore", MasterCon);
              //cmd.CommandType = CommandType.StoredProcedure;
              //cmd.Parameters.AddWithValue("@Path", Path);
             int k= cmd.ExecuteNonQuery();
          

              MasterCon.Close();
          }
          public string UpdatePassword(string id, string oldpassword, string newpassword)
          {
              Opencon();
              cmd = new SqlCommand("spUpdatePasswordchange", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@UserId", id);
              cmd.Parameters.AddWithValue("@oldpassword", oldpassword);
              cmd.Parameters.AddWithValue("@newpassword", newpassword);
              return cmd.ExecuteScalar().ToString();
          }
          public void ClearRestaurent()
          {
              Opencon();
              cmd = new SqlCommand("spResetCompany", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.ExecuteNonQuery();
 
          }
          public void ResetDb()
          {
              Opencon();
              //cmd = new SqlCommand("spResetDb", con);
              cmd = new SqlCommand("spWashDatabase", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.ExecuteNonQuery();
          }
          public void InsertRestuarant(string companyname, string legalname, string address, string telephone, string website, string email,
              string currency, string subcurrency, string openingbal, byte[] logo, byte[] invoiceheader,string deptwiseKot )
          {
              Opencon();
              cmd = new SqlCommand("spInsertRestuarant", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@companyname", companyname);
              cmd.Parameters.AddWithValue("@legalname", legalname);
              cmd.Parameters.AddWithValue("@Address", address);
              cmd.Parameters.AddWithValue("@telephone", telephone);
              cmd.Parameters.AddWithValue("@website", website);
              cmd.Parameters.AddWithValue("@email", email);
              cmd.Parameters.AddWithValue("@currency", currency);
              cmd.Parameters.AddWithValue("@subcurrency", subcurrency);
              cmd.Parameters.AddWithValue("@openingBalance", openingbal);
              cmd.Parameters.AddWithValue("@logo", logo);
              cmd.Parameters.AddWithValue("@InvoiceHeader", invoiceheader);
              cmd.Parameters.AddWithValue("@deptwiseKot", deptwiseKot);
              //cmd.Parameters.AddWithValue("@prefix", prefix);
              //cmd.Parameters.AddWithValue("@start", start);
              cmd.ExecuteNonQuery();
          }
          public void UpdateRestuarant(string companyname, string legalname, string address, string telephone, string website, string email,
               string currency, string subcurrency, string openingbal, byte[] logo, byte[] invoiceheader,string deptwisekot)
          {
              Opencon();
              cmd = new SqlCommand("spUpdateRestuarant", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@companyname", companyname);
              cmd.Parameters.AddWithValue("@legalname", legalname);
              cmd.Parameters.AddWithValue("@Address", address);
              cmd.Parameters.AddWithValue("@telephone", telephone);
              cmd.Parameters.AddWithValue("@website", website);
              cmd.Parameters.AddWithValue("@email", email);
              cmd.Parameters.AddWithValue("@currency", currency);
              cmd.Parameters.AddWithValue("@subcurrency", subcurrency);
              cmd.Parameters.AddWithValue("@openingBalance", openingbal);
              cmd.Parameters.AddWithValue("@logo", logo);
              cmd.Parameters.AddWithValue("@InvoiceHeader", invoiceheader);
              cmd.Parameters.AddWithValue("@deptwiseKot", deptwisekot);
              cmd.ExecuteNonQuery();
          }
          public SqlDataReader GetRestuarant()
          {
              Opencon();
              cmd=new SqlCommand("spGetRestuarant",con);
              cmd.CommandType=CommandType.StoredProcedure;
              SqlDataReader dr=cmd.ExecuteReader();
              return dr;
          }
          public string GetMaxIdAll()
          {
              Opencon();
              cmd = new SqlCommand("spGetMaxIdAll", con);
              cmd.CommandType = CommandType.StoredProcedure;
              return cmd.ExecuteScalar().ToString();
          }
       
          public DataSet GETMainitemid()
          {
              Opencon();
              cmd = new SqlCommand("spGetItemCode", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }

          public DataSet GETSubitemid()
          {
              Opencon();
              cmd = new SqlCommand("spGetIngradientItemCode", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }

          public DataTable SelectSubItems(int MainItemId)
          {
              Opencon();
              cmd = new SqlCommand("spSelectSubItem", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@MainItemId", MainItemId);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataSet getparents()
          {
              Opencon();
              cmd = new SqlCommand("spgetparents", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet dt = new DataSet();
              da.Fill(dt);
              return dt;
          }

          public string SelectUnitOfSub(int SubitemId)
          {
              Opencon();
              cmd = new SqlCommand("spSelectUnit", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@ItemId", SubitemId);
              return cmd.ExecuteScalar().ToString();
          }

          public void InsertItemMapping(int MainItemId, int SubItemId, string Qty)
          {
              Opencon();
              cmd = new SqlCommand("spInsertIngredients", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@ProductId", MainItemId);
              cmd.Parameters.AddWithValue("@IngredientId", SubItemId);
              cmd.Parameters.AddWithValue("@Quantity", Qty);
              cmd.ExecuteNonQuery();
          }

          public void insertfoodcost(string foodcost,int MainItemId, int SubItemId)
          {
              Opencon();
              cmd = new SqlCommand("Sp_Insert_FoodCost", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@foodcost", foodcost);
              cmd.Parameters.AddWithValue("@ProductId", MainItemId);
              cmd.Parameters.AddWithValue("@IngredientId", SubItemId);
              cmd.ExecuteNonQuery();
          }

          public void updatefoodcost(string foodcost, int MainItemId)
          {
              Opencon();
              cmd = new SqlCommand("Sp_Update_Item_foodcost", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@cost", foodcost);
              cmd.Parameters.AddWithValue("@productid", MainItemId);
              cmd.ExecuteNonQuery();
          }

          public void DelItemmapping(int Id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteIngredients", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Id);
              cmd.ExecuteNonQuery();
          }
          public DataTable PrintKot(string kotid)
          {
              Opencon();
              cmd = new SqlCommand("spPrintKot", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@kotid", kotid);
              
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable PrintKotdetails(string tableid)
          {
              Opencon();
              cmd = new SqlCommand("spPrintKOTDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@tid", tableid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          public DataTable PrintKotTake(string kotid)
          {
              Opencon();
              cmd = new SqlCommand("spPrintKotTake", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@kotid", kotid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable printpendingkot(string kotid)
          {
              
              Opencon();
              cmd = new SqlCommand("spprintpendingkot", con);
              cmd.CommandType=CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@kotid",kotid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
         
          public DataTable PrintBillCounter(string invoiceid)
          {
              Opencon();
              cmd = new SqlCommand("spPrintBillCounter", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable getbills()
          {
              Opencon();
              cmd = new SqlCommand("spgetbill", con);
              cmd.CommandType = CommandType.StoredProcedure;
             //cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable getbilldetails(string inid )
          {
              Opencon();
              cmd = new SqlCommand("spgetbillsdetail", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@inid", inid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;


          }
          public DataTable PrintBill(string invoiceid)
          {
              Opencon();
              cmd = new SqlCommand("spPrintBill", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable removeKOT(int itemid,int kotid)
          {
              Opencon();
              cmd = new SqlCommand("RemoveKOTItem", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@itemid", itemid);
              cmd.Parameters.AddWithValue("@kotid", kotid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable PrintBillTouch(string invoiceid)
          {
              Opencon();
              cmd = new SqlCommand("spPrintBillTouch", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public int TableACStat(string Id)
          {
              Opencon();
              cmd = new SqlCommand("spGetTableACStatus", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Id);
              return Convert.ToInt32(cmd.ExecuteScalar());
          }
          public DataTable GetItembyCategory(string CatId)
          {
              Opencon();
              cmd = new SqlCommand("spGetItemByCategory", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@CatId", CatId);
              DataTable ds = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }
          public DataTable getwaitername(string name)
          {
              Opencon();
              cmd = new SqlCommand("spwname", con);
              cmd.CommandType = CommandType.StoredProcedure;
              
              cmd.Parameters.AddWithValue("@Name", name);           
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable getname(string name)
          {
              Opencon();
              cmd = new SqlCommand("[spwaitername]", con);
              cmd.CommandType = CommandType.StoredProcedure;

              cmd.Parameters.AddWithValue("@Name", name);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable getnames(string  id)
          {
              Opencon();
              cmd = new SqlCommand("[spwaitersname]", con);
              cmd.CommandType = CommandType.StoredProcedure;

              cmd.Parameters.AddWithValue("@Id", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

        //Employee 18-12-13

          //integration employee 13-05-13
          public DataSet GetEmpMob()
          {
              Opencon();
              cmd = new SqlCommand("SpGetMobileNo", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);

              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }

          public DataTable GetEmpSearch(string emp, string desig, string country, string mob, string mode)
          {
              Opencon();
              cmd = new SqlCommand("SpGetEmpDetailsSearch", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Emp", emp);
              cmd.Parameters.AddWithValue("@designation", desig);
              cmd.Parameters.AddWithValue("@country", country);
              cmd.Parameters.AddWithValue("@Mob", mob);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public string insertemp(string empid,string empcode, string name,string remarks, DateTime dateofbirth, string nationality, string gender, string qualification,
             string empdesignation, DateTime joiningdate, string worknghrs, string mobile, string phone, string previousep, byte[] photo,string mode)
          {

              Opencon();
              if( (empid == "")||(empid==null))
              {
                   empid = "0";

              }
              if ((remarks == "") || (remarks == null))
              {
                  remarks = "gd";
              }
           if(dateofbirth.ToString() == "")
              {
      dateofbirth=DateTime.Now;
              }
              if(nationality==null)
              {
                nationality="indian";
              }
              if((gender=="")||(gender==null))
              {
                  gender="male";
              }
              if((qualification=="")||(qualification==null))
              {
                  qualification="sslc";
              }
              if((empdesignation=="")||(empdesignation==null))
              {
                  empdesignation="2";
              }
              if(joiningdate==null)
              {
                  joiningdate=DateTime.Now;
              }
              if((worknghrs=="")||(worknghrs==null))
              {
                  worknghrs="8";
              }
              if((mobile=="")||(mobile==null))
              {
                  mobile="9876543212";
              }
              if((phone=="")||(phone==null))
              {
                  phone="2788567";
              }
              if(previousep==null||previousep=="")
              {
                  previousep = "0";
              }
              if (photo == null)
              {
                  byte[] img = new byte[0];
                  photo = img;
              }
             
              
              cmd = new SqlCommand("spinsertemp", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@empid", empid);
              cmd.Parameters.AddWithValue("@empcode", empcode);
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
              cmd.Parameters.AddWithValue("@nationality", nationality);
              cmd.Parameters.AddWithValue("@gender", gender);
              cmd.Parameters.AddWithValue("@qualificaton", qualification);
              cmd.Parameters.AddWithValue("@designtion", empdesignation);
              cmd.Parameters.AddWithValue("@joiningdate", joiningdate);
              cmd.Parameters.AddWithValue("@workinghrs", worknghrs);
              cmd.Parameters.AddWithValue("@mobile", mobile);
              cmd.Parameters.AddWithValue("@phone", phone);
              cmd.Parameters.AddWithValue("@previousexp", previousep);
              cmd.Parameters.AddWithValue("@photo", photo);
              cmd.Parameters.AddWithValue("@mode", mode);
              //cmd.Parameters.AddWithValue("@id", id);

              
              return cmd.ExecuteScalar().ToString();
          }
          public string updatewaiteremp(string id,string empid, string empcode, string name,string remarks, DateTime dateofbirth, string nationality, string gender, string qualification,
                string empdesignation, DateTime joiningdate, string worknghrs, string mobile, string phone, string previousep, byte[] photo,string mode)
          {
              cmd = new SqlCommand("[spinsertemp]", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@empid", empid);
              cmd.Parameters.AddWithValue("@empcode", empcode);
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
              cmd.Parameters.AddWithValue("@nationality", nationality);
              cmd.Parameters.AddWithValue("@gender", gender);
              cmd.Parameters.AddWithValue("@qualificaton", qualification);
              cmd.Parameters.AddWithValue("@designtion", empdesignation);
              cmd.Parameters.AddWithValue("@joiningdate", joiningdate);
              cmd.Parameters.AddWithValue("@workinghrs", worknghrs);
              cmd.Parameters.AddWithValue("@mobile", mobile);
              cmd.Parameters.AddWithValue("@phone", phone);
              cmd.Parameters.AddWithValue("@previousexp", previousep);
              cmd.Parameters.AddWithValue("@photo", photo);
              cmd.Parameters.AddWithValue("@mode", mode);

              return cmd.ExecuteScalar().ToString();
          }

        
    
          public DataTable getworkindays()
          {
              Opencon();
              cmd = new SqlCommand("spgetWorkingdays", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable GETSTAFFNAME(int staffid)
          {
              Opencon();
              cmd = new SqlCommand("GETSTAFFNAME", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@SATFFID", staffid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          public void insertempholidy(string empid, string holiday, string hlidaystat)
          {
              Opencon();
              cmd = new SqlCommand("spInsertEmpHoliday", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@empid", empid);
              cmd.Parameters.AddWithValue("@holiday", holiday);
              cmd.Parameters.AddWithValue("@holidaystatus", hlidaystat);
              cmd.ExecuteNonQuery();


          }
          public DataSet Getempholidaystat()
          {
              Opencon();
              cmd = new SqlCommand("SpGetEmpHolStat", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }
          public DataSet GetempName()
          {
              Opencon();
              cmd = new SqlCommand("SpGetEmpname", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }
          public void InsertEmpDoccument(string empid, string document, byte[] Attachment, string reminder, DateTime expirydate, string reminderbefore)
          {
              Opencon();
              cmd = new SqlCommand("SpInsertEmpDoccument", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@empid", empid);
              cmd.Parameters.AddWithValue("@document", document);
              cmd.Parameters.AddWithValue("@Attachment", Attachment);
              cmd.Parameters.AddWithValue("@Reminder", reminder);
              cmd.Parameters.AddWithValue("@expirydate", expirydate);
              cmd.Parameters.AddWithValue("@ReminderBefore", reminderbefore);
              cmd.ExecuteNonQuery();


          }
          public void InsertempSal(string empid, string ba, string hra, string trans, string other, string total)
          {
              Opencon();
              cmd = new SqlCommand("SPInsertEmpSalary", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@empid", empid);
              cmd.Parameters.AddWithValue("@basicsal", ba);
              cmd.Parameters.AddWithValue("@hra", hra);
              cmd.Parameters.AddWithValue("@Transportation", trans);
              cmd.Parameters.AddWithValue("@other", other);
              cmd.Parameters.AddWithValue("@total", total);
              cmd.ExecuteNonQuery();
          }
          public SqlDataReader GetempDetails(string Id)
          {
              Opencon();
              cmd = new SqlCommand("spGetemployeedetail", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@emp", Id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }

          public SqlDataReader GetempSal(string Id)
          {
              Opencon(); 

              cmd = new SqlCommand("SPGetEmpSal", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@emp", Id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public string updateemp(string id, string empid, string empcode, string name, DateTime dateofbirth, string nationality, string gender, string qualification,
            string empdesignation, DateTime joiningdate, string worknghrs, string mobile, string phone, string previousep, byte[] photo)
          {
              Opencon();
              cmd = new SqlCommand("SpUpdateEmpDetail", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@empid", empid);
              cmd.Parameters.AddWithValue("@empcode", empcode);
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
              cmd.Parameters.AddWithValue("@nationality", nationality);
              cmd.Parameters.AddWithValue("@gender", gender);
              cmd.Parameters.AddWithValue("@qualificaton", qualification);
              cmd.Parameters.AddWithValue("@designtion", empdesignation);
              cmd.Parameters.AddWithValue("@joiningdate", joiningdate);
              cmd.Parameters.AddWithValue("@workinghrs", worknghrs);
              cmd.Parameters.AddWithValue("@mobile", mobile);
              cmd.Parameters.AddWithValue("@phone", phone);
              cmd.Parameters.AddWithValue("@previousexp", previousep);
              cmd.Parameters.AddWithValue("@photo", photo);
              return cmd.ExecuteScalar().ToString();
          }
          public void UpdateEmpSal(string empid, string ba, string hra, string trans, string other, string total)
          {
              Opencon();
              cmd = new SqlCommand("SpUpdateEmpSal", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@empid", empid);
              cmd.Parameters.AddWithValue("@basicsal", ba);
              cmd.Parameters.AddWithValue("@hra", hra);
              cmd.Parameters.AddWithValue("@Transportation", trans);
              cmd.Parameters.AddWithValue("@other", other);
              cmd.Parameters.AddWithValue("@total", total);
              cmd.ExecuteNonQuery();
          }
          public void UpdateEmpDoccument(string empid, string document, byte[] Attachment, string reminder, DateTime expirydate, string reminderbefore)
          {
              Opencon();
              cmd = new SqlCommand("SpUpdateEmpDoccument", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@empid", empid);
              cmd.Parameters.AddWithValue("@document", document);
              cmd.Parameters.AddWithValue("@Attachment", Attachment);
              cmd.Parameters.AddWithValue("@Reminder", reminder);
              cmd.Parameters.AddWithValue("@expirydate", expirydate);
              cmd.Parameters.AddWithValue("@ReminderBefore", reminderbefore);
              cmd.ExecuteNonQuery();


          }
          public DataTable getempHolidayStatusgv(string empid)
          {
              Opencon();
              cmd = new SqlCommand("spGeteHolidayst", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@emp", empid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public void UpdateHoliday(string emp, string holiday, string holidaystat)
          {
              Opencon();
              cmd = new SqlCommand("SpUpdateEmpHoliday", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@empid", emp);
              cmd.Parameters.AddWithValue("@holiday", holiday);
              cmd.Parameters.AddWithValue("@holidaystatus", holidaystat);
              cmd.ExecuteNonQuery();
          }
          public void DEleteEmp(string emp)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteEmpDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@emp", emp);
              cmd.ExecuteNonQuery();
          }
          public string GetEmpstatus()
          {
              Opencon();
              cmd = new SqlCommand("SpGetEmpStat", con);
              cmd.CommandType = CommandType.StoredProcedure;
              return cmd.ExecuteScalar().ToString();
          }
          public string CheckEmpCode(string EmpCode)
          {
              Opencon();
              cmd = new SqlCommand("Sp_CheckEmpCode", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@EmpCode", EmpCode);
              return cmd.ExecuteScalar().ToString();

          }
          public SqlDataReader Getempcode()
          {
              Opencon();
              cmd = new SqlCommand("SpGETEmpcode", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public DataTable GetempDoccument(string Id)
          {
              Opencon();
              cmd = new SqlCommand("SpGetEmpDocc", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@emp", Id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public void DelEmpDoccument(string id)
          {
              Opencon();
              cmd = new SqlCommand("SPDeleteEmpDoc", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@docc", id);
              cmd.ExecuteNonQuery();
          }
          public SqlDataReader GetempDoccId(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetEmpDoccid", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public DataSet GetCountry()
          {
              Opencon();
              cmd = new SqlCommand("SpGetCountry", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }

        //country
          public string SaveCountry(string country)
          {
              Opencon();
              cmd = new SqlCommand("spSaveCountry", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@country", country);
              return cmd.ExecuteScalar().ToString();
          }
          public string UpdateCountry(string country, string id)
          {
              Opencon();
              cmd = new SqlCommand("spUpdateCountry", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@country", country);
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public void DeleteCountry(string id)
          {
              Opencon();
              cmd = new SqlCommand("spDeleteCountry", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.ExecuteNonQuery();
          }
          public SqlDataReader GetCountryById(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetCountryNamebyId", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }

    /////////////////////

          public DataSet GetBank()
          {
              Opencon();
              cmd = new SqlCommand("SP_GET_BANKNAME", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }

          public int CheckInternetConnection()
          {
              //try
              //{
              //    Boolean Ans = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
              //    if (Ans == true)
              //    {
              //        return 1;
              //    }
              //    else
              //    {
              //        MessageBox.Show("No internet connection available, Please check your connection.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //        return 0;
              //    }
              //}
              //catch (Exception e)
              //{
              //    return 0;
              //}
              return 1;
          }
          public DataTable Edit_SwipeMaster(string SwipeId)
          {
              Opencon();
              cmd = new SqlCommand("Edit_SwipeMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@SwipeId", SwipeId);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }

          public int Delete_SwipeMachine(string id)
          {
              Opencon();
              cmd = new SqlCommand("Delete_SwipeMachine", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return Convert.ToInt32(cmd.ExecuteScalar());
          }
          public DataTable GetInvoicesTouch()
          {
              Opencon();
              cmd = new SqlCommand("SPGETINVOICES", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          public DataSet GetSwipeMachine()
          {
              Opencon();
              cmd = new SqlCommand("GetSwipeMachine", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }
          public string Save_Swiping_Machine(string SwipeId, string SwipeName, string BankId, string Remarks, int mode)
          {

              Opencon();
              cmd = new SqlCommand("Save_Swiping_Machine", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@SwipeId", SwipeId);
              cmd.Parameters.AddWithValue("@SwipeName", SwipeName);
              cmd.Parameters.AddWithValue("@BankId", BankId);
              cmd.Parameters.AddWithValue("@Remarks", Remarks);
              cmd.Parameters.AddWithValue("@mode", mode);
              return cmd.ExecuteScalar().ToString();
          }
          public string InsertBank(string bankname, string branch, string address, string email, string phno, string openingbal, string accno)
          {
              Opencon();
              cmd = new SqlCommand("SP_INSERT_BANK", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@bankname", bankname);
              cmd.Parameters.AddWithValue("@branch", branch);
              cmd.Parameters.AddWithValue("@address", address);
              cmd.Parameters.AddWithValue("@email", email);
              cmd.Parameters.AddWithValue("@phno", phno);
              cmd.Parameters.AddWithValue("@openingbal", openingbal);
              cmd.Parameters.AddWithValue("@Accno", accno);

              return cmd.ExecuteScalar().ToString();
          }
          public void SaveWindow(DateTime date, string name, string user, string transactions)
          {
              Opencon();
              cmd = new SqlCommand("SpSaveWindow", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@window", name);
              cmd.Parameters.AddWithValue("@user", user);
              cmd.Parameters.AddWithValue("@transaction", transactions);
              cmd.ExecuteNonQuery();
          }

          public string UpdateBank(string bankid, string bankname, string branch, string address, string email, string phno, string open, string accno)
          {
              Opencon();
              cmd = new SqlCommand("SP_UPDATE_BANK", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@bankid", bankid);
              cmd.Parameters.AddWithValue("@bankname", bankname);
              cmd.Parameters.AddWithValue("@branch", branch);
              cmd.Parameters.AddWithValue("@address", address);
              cmd.Parameters.AddWithValue("@email", email);
              cmd.Parameters.AddWithValue("@phno", phno);
              cmd.Parameters.AddWithValue("@openingbal", open);
              cmd.Parameters.AddWithValue("@Accno", accno);
              return cmd.ExecuteScalar().ToString();

          }
          public DataTable EditBank(string bankid)
          {
              Opencon();
              cmd = new SqlCommand("SP_EDIT_BANK", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@bankid", bankid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public int DeleteBank(string id)
          {
              Opencon();
              cmd = new SqlCommand("DelBank", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return Convert.ToInt32(cmd.ExecuteScalar());
          }
        //////////////////

          public DataSet LoadBankName()
          {
              Opencon();
              cmd = new SqlCommand("Sp_LoadBankName", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;

          }
          public DataTable SearchBankTrans(int bankid, DateTime StartDate, DateTime EndDate, string Type, int mode)
          {
              Opencon();
              cmd = new SqlCommand("Sp_SearchBankTrans", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Bank_Id", bankid);
              cmd.Parameters.AddWithValue("@Type", Type);
              cmd.Parameters.AddWithValue("@StartDate", StartDate);
              cmd.Parameters.AddWithValue("@EndDate", EndDate);
              cmd.Parameters.AddWithValue("@Mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          public string InsertBankTrans(int bankid, string Type, DateTime date, string description, string amount)
          {
              Opencon();
              cmd = new SqlCommand("Sp_InsertBankTrans", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Bank_Id", bankid);
              cmd.Parameters.AddWithValue("@Type", Type);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@Description", description);
              cmd.Parameters.AddWithValue("@Amount", amount);
              return cmd.ExecuteScalar().ToString();

          }

          public string UpdateBankTrans(int transid, int bankid, string Type, DateTime date, string description, string amount)
          {
              Opencon();
              cmd = new SqlCommand("Sp_UpdateBankTrans", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Trans_Id", transid);
              cmd.Parameters.AddWithValue("@Bank_Id", bankid);
              cmd.Parameters.AddWithValue("@Type", Type);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@Description", description);
              cmd.Parameters.AddWithValue("@Amount", amount);
              return cmd.ExecuteScalar().ToString();

          }
          public string DeleteBankTrans(int id)
          {

              Opencon();
              cmd = new SqlCommand("Sp_DeleteBankTrans", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("Trans_Id", id);
              return cmd.ExecuteScalar().ToString();

          }
          public string InsertIncomeExpenseType(string Type, string Name, string Description)
          {
              Opencon();
              cmd = new SqlCommand("spInsertIncomeExpenseType", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Type", Type);
              cmd.Parameters.AddWithValue("@Name", Name);
              cmd.Parameters.AddWithValue("@Description", Description);
              return cmd.ExecuteScalar().ToString();
          }
          public string DeleteIncomeExpense(string type)
          {
              Opencon();
              cmd = new SqlCommand("DelIncomeExpenseType", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@type", type);
              return cmd.ExecuteScalar().ToString();
          }

          public DataTable SelectIncomeExpenseType(string Type)
          {
              Opencon();
              cmd = new SqlCommand("spSelectIncomeExpenseType", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Type", Type);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public string UpdateIncomeExpenseType(string Id, string Type, string Name, string Description)
          {
              Opencon();
              cmd = new SqlCommand("spUpdateIncomeExpenseType", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Id);
              cmd.Parameters.AddWithValue("@Type", Type);
              cmd.Parameters.AddWithValue("@Name", Name);
              cmd.Parameters.AddWithValue("@Description", Description);
              return cmd.ExecuteScalar().ToString();
          }
          public DataTable GetIncomeExpenseTypeDetails(string Id)
          {
              Opencon();
              cmd = new SqlCommand("spGetIncomeExpenseTypeDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          // Get recievable amount  of customer
          public DataTable GetCustrecievableamount(int CustId)
          {
              Opencon();
              
              cmd = new SqlCommand("getcustomerrecievable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@CustomerId", SqlDbType.Int).Value = CustId;
              SqlDataAdapter da = new SqlDataAdapter();
              da.SelectCommand = cmd;
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          //*****************************************************
          // Get Details of customer
          public DataTable GetCustDetailsBilling(string CustId)
          {
              Opencon();
              cmd = new SqlCommand("GetCustDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@CustId", CustId);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          //*****************************************************
          public DataSet GetCustomer()
          {
              Opencon();
              cmd = new SqlCommand("SP_GetCustomer", con);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }

          public string GetCustSt()
          {
              Opencon();
              cmd = new SqlCommand("SpGetCustomerStat", con);
              cmd.CommandType = CommandType.StoredProcedure;
              return cmd.ExecuteScalar().ToString();
          }

          public SqlDataReader GetCustCodeAuto()
          {
              Opencon();
              cmd = new SqlCommand("SP_GETCutCodeSt", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public string InsertCustomer(string customername, string adress, string phone, string email, string tinno, string cstno, string openingbalance, string custid, string mode, string Credit, string code, string CreditAmount)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_CUSTOMER", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@customername", customername);
              cmd.Parameters.AddWithValue("@adress", adress);
              cmd.Parameters.AddWithValue("@phone", phone);
              cmd.Parameters.AddWithValue("@email", email);
              cmd.Parameters.AddWithValue("@tinno", tinno);
              cmd.Parameters.AddWithValue("@cstno", cstno);
              cmd.Parameters.AddWithValue("@openingbalance", openingbalance);
              cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@Credit", Credit);
              cmd.Parameters.AddWithValue("@code", code);
              cmd.Parameters.AddWithValue("@CreditAmount", CreditAmount);
              return cmd.ExecuteScalar().ToString();
          }


          public int DeleteCustomer(string id)
          {
              Opencon();
              cmd = new SqlCommand("sp_Del_Customer", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return Convert.ToInt32(cmd.ExecuteScalar().ToString());
          }
          public DataTable CustomerSearchSeparate(string name, string mode)
          {
              Opencon();
              cmd = new SqlCommand("SpGetCustDetailsSeparate", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }

          public DataTable CustomerSearch(string phn)
          {
              Opencon();
              cmd = new SqlCommand("SpGetCustDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              //cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@mob", phn);
              //cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public DataTable EditCustomer(string cust_id)
          {
              Opencon();
              cmd = new SqlCommand("sp_EditCustomer", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@customer_id", cust_id);
              DataTable dt = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(dt);
              return dt;

          }
          public string GetDealSt()
          {
              Opencon();
              cmd = new SqlCommand("SpGetDealerStat", con);
              cmd.CommandType = CommandType.StoredProcedure;
              return cmd.ExecuteScalar().ToString();

          }

          public SqlDataReader GetDealCodeAuto()
          {
              Opencon();
              cmd = new SqlCommand("SP_GETDealerCodeSt", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataReader dr = cmd.ExecuteReader();
              return dr;
          }
          public DataSet GetDealer()
          {
              Opencon();
              cmd = new SqlCommand("SP_GET_DEALER", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }
          public string InsertDealer(string dealername, string adress, string phone, string email, string fax, string tinno, string cstno, string openingbalance, string dealerid, string mode, string code, string credit)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_DEALER", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@dealername", dealername);
              cmd.Parameters.AddWithValue("@adress", adress);
              cmd.Parameters.AddWithValue("@phone", phone);
              cmd.Parameters.AddWithValue("@email", email);
              cmd.Parameters.AddWithValue("@fax", fax);
              cmd.Parameters.AddWithValue("@tinno", tinno);
              cmd.Parameters.AddWithValue("@cstno", cstno);
              cmd.Parameters.AddWithValue("@openingbalance", openingbalance);
              cmd.Parameters.AddWithValue("@dealerid", dealerid);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@code", code);
              cmd.Parameters.AddWithValue("@credit", credit);
              return cmd.ExecuteScalar().ToString();
          }
          public DataTable selectdealer(string dealerid)
          {
              Opencon();
              cmd = new SqlCommand("SP_SELECT_DEALER", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@dealer_id", dealerid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              ad.Fill(dt);
              return dt;
          }
          public int DeleteDealer(string id)
          {
              Opencon();
              cmd = new SqlCommand("sp_Del_Dealer", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return Convert.ToInt32(cmd.ExecuteScalar());
          }

          public DataTable DealerSearch(string phn, string name, string mode)
          {
              Opencon();
              cmd = new SqlCommand("SpDealerSearch", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@name", name);
              cmd.Parameters.AddWithValue("@mob", phn);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public string GetCustBalance(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetCustBalance", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id",id);
              return cmd.ExecuteScalar().ToString();

          }
          public void InsertComplimentary(string invid,string remrks)
          {
              Opencon();
              cmd = new SqlCommand("SpInsertComplimentary", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invid", invid);
              cmd.Parameters.AddWithValue("@complementary", remrks);
              cmd.ExecuteNonQuery();
          }
          public DataTable SearchOldPayReceive(int status, int custordealerid, string custoddealername, DateTime startdate, DateTime enddate, int mode)
          {
              Opencon();
              cmd = new SqlCommand("Sp_searchOldPayReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Status", status);
              cmd.Parameters.AddWithValue("@CustOrDealerId", custordealerid);
              cmd.Parameters.AddWithValue("@CustorDealerName", custoddealername);
              cmd.Parameters.AddWithValue("@StartDate", startdate);
              cmd.Parameters.AddWithValue("@EndDate", enddate);
              cmd.Parameters.AddWithValue("@Mode", mode);
              DataTable dt = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(dt);
              return dt;
          }
          public string InsertupdateOldPayReceive(int id, int status, int refid, string refno, DateTime refdate, string amount, string paidamount, string balance, int mode)
          {

              Opencon();
              cmd = new SqlCommand("Sp_InsertOldPayReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@Status", status);
              cmd.Parameters.AddWithValue("@CustDealerId", refid);
              cmd.Parameters.AddWithValue("@RefNo", refno);
              cmd.Parameters.AddWithValue("@refdate", refdate);
              cmd.Parameters.AddWithValue("@Amount", amount);
              cmd.Parameters.AddWithValue("@PaidAmount", paidamount);
              cmd.Parameters.AddWithValue("@Balance", balance);
              cmd.Parameters.AddWithValue("@mode", mode);
              return cmd.ExecuteScalar().ToString();

          }

          public string DeleteOldPayReceive(int id)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteOldPayReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", id);
              return cmd.ExecuteScalar().ToString();

          }

        ////////////////////////////////////////////////////////////////////////


          public string InsertStockEntryMaster(string customer, string total, string paideamount, string discount, string remarks, DateTime date, string tinno, string dealerref, string purchaser, string purchasetype, string mode,string id,string payable)
          {
              Opencon();
              cmd = new SqlCommand("SP_INSERT_STOCK_MASTER", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@customerid", customer);
              cmd.Parameters.AddWithValue("@total", total);
              cmd.Parameters.AddWithValue("@paidedamount", paideamount);
              cmd.Parameters.AddWithValue("@discount", discount);
              cmd.Parameters.AddWithValue("@remarks", remarks);
              cmd.Parameters.AddWithValue("@tinno", tinno);
              cmd.Parameters.AddWithValue("@date", date);
              cmd.Parameters.AddWithValue("@dealerreff", dealerref);
              cmd.Parameters.AddWithValue("@purchaser", purchaser);
              cmd.Parameters.AddWithValue("@purchasetype", purchasetype);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@payable",payable);
              return cmd.ExecuteScalar().ToString();
          }
          public string  InsertProductStockMaster(DateTime Date, string UserId, string mode,string Id)
          {
              Opencon();
              cmd = new SqlCommand("SP_SaveProductStock", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Date", Date);
              cmd.Parameters.AddWithValue("@UserId", UserId);
              
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@Id", Id);
              return cmd.ExecuteScalar().ToString();
          }
          public string InsertProductDamageMaster(DateTime Date, string UserId, string mode, string Id)
          {
              Opencon();
              cmd = new SqlCommand("SP_SaveProductDamage", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Date", Date);
              cmd.Parameters.AddWithValue("@UserId", UserId);

              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@Id", Id);
              return cmd.ExecuteScalar().ToString();
          }
          public void InsertProductDamageDetails(string PdtDamage_ID, string Item_Id, string Quantity, string Remarks, string mode, string sid)
          {
              Opencon();
              cmd = new SqlCommand("SP_SaveProductDamageDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@ProductDamage_ID", PdtDamage_ID);
              cmd.Parameters.AddWithValue("@Item_ID", Item_Id);
              cmd.Parameters.AddWithValue("@Quantity", Quantity);
              cmd.Parameters.AddWithValue("@Remarks", Remarks);

              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@Sid", sid);
              cmd.ExecuteNonQuery();
          }

        
          public void InsertProductStockDetails(string PdtStock_ID, string Item_Id, string Quantity, string Remarks, string mode, string sid)
          {
              Opencon();
              cmd = new SqlCommand("SP_SaveProductStockDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@ProductStock_ID", PdtStock_ID);
              cmd.Parameters.AddWithValue("@Item_ID", Item_Id);
              cmd.Parameters.AddWithValue("@Quantity", Quantity);
              cmd.Parameters.AddWithValue("@Remarks", Remarks);

              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@Sid", sid);
              cmd.ExecuteNonQuery();
          }
          public DataTable GetStockMasterDetails(string id)
          {
              Opencon();
              cmd = new SqlCommand("spGetStockMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@sid", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable GetProductStockMaster(string id)
          {
              Opencon();
              cmd = new SqlCommand("SP_GetProductStockMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@sid", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable GetProductDamageMaster(string id)
          {
              Opencon();
              cmd = new SqlCommand("SP_GetProductDamageMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@sid", id);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public void InsertStockEntry(int type, string id, string qty, string cost, string total, string stockid, string description, string mode, string sid)
          {
              Opencon();
              cmd = new SqlCommand("spInsertStockEntry", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@type", type);
              cmd.Parameters.AddWithValue("@id", id);
              cmd.Parameters.AddWithValue("@qty", qty);
              cmd.Parameters.AddWithValue("@cost", cost);
              cmd.Parameters.AddWithValue("@total", total);
              cmd.Parameters.AddWithValue("@stockid", stockid);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@mode", mode);
              cmd.Parameters.AddWithValue("@sid", sid);
              cmd.ExecuteNonQuery();
          }
          public DataSet GetItemCodeForStock(string type)
          {
              Opencon();
              cmd = new SqlCommand("spGetItemCodeforStock", con);
              cmd.Parameters.AddWithValue("@type", type);
              cmd.CommandType = CommandType.StoredProcedure;
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(ds);
              return ds;
          }
          public DataSet GetPurchaser()
          {
              Opencon();
              cmd = new SqlCommand("spGetPurchaser", con);
              cmd.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }
          public DataTable SearchStockOld(string mode, string start, string end)
          {
              Opencon();
              cmd = new SqlCommand("spSearchStockOld", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@startdate", start);
              cmd.Parameters.AddWithValue("@enddate", end);
              cmd.Parameters.AddWithValue("@mode", mode);             
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable SearchProductStockOld(string mode, string start, string end)
          {
              Opencon();
              cmd = new SqlCommand("SP_SearchProductStockOld", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@startdate", start);
              cmd.Parameters.AddWithValue("@enddate", end);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable SearchDamageEntry(string mode, string start, string end)
          {
              Opencon();
              cmd = new SqlCommand("SP_SearchDamageEntry", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@startdate", start);
              cmd.Parameters.AddWithValue("@enddate", end);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public string GetVoucherNopayment()
          {
              Opencon();
              cmd = new SqlCommand("spGetVoucherNopayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              return cmd.ExecuteScalar().ToString();
          }
          public string GetVoucherNopaymentOld()
          {
              Opencon();
              cmd = new SqlCommand("spGetVoucherNoPaymentOld", con);
              cmd.CommandType = CommandType.StoredProcedure;

              return cmd.ExecuteScalar().ToString();
          }
          public DataSet SelectInvoiceNopayment(string dealid)
          {
              Opencon();
              cmd = new SqlCommand("spGetInvoiceforRecieptpayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@dealid", dealid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              ad.Fill(ds);
              return ds;
          }

          public DataSet SelectInvoiceNopaymentOldPay(string dealid)
          {
              Opencon();
              cmd = new SqlCommand("spGetInvoiceforPaymentOldPay", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@dealid", dealid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              ad.Fill(ds);
              return ds;
          }
          public DataSet Getbalanceinvoicenopayment(string invid)
          {
              Opencon();
              cmd = new SqlCommand("spGetbalanceinvoicenopayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@invid", invid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              ad.Fill(ds);
              return ds;
          }
          public DataSet GetbalanceInvoiceNoPaymentOldPay(string invid)
          {
              Opencon();
              cmd = new SqlCommand("spGetBalanceInvoiceNoPaymentOldPay", con);
              cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@invid", invid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              ad.Fill(ds);
              return ds;
          }
          public string deletepayment(string rid)
          {
              Opencon();
              cmd = new SqlCommand("spdeletepayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              return cmd.ExecuteScalar().ToString();
          }
          public void DeleteDealerAccDetailsByPV(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteDealerAccDetailsByPV", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@r_id", Rid);
              cmd.ExecuteNonQuery();

          }
          public void DeleteCheckDetailsByPV(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteCheckDetailsByPV", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Rid);
              cmd.ExecuteNonQuery();

          }
          public string InsertpaymentVoucher(DateTime voucherdate, string voucherno, string paymentperson, string customerid, string othername, string amount, string description, string paymode, int status)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_PAYMENTVOUCHER1", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@voucherdate", voucherdate);
              cmd.Parameters.AddWithValue("@voucherno", voucherno);
              cmd.Parameters.AddWithValue("@paymentperson", paymentperson);
              cmd.Parameters.AddWithValue("@customerid", customerid);
              cmd.Parameters.AddWithValue("@othername", othername);
              cmd.Parameters.AddWithValue("@amount", amount);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@paymode", paymode);
              cmd.Parameters.AddWithValue("@Status", status);

              return cmd.ExecuteScalar().ToString();
          }
          public void InsertChequeDetails(string invoiceid, string invoiceType, string chequeno, DateTime chequedate, string bank, string amount, string status)
          {
              Opencon();
              cmd = new SqlCommand("SP_INSERT_CHEQUEdETAILS", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              cmd.Parameters.AddWithValue("@invoiceType", invoiceType);
              cmd.Parameters.AddWithValue("@chequeno", chequeno);
              cmd.Parameters.AddWithValue("@chequedate", chequedate);
              cmd.Parameters.AddWithValue("@bank", bank);
              cmd.Parameters.AddWithValue("@amount", amount);
              cmd.Parameters.AddWithValue("@status", status);
              cmd.ExecuteNonQuery();
          }
          public void InsertDealerAccountDetails(string DealerId, DateTime Date, string Amount, string Status, string RecieptType, string RecieptNo, string msg)
          {
              Opencon();
              cmd = new SqlCommand("spInsertDealerAccountDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@DealerId", DealerId);
              cmd.Parameters.AddWithValue("@Date", Date);
              cmd.Parameters.AddWithValue("@Amount", Amount);
              cmd.Parameters.AddWithValue("@Status", Status);
              cmd.Parameters.AddWithValue("@RecieptType", RecieptType);
              cmd.Parameters.AddWithValue("@RecieptNo", RecieptNo);
              cmd.Parameters.AddWithValue("@msg", msg);
              cmd.ExecuteNonQuery();
          }
          public string selectidpayment()
          {
              Opencon();
              cmd = new SqlCommand("sp_GetIdpayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              return cmd.ExecuteScalar().ToString();
          }
          public string InsertpaymentVoucherDetails(string rid, string invoiceid, string customerid, string description, string amount)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_PAYMENTVOUCHERDETAILS", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              cmd.Parameters.AddWithValue("@customerid", customerid);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@amount", amount);
              return cmd.ExecuteScalar().ToString();
          }
          public string DeletePaymentOldPay(string rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeletePaymentOldPayable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              return cmd.ExecuteScalar().ToString();
          }
          public void DeleteDealerAccDetailsByPVOldPay(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteDealerAccDetailsByPVOldPay", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@r_id", Rid);
              cmd.ExecuteNonQuery();
          }
          public void DeleteCheckDetailsByPVOldPay(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteCheckDetailsByPVOldPay", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Rid);
              cmd.ExecuteNonQuery();
          }
          public string InsertpaymentVoucherOldPayable(DateTime voucherdate, string voucherno, string paymentperson, string customerid, string othername, string amount, string description, string paymode, int status)
          {
              Opencon();
              cmd = new SqlCommand("Sp_SavePaymentVoucherOldPayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@voucherdate", voucherdate);
              cmd.Parameters.AddWithValue("@voucherno", voucherno);
              cmd.Parameters.AddWithValue("@paymentperson", paymentperson);
              cmd.Parameters.AddWithValue("@customerid", customerid);
              cmd.Parameters.AddWithValue("@othername", othername);
              cmd.Parameters.AddWithValue("@amount", amount);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@paymode", paymode);
              cmd.Parameters.AddWithValue("@Status", status);
              return cmd.ExecuteScalar().ToString();
          }
          public string InsertpaymentVoucherDetailsOldPayment(string rid, string invoiceid, string customerid, string description, string amount)
          {
              Opencon();
              cmd = new SqlCommand("Sp_SavePaymentVoucherDetailsOldPayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              cmd.Parameters.AddWithValue("@customerid", customerid);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@amount", amount);
              return cmd.ExecuteScalar().ToString();
          }
          public DataTable GetPaymentVoucherMaster(int Rid)
          {
              Opencon();
              SqlCommand cmd = new SqlCommand("Sp_GetPaymentVoucherMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@pid", Rid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable getReceiptDetailspayment(string rid)
          {
              Opencon();
              cmd = new SqlCommand("spgetReceiptDetailspayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@rid", rid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              ad.Fill(dt);
              return dt;

          }
          public DataTable GetCheckForPaymentVoucher(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_GetCheckForPaymentVoucher", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@InvoiceId", Rid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public DataTable GetPaymentVoucherMasterOldPay(int Rid)
          {
              Opencon();
              SqlCommand cmd = new SqlCommand("Sp_GetPaymentVoucherMasterOldPay", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@pid", Rid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable GetReceiptDetailsPaymentOldPay(string rid)
          {
              Opencon();
              cmd = new SqlCommand("SpGetReceiptDetailsPaymentOldPay", con);
              cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@rid", rid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              ad.Fill(dt);
              return dt;
          }
          public DataTable GetCheckForPaymentVoucherOldPay(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_GetCheckForPaymentVoucherOldPay", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@InvoiceId", Rid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public DataTable getreceiptdetailsforeditpayment(string dealerid, string vno, DateTime fromdate, DateTime todate, string mode)
          {
              Opencon();
              cmd = new SqlCommand("spgetreceiptdetailsforeditpayment", con);
              cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@dealerid", dealerid);
              cmd.Parameters.AddWithValue("@vno", vno);
              cmd.Parameters.AddWithValue("@fromdate", fromdate);
              cmd.Parameters.AddWithValue("@todate", todate);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable ds = new DataTable();
              ad.Fill(ds);
              return ds;

          }
          public DataTable GetReceiptDetailsForEditPaymentOldPay(string dealerid, string vno, DateTime fromdate, DateTime todate, string mode)
          {
              Opencon();
              cmd = new SqlCommand("spGetPaymentOldPayDetailsForEdit", con);
              cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@dealerid", dealerid);
              cmd.Parameters.AddWithValue("@vno", vno);
              cmd.Parameters.AddWithValue("@fromdate", fromdate);
              cmd.Parameters.AddWithValue("@todate", todate);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable ds = new DataTable();
              ad.Fill(ds);
              return ds;
          }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////


          public string GetVoucherNo()
          {
              Opencon();
              cmd = new SqlCommand("spGetVoucherNo", con);
              cmd.CommandType = CommandType.StoredProcedure;
              return cmd.ExecuteScalar().ToString();
          }
          //public string GetVoucherNoMaintanance()
          //{
          //    Opencon();
          //    cmd = new SqlCommand("spGetVoucherNoMaintanance", con);
          //    cmd.CommandType = CommandType.StoredProcedure;
          //    return cmd.ExecuteScalar().ToString();
          //}
          public string GetVoucherNoOldPayReceive()
          {
              Opencon();
              cmd = new SqlCommand("SpGetVoucherNoOldPayReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;

              return cmd.ExecuteScalar().ToString();
          }
          public DataSet SelectInvoiceNo(int custid)
          {
              Opencon();
              cmd = new SqlCommand("spGetInvoiceforReciept", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@custid", custid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              ad.Fill(ds);
              return ds;

          }
          public DataSet SelectInvoiceNoOldPayReceive(int custid)
          {
              Opencon();
              cmd = new SqlCommand("spGetInvoiceforRecieptOldPayReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@custid", custid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              ad.Fill(ds);
              return ds;

          }
          public DataSet Getbalanceinvoiceno(int invid)
          {
              Opencon();
              cmd = new SqlCommand("spGetbalanceinvoiceno", con);
              cmd.CommandType = CommandType.StoredProcedure;             
              cmd.Parameters.AddWithValue("@invid", invid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              ad.Fill(ds);
              return ds;

          }

          public DataSet GetbalanceOldPayReceiveNoCustomer(int MainID)
          {
              Opencon();
              cmd = new SqlCommand("spGetbalanceOldPayReceiveNoCustomer", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@OldPayReceiveID", MainID);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              return ds;
          }

          public DataTable GetReceiptMaster(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_GetReceiptVoucherMaster", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@r_id", Rid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }
          public DataTable getReceiptDetails(string rid)
          {
              Opencon();
              cmd = new SqlCommand("spgetReceiptDetails", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              ad.Fill(dt);
              return dt;

          }
          public DataTable GetCheckForReceiptVoucher(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_GetCheckForReceiptVoucher", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@InvoiceId", Rid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }
          public DataTable GetReceiptVoucherMasterOldReceive(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_GetReceiptVoucherMasterOldReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@r_id", Rid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          public DataTable GetReceiptDetailsOldReceive(string rid)
          {
              Opencon();
              cmd = new SqlCommand("SpGetReceiptDetailsOldReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              ad.Fill(dt);
              return dt;
          }
          public DataTable GetCheckForReceiptVoucherOldReceive(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_GetCheckForReceiptVoucherOldReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@InvoiceId", Rid);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;

          }

          public string deletereceipt(string rid)
          {
              Opencon();
              cmd = new SqlCommand("spdeleteReceipt", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              return cmd.ExecuteScalar().ToString();

          }

          public void DeleteUserAccDetailsByRV(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteUserAccDetailsByRV", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@r_id", Rid);
              cmd.ExecuteNonQuery();

          }

          public void DeleteCheckDetailsByRV(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteCheckDetailsByRV", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Rid);
              cmd.ExecuteNonQuery();

          }

          public string InsertReceiptVoucher(DateTime voucherdate, string voucherno, string paymentperson, string customerid, string othername, string amount, string description, string paymode, int status)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_RECEIPTVOUCHER1", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@voucherdate", voucherdate);
              cmd.Parameters.AddWithValue("@voucherno", voucherno);
              cmd.Parameters.AddWithValue("@paymentperson", paymentperson);
              cmd.Parameters.AddWithValue("@customerid", customerid);
              cmd.Parameters.AddWithValue("@othername", othername);
              cmd.Parameters.AddWithValue("@amount", amount);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@paymode", paymode);
              cmd.Parameters.AddWithValue("@Status", status);            
              return cmd.ExecuteScalar().ToString();
          }

          public void InsertCustAccountDetails(string CustId, DateTime Date, string Amount, string Status, string RecieptType, string RecieptNo, string msg)
          {
              //try
              //{
                  Opencon();
                  cmd = new SqlCommand("spInsertCustAccountDetails", con);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.Parameters.AddWithValue("@CustId", SqlDbType.BigInt).Value = CustId;
                  cmd.Parameters.AddWithValue("@Date", Date);
                  cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(Amount));
                  cmd.Parameters.AddWithValue("@Status", Convert.ToInt32(Status));
                  cmd.Parameters.AddWithValue("@RecieptType", Convert.ToInt32(RecieptType));
                  cmd.Parameters.AddWithValue("@RecieptNo", RecieptNo);
                  cmd.Parameters.AddWithValue("@msg", msg);
                  int l = cmd.ExecuteNonQuery();
              //}
              //catch (Exception ex)
              //{
              //}
          }

          public string selectid()
          {
              Opencon();
              cmd = new SqlCommand("sp_GetId", con);
              cmd.CommandType = CommandType.StoredProcedure;
              return cmd.ExecuteScalar().ToString(); 
          }
        ////

          public string InsertReceiptVoucherDetails(string rid, string invoiceid, string customerid, string description, string amount)
          {
              Opencon();
              cmd = new SqlCommand("SP_SAVE_RECEIPTVOUCHERDETAILS", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              cmd.Parameters.AddWithValue("@customerid", customerid);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@amount", amount);
              return cmd.ExecuteScalar().ToString();
          }

          //public string InsertReceiptVoucherOldReceivable(DateTime voucherdate, string voucherno, string paymentperson, string customerid, string othername, string amount, string description, string paymode, int status)
          //{
          //    Opencon();
          //    cmd = new SqlCommand("SpSavedReceiptVoucherOldPayReceive", con);
          //    cmd.CommandType = CommandType.StoredProcedure;
          //    cmd.Parameters.AddWithValue("@voucherdate", voucherdate);
          //    cmd.Parameters.AddWithValue("@voucherno", voucherno);
          //    cmd.Parameters.AddWithValue("@paymentperson", paymentperson);
          //    cmd.Parameters.AddWithValue("@customerid", customerid);
          //    cmd.Parameters.AddWithValue("@othername", othername);
          //    cmd.Parameters.AddWithValue("@amount", amount);
          //    cmd.Parameters.AddWithValue("@description", description);
          //    cmd.Parameters.AddWithValue("@paymode", paymode);
          //    cmd.Parameters.AddWithValue("@Status", status);
          //    return cmd.ExecuteScalar().ToString();
          //}

          public string InsertReceiptVoucherDetailsOldPayReceive(string rid, string invoiceid, string customerid, string description, string amount, int PayerStatus)
          {
              Opencon();
              cmd = new SqlCommand("SpSaveReceiptDetailsOldPayReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              cmd.Parameters.AddWithValue("@customerid", customerid);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@amount", amount);
              cmd.Parameters.AddWithValue("@PayerStatus", PayerStatus);
              return cmd.ExecuteScalar().ToString();
          }

          public string DeleteReceiptOldReceive(string rid)
          {
              Opencon();
              cmd = new SqlCommand("SpDeleteReceiptOldReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@rid", rid);
              return cmd.ExecuteScalar().ToString();
          }

          public void DeleteUserAccDetailsByRVOldReceivable(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteDealerAccDetailsByRVOldReceivable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@r_id", Rid);
              cmd.ExecuteNonQuery();

          }

          public void DeleteCheckDetailsByRVOldReceivable(int Rid)
          {
              Opencon();
              cmd = new SqlCommand("Sp_DeleteCheckDetailsByRVOldReceivable", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Rid);
              cmd.ExecuteNonQuery();

          }

          public string InsertReceiptVoucherOldReceivable(DateTime voucherdate, string voucherno, string paymentperson, string customerid, string othername, string amount, string description, string paymode, int status)
          {
              Opencon();
              cmd = new SqlCommand("SpSavedReceiptVoucherOldPayReceive", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@voucherdate", voucherdate);
              cmd.Parameters.AddWithValue("@voucherno", voucherno);
              cmd.Parameters.AddWithValue("@paymentperson", paymentperson);
              cmd.Parameters.AddWithValue("@customerid", customerid);
              cmd.Parameters.AddWithValue("@othername", othername);
              cmd.Parameters.AddWithValue("@amount", amount);
              cmd.Parameters.AddWithValue("@description", description);
              cmd.Parameters.AddWithValue("@paymode", paymode);
              cmd.Parameters.AddWithValue("@Status", status);
              return cmd.ExecuteScalar().ToString();
          }


          public DataTable getreceiptdetailsforedit(string custid, string vno, DateTime fromdate, DateTime todate, string mode)
          {
              Opencon();
              cmd = new SqlCommand("spgetreceiptdetailsforedit", con);
              cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@vno", vno);
              cmd.Parameters.AddWithValue("@fromdate", fromdate);
              cmd.Parameters.AddWithValue("@todate", todate);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable ds = new DataTable();
              ad.Fill(ds);
              return ds;

          }
          public DataTable GetReceiptOldReceiveDetailsForEdit(string custid, string vno, DateTime fromdate, DateTime todate, string mode)
          {
              Opencon();
              cmd = new SqlCommand("SpGetReceiptOldReceiveDetailsForEdit", con);
              cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@custid", custid);
              cmd.Parameters.AddWithValue("@vno", vno);
              cmd.Parameters.AddWithValue("@fromdate", fromdate);
              cmd.Parameters.AddWithValue("@todate", todate);
              cmd.Parameters.AddWithValue("@mode", mode);
              SqlDataAdapter ad = new SqlDataAdapter(cmd);
              DataTable ds = new DataTable();
              ad.Fill(ds);
              return ds;
          }
          public void InsertPaymode(string paymode, string invoiceid, string chequeno, string bank, DateTime chequedate, string realized, string card)
          {
              Opencon();
              cmd = new SqlCommand("spInsertPaymode", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@paymode", paymode);
              cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
              cmd.Parameters.AddWithValue("@chequeno", chequeno);
              cmd.Parameters.AddWithValue("@bank", bank);
              cmd.Parameters.AddWithValue("@chequedate", chequedate);
              cmd.Parameters.AddWithValue("@realized", realized);
              cmd.Parameters.AddWithValue("@cardno", card);
              cmd.ExecuteNonQuery();
          }
          public void UpdateIngradientQty(string inv)
          {
              Opencon();
              cmd=new SqlCommand("spGetIngraduentQty",con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@invoice",inv);
              cmd.ExecuteNonQuery(); 
          }
          public void InsertDayClosing(string denomination,string number,string total)
          {
              Opencon();
              cmd = new SqlCommand("spSaveDayclosing", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Denomination", denomination);
              cmd.Parameters.AddWithValue("@number", number);
              cmd.Parameters.AddWithValue("@total", total);
              cmd.ExecuteNonQuery();
          }

          public DataTable GetDayClosing(DateTime date1)
          {
              Opencon();
              cmd = new SqlCommand("SpGetDayClosing", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@date", date1);
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              return dt;
          }

          public string GetUsernameById(string id)
          {
              Opencon();
              cmd = new SqlCommand("SP_GETUSERNAMEBYID", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id", id);
              return cmd.ExecuteScalar().ToString();
          }
          public void SaveDeletePass(string pass)
          {
              Opencon();
              cmd = new SqlCommand("spSaveDeletePass", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@pass", pass);
              cmd.ExecuteNonQuery();
          }
          public string GetDeletePass()
          {
              Opencon();
              cmd = new SqlCommand("spGetDeletePass", con);
              cmd.CommandType = CommandType.StoredProcedure;              
              return cmd.ExecuteScalar().ToString();
          }

    }
}
