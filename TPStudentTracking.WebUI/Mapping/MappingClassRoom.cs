using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using TPStudentTracking.Entities.Entities;
using TPStudentTracking.WebUI.ViewModels.Student;

namespace TPStudentTracking.WebUI.Mapping
{
    public class MappingClassRoom : Profile
    {
        public MappingClassRoom()
        {
            // ClassRoom → ComboBox
            CreateMap<ClassRoom, SelectListItem>()
                .ForMember(d => d.Value, o => o.MapFrom(s => s.Id.ToString()))
                .ForMember(d => d.Text, o => o.MapFrom(s => s.Name));

            // Student → ViewModel (LISTELEME / GET)
            CreateMap<Student, StudentViewModel>()
                .ForMember(d => d.ClassRoomName,
                    o => o.MapFrom(s => s.ClassRoom.Name));

            // ViewModel → Student (CREATE / POST)
            CreateMap<StudentViewModel, Student>();
        }
    }
}
