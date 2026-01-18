using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPStudentTracking.Entities.Entities
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        [Required]
        public int ExamDateId { get; set; }
        public ExamDate ExamDate { get; set; }

        public int ExamScore_1 { get; set; }
        public int ExamScore_2 { get; set; }
        public int ExamScore_3 { get; set; }

        public int Interview_1 { get; set; }
        public int Interview_2 { get; set; }
        public int Interview_3 { get; set; }
    }
}
