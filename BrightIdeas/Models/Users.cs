using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models

{
    public class User 
    {
        [Key]
        public int UserId { get; set; }
        
        [Required] 
        [MinLength(2, ErrorMessage = "User Name must be at least 2 characters long")]
        [RegularExpression(@"^[' 'A-Za-z ]+$", ErrorMessage = "User Name can only contain letters and space")]
        public string UserName { get; set; }

        [Required] 
        [MinLength(2, ErrorMessage = "UserName must be at least 2 characters long") ]
        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "User Alias can only contain letters and number")]
        public string UserAlias { get; set; }

        [Required] 
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long") ]
        public string Password { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Idea> UserIdeas {get; set;}
        public List<Like> UserLikes {get;set;}
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password Confirm must must Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}