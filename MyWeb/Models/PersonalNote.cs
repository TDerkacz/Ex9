using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class PersonalNote
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill content")]
        public string Content { get; set; }

        [Required]
        [Range(1, 5)]
        public int Priority { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
    }
}