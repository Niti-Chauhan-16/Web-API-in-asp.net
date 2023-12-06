using System.ComponentModel.DataAnnotations;
using WebApi.Data;

namespace WebApi.Models
{
    public class Students
    {
        [Key]

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        
    }
}
