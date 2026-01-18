using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TPStudentTracking.WebUI.ViewModels.Student
{
    public class StudentListPageViewModel
    {
        [ValidateNever]
        public List<StudentViewModel> StudentList { get; set; }
        public required CreateStudentViewModel CreateStudent { get; set; }

        public EditStudentViewModel EditStudent { get; set; }
    }
}
