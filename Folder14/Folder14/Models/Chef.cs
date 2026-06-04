using System.ComponentModel.DataAnnotations;

namespace Folder14.Models
{
    public class Chef:BaseEntity
    {
        [Required]
        public string Image { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(35)]
        public string Job { get; set; }


    }
}

