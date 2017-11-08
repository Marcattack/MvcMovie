using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Date de sortie"), DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        public string Genre { get; set; }

        [Display(Name = "Prix"), Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}