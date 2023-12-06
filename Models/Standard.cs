using System.ComponentModel.DataAnnotations;
using WebApi.Data;

namespace WebApi.Models
{
    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }
        
    }
}
