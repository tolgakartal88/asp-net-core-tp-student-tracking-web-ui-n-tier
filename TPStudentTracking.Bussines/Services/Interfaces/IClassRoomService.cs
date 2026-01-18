using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TPStudentTracking.Entities.Entities;

namespace TPStudentTracking.Bussines.Services.Interfaces
{
    public interface IClassRoomService
    {
        List<ClassRoom> GetAll();
    }
}
