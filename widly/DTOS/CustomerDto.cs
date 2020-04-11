using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Widly.Models;

namespace Widly.DTOS
{
    public class CustomerDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        //  [Min18YrsIfAMember]
        public DateTime? Birthdate { get; set; }
        public int Id { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}