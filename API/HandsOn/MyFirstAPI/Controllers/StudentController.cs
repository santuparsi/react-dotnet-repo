using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        string[]students= new[] { "Rohan", "Ramya", "Ridhi", "Nidi" };
        //endpoints or action-methods
        [HttpGet,Route("GetStudents")]
        public string[] GetStudents()
        {
            return students;
        }
        [HttpGet,Route("Get/{id}")]
        public string GetStudent(int id)
        {
            return students[id];
        }
        [HttpPost,Route("Add/{name}")]
        public string AddStudent(string name)
        {
            return "Student Added";
        }
        [HttpPut,Route("Edit/{name}")]
        public string UpdateStudent(string name)
        {
            return "Student Updaed";
        }
        [HttpDelete,Route("Delete/{id}")]
        public string DeleteStudent(int id)
        {
            return "Student Deleted";
        }
    }
}
