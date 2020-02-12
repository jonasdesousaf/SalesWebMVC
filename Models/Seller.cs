﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Departament Departament { get; set; }

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, ICollection<SalesRecord> sales, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Sales = sales;
            Departament = departament;
        }

        public void addSales(SalesRecord sr)
        {
            Sales.Add(sr);
            
        }

        public void removeSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(s => s.Date >= initial && s.Date <= final).Sum(s => s.Amount);
        }
    }
}