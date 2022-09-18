using System;
using System.ComponentModel.DataAnnotations;

namespace BookwormClient.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        [Required]
        public double TheRating { get; set; }

        [Required]
        public int LibraryId {get; set;}

        [Required]
        public int BookId {get; set;}

    
    }
}