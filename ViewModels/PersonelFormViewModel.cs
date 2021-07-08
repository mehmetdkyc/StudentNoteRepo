using PersonelMVCUI.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelMVCUI.ViewModels
{
    public class PersonelFormViewModel
    {
        public IEnumerable<Notes> Notes { get; set; }
        public Student Student { get; set; }
    }
}