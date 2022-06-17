using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BisCarePosEdition
{
    class globalvariable
    {
        public static int formstatus = 0;
        public static int productid = 0;
        public static int status = 0;
        public static string userid = string.Empty;
        public static string username = string.Empty;
        public static string designation = string.Empty;
        public static string StoreDate = string.Empty;
        public static string StoreStatus = string.Empty;
        public static string Dummy = string.Empty;
        public static string setuserid
        {
            get { return userid; }
            set { userid = value; }
        }
        public static string setusername
        {
            get { return username; }
            set { username = value; }
        }
        public static string setdesignation
        {
            get { return designation; }
            set { designation = value; }
        }
        public static string setStoreDate
        {
            get { return StoreDate; }
            set { StoreDate = value; }
        }
        public static string setStoreStatus
        {
            get { return StoreStatus; }
            set { StoreStatus = value; }
        }
        public static string setDummy
        {
            get { return Dummy; }
            set { Dummy = value; }
        }
    }   
}
