using System;
using System.ComponentModel.DataAnnotations;

namespace Markit.Models
{
    public class Markit
    {
        public int Id { get; set; }
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Text { get; set; }
    }
}
