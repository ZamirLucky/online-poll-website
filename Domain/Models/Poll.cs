using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Poll
    {
        [Key]
        public int PollID { get; set; }

        [Required(ErrorMessage = "The poll title is required.")]
        [MaxLength(200, ErrorMessage = "The poll title cannot exceed 200 characters.")]
        public string Title { get; set; }

        // Text for each option
        [Required(ErrorMessage = "Option 1 text is required.")]
        public string Option1Text { get; set; }

        [Required(ErrorMessage = "Option 2 text is required.")]
        public string Option2Text { get; set; }

        [Required(ErrorMessage = "Option 3 text is required.")]
        public string Option3Text { get; set; }
    
        // Vote counts for each option
        public int Option1VotesCount { get; set; }
        public int Option2VotesCount { get; set; }
        public int Option3VotesCount { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
