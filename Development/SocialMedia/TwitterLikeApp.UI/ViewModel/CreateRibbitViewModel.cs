using System.ComponentModel.DataAnnotations;

namespace TwitterLikeApp.UI.ViewModel
{
    public class CreateRibbitViewModel
    {
        [Required]
        [MaxLength(140, ErrorMessage = "Status cannot be more than 140 characters.")]
        public string Status { get; set; }
    }
}