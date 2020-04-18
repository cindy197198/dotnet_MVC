using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
//using MVC.Services;

namespace Namespace
{
    public class StudentController : Controller
    {
        //private IStudentService _studentService;
        private StudentModel studentModel;
        // public StudentController(StudentService studentService)
        // {
        //     _studentService = studentService;
        // }
        public IActionResult Index()
        {
            var students = studentModel.GetStudents();
            //ViewBag.Students = students;
            //ViewData["Students"] = students;
            return View(students);
        }
        public IActionResult Detail()
        {
            var student = studentModel.GetStudentById(102178822);
            return View(student);
        }
    }
}
