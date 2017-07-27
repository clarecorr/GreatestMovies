using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GreatestMovies.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Box Office Gross")]
        public double BoxOfficeGross { get; set; }

        [ForeignKey("Genre")]
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }

    }
}