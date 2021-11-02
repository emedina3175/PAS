
namespace PAS.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        [Display(Name = "Identification")]
        [Required()]
        [MaxLength(16, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string IdentificationNumber { get; set; }

        [MaxLength(60)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(60)]
        [Required]
        public string LastName { get; set; }

        public Company Company { get; set; }
    }
}
