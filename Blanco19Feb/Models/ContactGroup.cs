using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blanco19Feb.Models
{
    public class ContactGroup
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public virtual List<Contact> Contacts { get; set; }

        public string Description { get; set; }
    }
}
