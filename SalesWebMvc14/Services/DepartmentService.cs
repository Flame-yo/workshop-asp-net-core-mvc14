using SalesWebMvc14.Data;
using SalesWebMvc14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc14.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc14Context _context;

        public DepartmentService(SalesWebMvc14Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
