using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PingPong.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public int? Age { get; set; }
        [Required]
        [DisplayName("Skill Level")]
        public SkillLevel SkillLevelID { get; set; } 
        [Required, EmailAddress]
        //the EmailAddress attribute was not checking the email properly (e.g. it accepted 123@example as a valid email address, so I've added a regular expression as well)
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage ="Please enter a valid email address")]
        public string Email { get; set; }
    }

    public enum SkillLevel
    {
        Beginner,
        Intermediate,
        Advanced,
        Expert
    }
}
