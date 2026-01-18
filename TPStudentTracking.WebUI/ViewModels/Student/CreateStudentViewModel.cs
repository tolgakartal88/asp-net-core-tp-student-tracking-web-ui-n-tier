using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TPStudentTracking.WebUI.ViewModels.Student
{
    public class CreateStudentViewModel
    {
        [Required(ErrorMessage = "Öğrenci numarası zorunludur")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Soyad alanı zorunludur")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Sınıf seçimi zorunludur")]
        public int ClassRoomId { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }

        // 🔵 SADECE GET tarafında dropdown doldurmak için
        public List<SelectListItem>? ClassRooms { get; set; }
        public bool IsActive { get; set; }
    }
}
