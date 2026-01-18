using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPStudentTracking.Entities.Entities
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public int IsActive { get; set; }
    }
}
