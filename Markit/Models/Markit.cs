using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Markit.Models
{
    public class Markit
    {
        private AuthorTopTenViewModel authorTopTenViewModel;

        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Author { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(3000)]
        public string Text { get; set; }

        public AuthorTopTenViewModel AuthorTopTenViewModel { get; set; }
    }
}
