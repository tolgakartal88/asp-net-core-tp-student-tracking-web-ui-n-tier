using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPStudentTracking.Entities.Entities
{
    public class ExamDate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PeriodId {  get; set; }
        public Period Period { get; set; }
        [Required]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public DateTime Date { get; set; }
    }
}
