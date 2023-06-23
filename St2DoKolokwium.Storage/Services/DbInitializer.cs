using St2DoKolokwium.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St2DoKolokwium.Storage.Services
{
	public static class DbInitializer
	{
		public static void Init(UserContext context)
		{
			if(!context.CompetitionTypes.Any())
			{
				var entity1 = new CompetitionType() { CompetitionTypeId = 1, Name = "Konkurs matematyczny" };
				var entity3 = new CompetitionType() { CompetitionTypeId = 2, Name = "Konkurs historyczny" };
				context.CompetitionTypes.AddRange(entity1, entity3);
				context.SaveChanges();
			}
		}
	}
}
