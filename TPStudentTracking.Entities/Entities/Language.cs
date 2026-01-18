using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TPStudentTracking.Entities.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Key { get; set; }        // StudentNameRequired
        public string Culture { get; set; }    // tr-TR, en-US
        public string Value { get; set; }      // Öğrenci adı boş olamaz
    }
}
