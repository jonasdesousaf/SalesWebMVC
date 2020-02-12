﻿using System;
namespace SalesWebMVC.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Departament()
        {
        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
