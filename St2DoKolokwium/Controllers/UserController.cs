using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using St2DoKolokwium.Storage.Dtos;
using St2DoKolokwium.Storage.Services;
using St2DoKolokwium.UI.Models;
using System.Diagnostics;

namespace St2DoKolokwium
{
	public class UserController : Controller
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			_userService = userService;
		}
		public IActionResult Index()
		{
			return View(_userService.Read());
		}
		public IActionResult Add()
		{
			var model = new UserModel();
			model.CompetitionTypes = _userService.ReadCompetitionsTypes().Select(x => new SelectListItem
			{
				Text = x.Name,
				Value = x.CompetitionTypeId.ToString()
			}).ToList();

			return View(model);
		}
		[HttpPost]
		public IActionResult Add(UserDto model)
		{
			if (ModelState.IsValid)
			{
				_userService.Create(model);
				return RedirectToAction("Index");
			}
            var userModel = new UserModel
            {
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                CompetitionTypeId = model.CompetitionTypeId
            };

            userModel.CompetitionTypes = _userService.ReadCompetitionsTypes().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.CompetitionTypeId.ToString()
            }).ToList();

            return View(userModel);
        }
	}
}
