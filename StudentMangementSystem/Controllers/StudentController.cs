using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentMangementSystem.Models;

namespace StudentMangementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentManagementSystemContext ORM = null;

        public StudentController(StudentManagementSystemContext _ORM)
        {
            ORM = _ORM;
        }

        [HttpGet]
        public IActionResult AddNewStudent()
        {
            return View();
        }



        [HttpPost]
        public IActionResult AddNewStudent(Student S)
        {
            ORM.Student.Add(S);
            ORM.SaveChanges();

            return RedirectToAction(nameof(StudentController.ShowAllStudents));
        }

        public IActionResult ShowAllStudents()
        {
           return View(ORM.Student.ToList());
        }

        [HttpGet]
        public IActionResult StudentDetail(int id)
        {
            return View(ORM.Student.Find(id));
        }


        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            return View(ORM.Student.Find(id));
        }

        [HttpPost]
        public IActionResult EditStudent(Student S)
        {
            ORM.Student.Update(S);
            ORM.SaveChanges();

            return RedirectToAction(nameof(StudentController.ShowAllStudents));
        }

        public IActionResult DeleteStudent(int id)
        {
            ORM.Student.Remove(ORM.Student.Find(id));
            ORM.SaveChanges();
            return RedirectToAction(nameof(StudentController.ShowAllStudents));



        }



    }
}