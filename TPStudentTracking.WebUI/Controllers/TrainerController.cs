using Microsoft.AspNetCore.Mvc;
using TPStudentTracking.Bussines.Services.Interfaces;
using TPStudentTracking.Entities.Entities;

namespace TPStudentTracking.WebUI.Controllers
{
    public class TrainerController : Controller
    {
        private readonly IStudentService _service;

        public TrainerController(IStudentService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _service.Add(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            return View(_service.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _service.Update(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            return View(_service.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
