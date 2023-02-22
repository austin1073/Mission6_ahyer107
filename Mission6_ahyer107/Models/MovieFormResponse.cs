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

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Year is required.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent_To { get; set; }

        //Sets the max string length to 25 characters for the notes
        [StringLength(25)]
        public string Notes { get; set; }

        //Building the foreign key relationship
        [Required(ErrorMessage = "Category is required.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
