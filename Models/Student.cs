using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime BirthDate { get; set; }

        [ForeignKey("Class")]
        public int ClassId  {get;set;}
        public Class Class  {get;set;}
    }
}