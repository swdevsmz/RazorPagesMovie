using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [DisplayName("タイトル")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("リリース日")]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("ジャンル")]
        public string Genre { get; set; }
        [DisplayName("価格")]
        public decimal Price { get; set; }

    }
}
