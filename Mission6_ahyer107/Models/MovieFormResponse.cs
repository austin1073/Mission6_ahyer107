using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ahyer107.Models
{
    public class MovieFormResponse
    {
        //All the elements in the database and if they are required or not.
        //Sets this element as the key
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent_To { get; set; }

        //Sets the max string length to 25 characters for the notes
        [StringLength(25)]
        public string Notes { get; set; }
    }
}
