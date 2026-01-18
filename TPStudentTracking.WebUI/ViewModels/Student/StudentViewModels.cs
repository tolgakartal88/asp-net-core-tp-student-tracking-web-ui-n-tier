using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TPStudentTracking.WebUI.ViewModels.Student
{

    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Sınıf seçimi zorunludur")]
        public int ClassRoomId { get; set; }
        public List<SelectListItem> ClassRooms { get; set; }
        public string ClassRoomName { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }

        public bool IsActive { get; set; }
    }

}
