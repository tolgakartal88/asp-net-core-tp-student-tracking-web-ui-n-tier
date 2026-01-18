using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TPStudentTracking.Entities.Entities;

namespace TPStudentTracking.WebUI.ViewModels.Student
{
    public class EditStudentViewModel
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public int ClassRoomId { get; set; }
        public List<SelectListItem>? ClassRooms { get; set; }
    }
}
