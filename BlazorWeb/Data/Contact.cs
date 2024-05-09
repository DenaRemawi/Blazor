using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWeb.Data
{
    [Table("Contacts")]

    public class Contact
    {

   
        public int ID { set; get; }

        [Required(ErrorMessage = "First Name Required ")]
        [DisplayName("First Name")]
        public string FirstName { set; get; }

        [Required(ErrorMessage = "Last Name Required ")]
        [DisplayName("Last Name")]
        public string LastName { set; get; }

        [Required(ErrorMessage = "Email Required ")]
    

        public string Email { set; get; }
        [Required(ErrorMessage = "Phone Number Required ")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { set; get; }
    }
    
}
