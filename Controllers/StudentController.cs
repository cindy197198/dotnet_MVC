using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Services;

namespace Namespace
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        private IClassService _classService;
        public StudentController(IStudentService studentService,IClassService classService)
        {
            _studentService = studentService;
            _classService = classService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            return View(students);
        }
        public IActionResult Detail(int id)
        {
            var student = _studentService.GetStudentById(id);
            return View(student);
        }
        public IActionResult Edit(int id)
        {
            var student = _studentService.GetStudentById(id);
            ViewBag.Classes = _classService.GetClasses();
            return View(student);
        }
        public IActionResult EditStudent(Student student)
        {
            _studentService.UpdateStudentInfo(student);
            var students = _studentService.GetStudents();
            return View("Index",students);
        }
    }
}
