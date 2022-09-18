using System;
using System.ComponentModel.DataAnnotations;

namespace BookwormClient.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string TheReview { get; set; }

        [Required]
        public int LibraryId {get; set;}

        [Required]
        public int BookId {get; set;}
        // public virtual Book Book {get; set;}


    }
}