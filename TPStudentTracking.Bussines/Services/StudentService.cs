using TPStudentTracking.Bussines.Services.Interfaces;
using TPStudentTracking.Data.Repositories.Interfaces;
using TPStudentTracking.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace TPStudentTracking.Bussines.Services
{
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository<Student> _repository;

        public StudentService(IGenericRepository<Student> repository)
        {
            _repository = repository;
        }
        public List<Student> GetAllWithClassRoom()
        {
            return _repository
                .GetQueryable()               // IQueryable<Student>
                .Include(s => s.ClassRoom)    // 👈 NAVIGATION
                .ToList();
        }
        public List<Student> GetAll()
        {
            return _repository.GetAll();
        }

        public Student GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(Student student)
        {
            student.IsActive = true;
            _repository.Add(student);
        }

        public void Update(Student student)
        {
            _repository.Update(student);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Student? GetByIdWithClassRoom(int id)
        {
            return _repository
                .GetQueryable()
                .Include(x => x.ClassRoom)
                .FirstOrDefault(x => x.Id == id);

        }
    }
}
