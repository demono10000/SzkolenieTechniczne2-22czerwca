using Microsoft.EntityFrameworkCore;
using St2DoKolokwium.Storage.Dtos;
using St2DoKolokwium.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St2DoKolokwium.Storage.Services
{
	public class UserService : IUserService
	{
		private readonly UserContext _dbContext;

		public UserService(UserContext dbContext) {
			_dbContext = dbContext;
			DbInitializer.Init(_dbContext);
		}
		public void Create(UserDto user)
		{
			var entity = new User()
			{
				Name = user.Name,
				LastName = user.LastName,
				CompetitionTypeId = user.CompetitionTypeId,
				Email = user.Email
			};
			_dbContext.Set<User>().Add(entity);
			_dbContext.SaveChanges();
		}

		public List<UserDto> Read()
		{
			var result = _dbContext.Users.Include(x => x.CompetitionType).Select(x =>
			new UserDto()
			{
				Name = x.Name,
				LastName = x.LastName,
				Email = x.Email,
			}).ToList();
			return result;
		}


        public List<CompetitionType> ReadCompetitionsTypes()
		{
			var result = _dbContext.CompetitionTypes.ToList();
			return result;
		}
	}
}
