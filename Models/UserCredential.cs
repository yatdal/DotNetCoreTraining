using System.ComponentModel.DataAnnotations;

namespace dotnettraining.Models
{
    public class UserCredential
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        //public string Message{get;set;}
    }

    
}
