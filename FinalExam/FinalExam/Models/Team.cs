using System.ComponentModel.DataAnnotations;

namespace FinalExam.Models
{ 
    public class Team:BaseEntity
    {
        [Required]
        public string  Image{ get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(15)]
        public string Job { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description  { get; set; }
    }
}
