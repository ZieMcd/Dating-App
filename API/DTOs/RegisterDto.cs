using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto  //DTO is a good place to do validation 
    {
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}