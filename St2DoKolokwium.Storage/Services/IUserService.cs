using St2DoKolokwium.Storage.Dtos;
using St2DoKolokwium.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St2DoKolokwium.Storage.Services
{
	public interface IUserService
	{
		List<UserDto> Read();
		void Create(UserDto reservation);
		List<CompetitionType> ReadCompetitionsTypes();
	}
}
