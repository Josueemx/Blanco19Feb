using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blanco19Feb.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        public int? ContactGroupId { get; set; }

        [ForeignKey("ContactGroupId")]
        public ContactGroup ContactGroup { get; set; }

        public string GetFullName()
        {
            if (string.IsNullOrWhiteSpace(Name) && string.IsNullOrWhiteSpace(LastName))
                return ("[No Name]");
            return $"{Name} {LastName}";
        }
    }
}
