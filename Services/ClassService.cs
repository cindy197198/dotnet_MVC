using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC.Services
{
    public interface IClassService
    {
        public List<Class> GetClasses();
    }
    public class ClassService : IClassService
    {
        private DataContext _context;
        public ClassService(DataContext context)
        {
            _context = context;
        }
        public List<Class> GetClasses()
        {
            return _context.Classes.ToList();
        }
    }
}