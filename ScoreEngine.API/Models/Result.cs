using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreEngine.API.Models
{
    public class Result
    {
        [Key]
        [Column(TypeName = "uniqueidentifier")]
        [Required]
        public Guid UId { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }
    }
}
