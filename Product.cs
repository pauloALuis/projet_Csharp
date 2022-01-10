using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    class Product
    {

        private string _NameProduct { get; set; }

        private double _Price { get; set; }
        private int _Amount { get; set; }


        public Product(string nameProduct, double price, int unid) {

            this._Amount = unid;
            this._NameProduct = nameProduct;
            this._Price = price;
        }
        public override string ToString()
        {
            return "Product (" + _NameProduct.ToUpper() + ", " + _Price.ToString("F2", CultureInfo.InvariantCulture) + "€, " 
                + _Amount + " Unidades, Total "+ this.TotalValueInStock.ToString("F2", CultureInfo.InvariantCulture) + "€)";
        }
        /// <summary>
        /// total value in stock

        /// </summary>
        public double TotalValueInStock  
        {
            get{return this._Price * (double)_Amount; } 
        }


        /// <summary>
        /// total value in stock

        /// </summary>
        public void AddProduct(int quantity=1)
        {
            if (quantity < 1)
            {
                Console.WriteLine("Inserar uma quantidade de produto correta");
            }
            else
            {
                _Amount += quantity;
                Console.WriteLine($"Adicionou {quantity} unid do produto {_NameProduct}\n Quantidade Atual {_Amount}");

            }
        }



        /// <summary>
        /// total value in stock

        /// </summary>
        public void RemoveProduct(int quantity = 0)
        {

            if (quantity < 1 || quantity > _Amount)
            {
                Console.WriteLine("Inserar a quantidade correta a ser removido \n Enter the correct amount to be removed");
                //Console.WriteLine("Inserar a quantidade correta a ser removido");

            }
            else
            {
                _Amount -= quantity;
                Console.WriteLine($"Removeu {quantity} unidades do produto {_NameProduct} -- {_Amount} unid\n" +
                    $"Removed {quantity} units from product {_NameProduct} -- {_Amount} units" );
            }
           // _Amount -= quantity;
        }
    }
}
