using ASPCore.Models.StudentModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Controllers
{
    public class StudentController : Controller
    {
        private IStudentDB _service;
        public StudentController(IStudentDB service)
        {
            _service = service;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            return View(_service.GetStudents());
        }

        
        
        
        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            Student student = _service.GetStudent(id);
            return View(student);
        }

        
        
        
        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _service.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student, int id)
        {
            _service.UpdateStudent(student, id);
            return RedirectToAction("Index");
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            _service.RemoveStudent(id);
            return RedirectToAction("Index");
        }

        
        
        // POST: StudentController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
