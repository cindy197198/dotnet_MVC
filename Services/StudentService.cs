// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using MVC.Models;

// namespace MVC.Services
// {
//     public interface IStudentService
//     {
//         public List<Student> GetStudents();
//     }
//     public class StudentService : IStudentService
//     {
//         private DataContext _context;
//         public List<Student> GetStudents()
//         {
//             return _context.Students.ToList();
//         }
//     }
// }