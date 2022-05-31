﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab4MVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(20)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Name")]
        public string FullName => FirstName + " " + LastName;
    }
}
