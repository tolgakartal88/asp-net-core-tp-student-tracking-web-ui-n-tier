using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPStudentTracking.Entities.Entities
{
    public class Period
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }
        [AllowNull]
        public string? Description { get; set; }
    }
}
