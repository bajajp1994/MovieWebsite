using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Widly.Models
{
    public class Movie
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Id{ get; set; }
        public Genre Genre { get; set; }
        [Display(Name="Genre")]
        [Required]
        public  byte GenreId { get; set; }
        [Display(Name="Date Of Release")]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        [Required]
        [Display(Name = "Number Of Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }

    }
}