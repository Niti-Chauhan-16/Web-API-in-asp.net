using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IStudentRepository
    {
        public ICollection<Students> GetStudents();

        public Students GetStudent(int id);

        public bool AddStudent(Students student);



        public bool UpdateStudent(int id,Students student);
        public bool DeleteStudent(int id);

        public bool Save();
    }
}
