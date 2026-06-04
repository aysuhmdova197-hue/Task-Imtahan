using System.ComponentModel.DataAnnotations;

namespace Folder14.Viewmodels.Account
{
    public class RegisterVM
    {
        [Required]
        [MaxLength(40)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
