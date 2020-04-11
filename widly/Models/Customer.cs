using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Widly.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name="Date Of Birth")]
        [Min18YrsIfAMember]
        public DateTime? Birthdate { get; set; }
        public int Id { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name ="Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}