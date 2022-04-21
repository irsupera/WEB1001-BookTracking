using System;
using System.ComponentModel.DataAnnotations;

namespace BookTrackingApp.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        public string Title { get; set; }
        public string CategoryID { get; set; }
        public string Author { get; set; }

        public Category Category { get; set; }
    }
}
