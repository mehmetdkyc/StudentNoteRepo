using PersonelMVCUI.Models.EntityFramework;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelMVCUI.ViewModels;

namespace PersonelMVCUI.Controllers
{
    [Authorize(Roles = "ST,AD")]
    public class StudentController : Controller
    {
        PersonelDbEntities1 db = new PersonelDbEntities1();
        
        // GET: Personel
        [OutputCache(Duration =30)] // server'ı çok yormamak adına az yapılan işlemleri geçici belleğe atarız.

        public ActionResult Index()
        {
            var model = db.Student.Include(x => x.Notes).ToList();
            return View(model);
        }
        
        public ActionResult Yeni()
        {
            var model = new PersonelFormViewModel()
            {
                Notes = db.Notes.ToList(),
                Student=new Student() // Kaydet formunda personel id'ye ihtiyacımız var boş bir model yolluyoruz.
            };
            return View("PersonelForm", model);
        }
        [ValidateAntiForgeryToken]
        public ActionResult Save(Student student)
        {
            if (!ModelState.IsValid)
            {
                var model = new PersonelFormViewModel()
                {
                    Notes = db.Notes.ToList(),
                    Student= student
                };
                return View("PersonelForm",model);
            }
            if (student.Id == 0)
            {
                db.Student.Add(student);
            }
            else
            {
                db.Entry(student).State=System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var model = new PersonelFormViewModel() {
                Notes = db.Notes.ToList(),
                Student=db.Student.Find(id)
            };
            return View("PersonelForm",model);
        }
        public ActionResult Delete(int id)
        {
            var deletedStudent = db.Student.Find(id);
            if (deletedStudent == null) return HttpNotFound();
            db.Student.Remove(deletedStudent);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult StudentList(int id)
        {
            var model = db.Student.Where(x=>x.Id==id).ToList();
            return PartialView(model);
        }
    }
}