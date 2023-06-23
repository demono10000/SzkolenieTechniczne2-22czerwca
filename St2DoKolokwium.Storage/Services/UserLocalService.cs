using St2DoKolokwium.Storage.Dtos;
using St2DoKolokwium.Storage.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace St2DoKolokwium.Storage.Services
{
	public class UserLocalService : IUserService
	{
		private static List<UserDto> _users = new List<UserDto>()
		{
			new UserDto() { Id = 1, Email="aaa@wp.pl", Name="Adam", LastName="Nowak"}
		};
		public void Create(UserDto user)
		{
			_users.Add(user);
		}

		public List<UserDto> Read()
		{
			return _users;
		}


        public List<CompetitionType> ReadCompetitionsTypes()
		{
			return new List<CompetitionType>()
			{
				new CompetitionType { CompetitionTypeId = 1, Name = "Konkurs matematyczny"},
				new CompetitionType { CompetitionTypeId = 2, Name = "Konkurs sportowy"},
			};
		}
	}
}
