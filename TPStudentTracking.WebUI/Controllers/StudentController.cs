using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection.Metadata;
using TPStudentTracking.Bussines.Services;
using TPStudentTracking.Bussines.Services.Interfaces;
using TPStudentTracking.Entities.Entities;
using TPStudentTracking.WebUI.ViewModels.Student;

namespace TPStudentTracking.WebUI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _service;
        private readonly IClassRoomService _classRoomService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService service, IClassRoomService classRoomService, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            _classRoomService = classRoomService;
        }

        public IActionResult Index()
        {
            var students = _service.GetAllWithClassRoom();

            var model = new StudentListPageViewModel
            {
                CreateStudent = new CreateStudentViewModel
                {
                    ClassRooms = _mapper.Map<List<SelectListItem>>(
                _classRoomService.GetAll()
                )
                },
                EditStudent = new EditStudentViewModel(),
                StudentList = _mapper.Map<List<StudentViewModel>>(students)

            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentListPageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(
                        x => x.Key,
                        x => x.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                    );

                return Json(new
                {
                    success = false,
                    errors
                });
            }

            var student = new Student
            {
                StudentId = model.CreateStudent.StudentId,
                FirstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(model.CreateStudent.FirstName),
                LastName = CultureInfo.CurrentUICulture.TextInfo.ToUpper(model.CreateStudent.LastName),
                BirthDate = model.CreateStudent.BirthDate,
                ClassRoomId = model.CreateStudent.ClassRoomId,
                IsActive = true
            };

            _service.Add(student);

            var addedStudent = _service.GetByIdWithClassRoom(student.Id) as Student;

            return Json(new
            {
                success = true,
                student = new
                {
                    addedStudent!.Id,
                    addedStudent.StudentId,
                    addedStudent.FirstName,
                    addedStudent.LastName,
                    BirthDate = addedStudent.BirthDate.ToShortDateString(),
                    ClassRoomName = addedStudent.ClassRoom!.Name
                }
            });
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _service.GetById(id);
            if (student == null)
                return NotFound();

            return PartialView("_EditStudentModal", new EditStudentViewModel
            {
                Id = student.Id,
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDate = student.BirthDate,
                ClassRoomId = student.ClassRoomId,
                ClassRooms = _mapper.Map<List<SelectListItem>>(
                _classRoomService.GetAll())
            });
        }

        [HttpPost]
        public IActionResult Edit(EditStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_EditStudentModal", model);
            }
            var student = new Student
            {
                Id = model.Id,
                StudentId= model.StudentId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate= model.BirthDate,
                ClassRoomId = model.ClassRoomId,
            };

            _service.Update(student);

            return Json(new
            {
                success = true,
                id = model.Id,
                firstName = model.FirstName,
                lastName = model.LastName,
                studentId = model.StudentId,
                ClassRoomId = model.ClassRoomId

            });
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Json(new { success = true });
        } 
    }
}
