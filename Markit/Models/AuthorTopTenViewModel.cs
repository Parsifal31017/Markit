using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Markit.Models
{
    public class AuthorTopTenViewModel
    {
        public List<Markit> Markits { get; set; }
        public SelectList Tops { get; set; }
        public string AuthorTop { get; set; }
        public string SearchString { get; set; }

        public Markit Markit { get; set; }
    }
}
