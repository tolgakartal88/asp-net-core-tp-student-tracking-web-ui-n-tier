using System.ComponentModel.DataAnnotations;

namespace TPStudentTracking.Entities.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClassRoomId {  get; set; }
        public ClassRoom ClassRoom { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
    }
}