using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineMovieStoreV2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter this value")]
        public string Name { get; set; }

        public Genre Genre { get; set; }


        [Required(ErrorMessage = "Please enter this value")]
        public int GenreId { get; set; }

        public int ReleaseDate { get; set; }


        [Required(ErrorMessage = "Please enter this value")]
        [Range(1,10)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

    }
}