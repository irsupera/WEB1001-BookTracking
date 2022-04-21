using System;
using System.ComponentModel.DataAnnotations;

namespace BookTrackingApp.Models
{
    public class CategoryType
    {
        [Key]
        public string Type { get; set; }

        public string Name { get; set; }
    }
}
