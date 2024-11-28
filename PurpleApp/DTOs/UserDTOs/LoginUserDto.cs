using System.ComponentModel.DataAnnotations;

namespace PurpleApp.DTOs.UserDTOs
{
    public class LoginUserDto
    {
        [Required]
        [Display(Prompt ="Email or Username")]
        public string EmailOrUsername { get; set; }

        [Display(Prompt = "Password")]

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public bool IsPersistant {  get; set; }
    }
}
