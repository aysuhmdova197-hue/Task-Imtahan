using System.ComponentModel.DataAnnotations;

namespace Folder14.Viewmodels.Account
{
    public class LoginVm
    {
        [Required]
        public string EmailOrUserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
