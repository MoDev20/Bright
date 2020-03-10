using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using BrightIdeas.Models;

namespace BrightIdeas.Models
{
    public class Idea 
    {
        [Key]
        public int IdeasId { get; set; }
        public int UserId { get; set; }
        [Required]
        [MinLength(5, ErrorMessage="Idea must be at least 5 characters!")]
        public string UserIdea{ get; set; }
        public User Blogger {get; set;}
        public List<Like> LikedBy {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
    
    }
}