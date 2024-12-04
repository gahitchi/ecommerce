using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ramansanzon
{
    class Product : IEquatable<Product>
    {
        private string id;
        private string name;
        private string description;
        private double prezzo;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Description
        {
            get { return description; }
        }
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }

        private string idGeneration()
        {
            Random numbers = new Random();
            return Id = numbers.Next(1000000000, 2000000000).ToString();
        }

        public bool Equals(Product other)
        {
            if (other == null) return false;
            if (this == other) return true;

            return id.Equals(other.id);
        }

        public Product (string Id, string name, string description, double prezzo)
        {
            this.Id = idGeneration();
            this.name = name;
            this.description = description;
            this.prezzo = prezzo;
        }
    }
}
