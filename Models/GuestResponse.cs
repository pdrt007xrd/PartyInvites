using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please Enter You Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter You eMail address")]
        //[RegularExpression(".+\\@\\..+", ErrorMessage ="Please enter a valid eMail")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter a valid phone Number")]
        public string  Phone { get; set; }
        [Required(ErrorMessage ="Please specify whether you attend")]
        public bool? WillAttend { get; set; }
    }
}
