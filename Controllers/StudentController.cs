using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace Namespace
{
    public class StudentController : Controller
    {
        private StudentModel studentModel;
        public StudentController()
        {
            studentModel = new StudentModel();
        }
        public IActionResult Index()
        {
            var students = studentModel.GetStudents();
            ViewBag.Students = students;
            return View();
        }
    }
}
