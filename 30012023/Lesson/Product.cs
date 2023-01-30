using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Product
    {
        public Product(double price)
        {
            this.Price = price;
        }
        
        public string Name;

        private double _price;

        public double Price {
            set
            {
                if (value >= 0)
                    _price = value;
            }
            get
            {
                return _price;
            }
        }

        public string Info => $"Name: {Name} - Price: {_price}";

        //public string Info
        //{
        //    get
        //    {
        //        return $"Name: {Name} - Price: {_price}";
        //    }
        //}
        public void SetPrice(double price)
        {
            if (price >= 0)
            {
                this._price = price;
            }
        }

        public double GetPrice()
        {
            return _price;
        }


        public string GetInfo()
        {
            return $"Name : {Name} - Price: {_price}";
        }
    }
}
