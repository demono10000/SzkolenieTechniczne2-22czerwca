using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St2DoKolokwium.Storage.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(128, ErrorMessage = "Imię nie może przekraczać 128 znaków")]
        public string Name { get; set; }
        [Required]
        [StringLength(128, ErrorMessage = "Nazwisko nie może przekraczać 128 znaków")]
        public string LastName { get; set; }
        [Required]
        [StringLength(128, ErrorMessage = "Email nie może przekraczać 128 znaków")]
        public string Email { get; set; }
        public int CompetitionTypeId { get; set; }
        
    }
}
