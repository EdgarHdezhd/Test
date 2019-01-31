using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Services
{
	public interface IUser
	{
		List<User> GetUsers();
		User GetUser(int id);
		bool CreateUser(User user);
		void UpdateUser(User user);
		void DeleteUser(int user);

	}
}
