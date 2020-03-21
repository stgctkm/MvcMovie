using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3, ErrorMessage = "タイトルは3-60文字で入力してください")]
        public string Title { get; set; }
        
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/M/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [StringLength(30)]
        public string Genre { get; set; }
       
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        
    }
}