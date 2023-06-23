using Microsoft.AspNetCore.Mvc.Rendering;
using St2DoKolokwium.Storage.Entity;

namespace St2DoKolokwium.UI.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CompetitionTypeName { get; set; }
        public int CompetitionTypeId { get; set; }
        public List<SelectListItem> CompetitionTypes { get; set; }
    }
}