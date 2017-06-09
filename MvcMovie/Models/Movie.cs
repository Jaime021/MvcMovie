using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MvcMovie.Models
{
 
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Director { get; set; }

        [Display(Name = "Release Date"),DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        
        [Range(0, 10)]
        public decimal Score { get; set; }

        [StringLength(4)]
        public string Stars { get; set; }


        [Range(1, 100),DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }

        public string URL { get; set; }
       


    }
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}