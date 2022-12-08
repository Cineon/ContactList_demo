using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContactList_demo.Models
{
    public class Contacts
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string Firstname { get; set; }

        [Display(Name = "Surname")]
        public string Lastname { get; set; }

        [EmailAddress]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Your password doesn't meet the right criteria!")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [RegularExpression(@"^\d{9,12}$", ErrorMessage = "Your phone number should be between 9 and 12 characters long!")]
        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime Dateofbirth { get; set; }

        public Contacts()
        {

        }
    }
}
