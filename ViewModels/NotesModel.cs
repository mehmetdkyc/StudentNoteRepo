using PersonelMVCUI.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelMVCUI.ViewModels
{
    public class NotesModel
    {
        public List<Notes> Notes { get; set; }
        public List<Student> Student { get; set; }
        
    }
}