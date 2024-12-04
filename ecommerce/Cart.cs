using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ramansanzon
{
    internal class Cart
    {
        private string id;
        //private int totalProducts;
        //private double totalMoney;
        private List<Product> list;
        //private int found;

        public string Id
        {
            get { return id; }
        }

        /*public int TotalProducts
        {
            get { return totalProducts; }
            set { totalProducts = value; }
        }

        public double TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }*/

        public List<Product> List
        {
            get { return list; }
            set { list = value; }
        }


        public void addProd(Product p)
        {
            if (p == null)
                return;
            list.Add(p);
        }

        public void removeProd(Product p)
        {
            if ( p == null)
                return;
            list.Remove(p);
        }

        public void emptyCart()
        {
            list.Clear();
        }
        /*public void removeProd(Product p)
        {
            if (list != null)
            {
                found = list.IndexOf(p);
            }
            if (found < 0)
            {
                MessageBox.Show("product not found, cannot remove");
            }
        }*/

        public Cart (string id)
        {
            this.id = id;
            //this.TotalProducts = TotalProducts;
            //this.TotalMoney = TotalMoney;   
            list = new List<Product>();
        }
    }
}
