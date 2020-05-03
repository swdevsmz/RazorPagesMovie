using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [DisplayName("タイトル")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "リリース日")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "価格")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        public decimal Price { get; set; }

        [Display(Name = "ジャンル")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Display(Name = "評価")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

    }
}
