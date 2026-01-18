using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TPStudentTracking.Bussines.Services.Interfaces;
using TPStudentTracking.Data.Repositories.Interfaces;
using TPStudentTracking.Entities.Entities;

namespace TPStudentTracking.Bussines.Services
{
    public class ClassRoomService : IClassRoomService
    {
        private readonly IGenericRepository<ClassRoom> _classRepo;

        public ClassRoomService(IGenericRepository<ClassRoom> classRepo)
        {
            _classRepo = classRepo;
        }

        public List<ClassRoom> GetAll()
        {
            return _classRepo.GetAll();
        }
    }
}
