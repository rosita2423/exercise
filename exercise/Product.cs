using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Product
    {
        public int price;
        public int discountMax;
        public int code;
        //public void setDiscountMax(int disc)
        //{
        //    this.discountMax = disc;
        //}
        public void setCode(int code1)
        {
            this.code = code1;
        }
        public void setPrice(int precio)
        {
            this.price = precio;
        }
        //public int orderAProduct(int products)
        //{
        //    int totalPrice = price*products;
        //    return products;
        //}


    }

}
