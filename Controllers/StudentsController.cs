using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [ProducesResponseType(200,Type=typeof(ICollection<Students>))]
        public IActionResult GetStudents()
        {
            var students=_studentRepository.GetStudents();

            return Ok(students);
        }

        [HttpPost]

        public IActionResult CreateStudent([FromBody] Students student)
        {
            var students = _studentRepository.AddStudent(student);

            if (!students)
                return BadRequest(400);

            return Ok("succesfully added");
        }

        [HttpDelete]

        public IActionResult DeleteStudent(int id)
        {
            if (!_studentRepository.DeleteStudent(id))
            {
                return BadRequest("not deleted");
            }
            return Ok("successfully removed from the database");

        }

        [HttpPut]

        public IActionResult UpdateStudent([FromQuery] int StudentId, [FromBody] Students student)
        {
            if (!_studentRepository.UpdateStudent(StudentId,student))
            {
                return BadRequest("not updated");
            }

            return Ok("Sucessfully Updated");
        }
       
    }
}
