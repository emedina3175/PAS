
namespace PAS.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class Company
    {

        [Display(Name = "Company Id")]
        [Required()]
        public int CompanyId { get; set; }

        [Display(Name = "Identification")]
        [Required()]
        [MaxLength(16, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string IdentificationNumber { get; set; }

        [Display(Name = "Name")]
        [MaxLength(120)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Business Name")]
        [MaxLength(120, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string BusinessName { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Foundation Date")]
        public DateTime FoundationDate { get; set; }

        [Display(Name = "Phone")]
        [MaxLength(16, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [DataType(DataType.PhoneNumber)]
        public string OfficeNumber { get; set; }

        [Display(Name = "Fax")]
        [MaxLength(16, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [DataType(DataType.PhoneNumber)]
        public string FaxNumber { get; set; }

        [Display(Name = "Email")]
        [MaxLength(120, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Description")]
        [MaxLength(360, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string Description { get; set; }

        public bool IsEnabled { get; set; }
    }
}
