using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_API_DotNetCore.Models
{
    public class Movie
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title  { get; set; }

        [Required]
        public int Rate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int Stock { get; set; }

       
        public Boolean Like { get; set; }

    }
}
