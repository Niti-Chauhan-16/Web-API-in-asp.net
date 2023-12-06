using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Repository
{
    public class StudentRepository:IStudentRepository
    {
        public readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
             _context = context;
        }


        public ICollection<Students> GetStudents()
        {
            return _context.Students.ToList();

        }

        public bool AddStudent(Students student)
        {
           
            _context.Add(student);

            return Save();
           
           
        }

        public Students GetStudent(int id)
        {
            return _context.Students.Where(x => x.StudentId == id).FirstOrDefault();
        }
        public bool DeleteStudent(int id)
        {

            var StudentData = GetStudent(id);
            if(StudentData==null)
            {
                return false;
            }

            _context.Remove(StudentData);
            return Save();


        }

        public bool UpdateStudent(int id,Students students)
        {
            _context.Update(students);
            return Save();
        }

        public bool Save()
        {
            var result=_context.SaveChanges();

            return result > 0 ? true : false;
        }
    }
}
