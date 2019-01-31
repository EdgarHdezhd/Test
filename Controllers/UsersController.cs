using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using WebApplication5.Services;

namespace WebApplication5.Controllers
{
	[Produces("application/json")]
	public class UsersController : ControllerBase
	{
		protected UserServices _userServices;
		public UsersController(UserServices userServices)
		{
			_userServices = userServices;
		}
		[HttpGet("api/users")]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("api/users/getUsers")]
		public List<User> GetUsers()
		{
			return _userServices.GetUsers();
		}
		// GET api/values/5
		[HttpPost("api/users/postUsers")]
		public List<User> PostUsers()
		{
			return _userServices.GetUsers();
		}

		[HttpGet("api/users/getUser/{id}")]
		public User GetUsers(int id)
		{
			return _userServices.GetUser(id);
		}

		[HttpPut("api/users/putUser/{id}")]
		public User PutUsers(int id)
		{
			return _userServices.GetUser(id);
		}



		[HttpGet("api/users/deleteUser/{id}")]
		public string DeleteUsers(int id)
		{
			_userServices.DeleteUser(id);
			return "ok";
		}

		[HttpGet("api/users/updateUser/{id}/{name}/{email}/{username}")]
		public ActionResult<string> UpdateUsers(int id, string name, string email, string username)
		{
			var newUser = new User() { Id = id, UserName = username, Name = name, Email = email };
			_userServices.UpdateUser(newUser);
			return "value";
		}
		[HttpGet("api/users/createUser/{Id}/{name}/{email}/{username}")]
		public ActionResult<string> CreateUsers(int id,string name,string email,string username)
		{
			var newUser = new User() {Id = id, UserName = username, Name = name, Email = email};
			_userServices.CreateUser(newUser);
			return "Ok";
		}
		
	}
}
