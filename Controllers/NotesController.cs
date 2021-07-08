using PersonelMVCUI.Models.EntityFramework;
using PersonelMVCUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVCUI.Controllers
{
    [Authorize(Roles = "AD")]
    public class NotesController : Controller
    {
        PersonelDbEntities1 db = new PersonelDbEntities1();
        // GET: Departman
        
        public ActionResult Index()
        {
            var model = db.Notes.ToList();
            var modelStudent = db.Student.ToList();
            var notesModel = new NotesModel()
            {
                Student=modelStudent,
                Notes=model
            };
            return View(notesModel);
        }
      
    }
}