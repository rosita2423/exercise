using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Order
    {
        public int cuentaTotal;
        public int totals = 0;
        public bool enter = false;

        public int boxOrdered = 0;
        public int bagOrdered = 0;
        public int price = 0;
        public void cuenta(int cod, int piezas)
        {
            price = 0;
            totals = 0;
            if (cod == 12345)
            {
                price = 10;
                this.totals = this.totals + (price * piezas);

                this.boxOrdered = this.boxOrdered + piezas;
                if (this.boxOrdered >= 15)
                {
                    this.totals = this.totals - 30;
                }
            }
            else
            {
                if (cod == 12346)
                {
                    price = 5;
                    this.totals = this.totals + (price * piezas);
                    this.bagOrdered = this.bagOrdered + piezas;
                    if (this.bagOrdered >= 20)
                    {
                        this.totals = this.totals - 20;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect code" + "\n");
                    this.enter = true;
                }
            }
            if (this.enter == false)
            {
                this.cuentaTotal = this.cuentaTotal + totals;
            }
            this.enter = false;
        }
        public int totalPedido()
        {

            return this.cuentaTotal;
        }
        public int calculation(Product xd,int orders)
        {

            int total = xd.price * orders;
            if (total >= xd.discountMax){
                total = total - 50;
            }
            return total;
        }
    }
}
