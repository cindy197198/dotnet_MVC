using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MVC.Models
{
    [Table("Class")]
    public class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int ClassId {get;set;}
        public string ClassName  {get;set;}
        public virtual HashSet<Student> Students {get;set;}

    }
}