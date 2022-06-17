using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BisCarePosEdition
{
    class billingclass
    {
        public static double netamount = 0;
        public static int paymode = 0;
        public static double cashamt = 0;
        public static double cardamt = 0;
        public static double paidamt = 0;
        public static double payableamt = 0;
        public static double setnetamount
        {
            get { return netamount; }
            set { netamount = value; }
        }
        public static int setpaymode
        {
            get { return paymode; }
            set { paymode = value; }
        }
        public static double setcashamt
        {
            get { return cashamt; }
            set { cashamt = value; }
        }
        public static double setcardamt
        {
            get { return cardamt; }
            set { cardamt = value; }
        }
        public static double setpaidamt
        {
            get { return paidamt; }
            set { paidamt = value; }
        }
        public static double setpayableamt
        {
            get { return payableamt; }
            set { payableamt = value; }
        }
    }
}
