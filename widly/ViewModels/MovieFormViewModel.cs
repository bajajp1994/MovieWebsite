using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Widly.Models;

namespace Widly.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
        }
        public IEnumerable<Genre> Genres { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int? Id { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }
        [Display(Name = "Date Of Release")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Number Of Stock")]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }
        public string Title
        {
            get
            {
                return Id !=0 ? "Edit Movie" : "New Movie";
            }
        }        
    }
}