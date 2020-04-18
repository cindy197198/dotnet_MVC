using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MVC.Models
{
    public class StudentModel
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(){StudentId = 102178222,StudentName = "Trang", BirthDate = DateTime.Now});
            students.Add(new Student(){StudentId = 102178223,StudentName = "Trang", BirthDate = DateTime.Now});

            return students;
        }
    }
}