using System;
using System.Linq;
using System.Collections.Generic;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class DepartamentService
    {
        private SalesWebMVCContext _context;

        public DepartamentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
