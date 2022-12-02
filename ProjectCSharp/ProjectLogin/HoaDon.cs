using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLogin
{
    public class HoaDon
    {
        private string productName;
        private double price;
        //private double discount = 0;

        private string display;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string ProductName { get => productName; set => productName = value; }
        public string Display
        {
            get { return string.Format("{0} - {1:#,###} VND", productName,price); }
        }

       // public double Discount { get => discount; set => discount = value; }

        public HoaDon()
        {
            this.productName = string.Empty;
            this.price = 0;


        }
        public HoaDon(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
        }
        //public HoaDon(string productName, double price, double discount)
        //{
        //    this.productName = productName;
        //    this.price = price;
        //    this.discount = discount;
        //}
    }
}
