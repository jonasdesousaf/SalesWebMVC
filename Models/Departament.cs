using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament()
        {
        }

        public Departament(int id, string name, ICollection<Seller> sellers)
        {
            Id = id;
            Name = name;
            Sellers = sellers;
        }

        public void addSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(s => s.totalSales(initial, final));
        }
    }
}
