using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Vote
    {
        [Key]
        public int VoteID { get; set; }
        public int PollID { get; set; }
        public int UserID { get; set; }
        public int OptionSelected { get; set; } // 1, 2, or 3 for the respective options
        public DateTime DateVoted { get; set; }


        // Foreign keys
        [ForeignKey("PollID")]
        public virtual Poll Poll { get; set; } // Navigation property to Poll

        [ForeignKey("UserID")]
        public virtual User User { get; set; } // Navigation property to User

    }
}
