using TPStudentTracking.Entities.Entities;

namespace TPStudentTracking.Bussines.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAll();
        List<Student> GetAllWithClassRoom();
        Student GetById(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
        Student? GetByIdWithClassRoom(int ıd);
    }
}
