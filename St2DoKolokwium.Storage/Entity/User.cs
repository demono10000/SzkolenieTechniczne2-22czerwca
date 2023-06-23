using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St2DoKolokwium.Storage.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }
        [Required]
        [MaxLength(120)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(120)]
        public string Email { get; set; }
        [Required]
        public int CompetitionTypeId { get; set; }
        public CompetitionType CompetitionType { get; set; }
    }
}
