using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        bool UpdateStudentInfo(Student student);
    }
    public class StudentService : IStudentService
    {
        private DataContext _context;
        public StudentService(DataContext context)
        {
            _context = context;
        }
        public List<Student> GetStudents()
        {
            return _context.Students.Include(x => x.Class).ToList();
        }
        public Student GetStudentById(int id)
        {
            return _context.Students.Include(x => x.Class).FirstOrDefault(x=>x.StudentId == id);
        }
        public bool UpdateStudentInfo(Student studentInput)
        {
            // try
            // {
            //     var student = _context.Students.FirstOrDefault(x =>x.StudentId == studentInput.StudentId);
            //     student.StudentName = studentInput.StudentName;
            //     student.BirthDate = studentInput.BirthDate;
            //     student.ClassId = studentInput.ClassId;
            //     _context.SaveChanges();
            //     return true;
            // }
            // catch (System.Exception)
            // {
            //     return false;
            // }
            var student = _context.Students.FirstOrDefault(x =>x.StudentId == studentInput.StudentId);
                student.StudentName = studentInput.StudentName;
                student.BirthDate = studentInput.BirthDate;
                student.ClassId = studentInput.ClassId;
                _context.SaveChanges();
                return true;
        }
    }
}