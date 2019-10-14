using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMovieStoreV2.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineMovieStoreV2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
       public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public int? ReleaseDate { get; set; }

        [Display(Name ="Number In Stock")]
        [Range(1,20)]
        [Required]
        public byte? NumberInStock { get; set; }

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
            GenreId = movie.GenreId;
        }

    }
}