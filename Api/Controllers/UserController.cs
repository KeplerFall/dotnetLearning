using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			return Ok(new { username = username, password = password});
		}

	}
}
