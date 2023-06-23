using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St2DoKolokwium.Storage.Entity
{
    public class CompetitionType
    {
        [Key]
        public int CompetitionTypeId { get; set; }
        public string Name { get; set; }

    }
}
