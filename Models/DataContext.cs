using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Class> Classes {get;set;}
        public DbSet<Student> Students {get;set;}
    }
}