using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount_s;
        private bool discount_c;
        private decimal amountDue_s;
        private decimal amountDue_c;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscount_s = 5.0m; // standard discount
        const decimal mdecDiscount_c = 10.0m; // child discount

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount_s
        {
            get { return discount_s; }
            set { discount_s = value; }
        }

        private bool Discount_c
        {
            get { return discount_s; }
            set { discount_s = value; }
        }

        public decimal AmountDue_s
        {
            get { return amountDue_s; }
            set { amountDue_s = value; }
        }

        public decimal AmountDue_c
        {
            get { return amountDue_c; }
            set { amountDue_c = value; }
        }

        // Constructor for TcicketPrice
        public TicketPrice(int section, int quantity, bool discount_s, bool discount_c)
    {
        Section = section;
        Quantity = quantity;
        Discount_s = discount_s;
        Discount_c = discount_c;
        AmountDue_s = amountDue_s;
        AmountDue_c = amountDue_c;
        }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
         }
         if (discount_s)
         { mPrice -= mdecDiscount_s; }
         AmountDue_s = mPrice * quantity;
            if (discount_c)
         { mPrice -= mdecDiscount_c; }
         AmountDue_c = mPrice * quantity;

     }
    }
}
