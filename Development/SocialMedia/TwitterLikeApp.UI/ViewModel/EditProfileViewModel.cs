using System.ComponentModel.DataAnnotations;

namespace TwitterLikeApp.UI.ViewModel
{
    public class EditProfileViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL")]
        public string Website { get; set; }

        [MaxLength(140, ErrorMessage = "Bio can only be {0} characters.")]
        public string Bio { get; set; }
    }
}
