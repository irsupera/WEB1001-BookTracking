using System;
using System.ComponentModel.DataAnnotations;

namespace BookTrackingApp.Models
{
    public class Category
    {
        [Key]
        public string NameToken { get; set; }

        public string TypeID { get; set; }
        public string Description { get; set; }

        public CategoryType CategoryType { get; set; }
    }
}
