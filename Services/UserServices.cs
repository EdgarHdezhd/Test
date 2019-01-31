using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Services
{
	public class UserServices:IUser
	{

		public List<User> GetUsers()
		{
			//var newUser = new User {Id = 1, Name = "edgar", Email = "edgar@gmail.com", UserName = "edgarpapasito"};
			//Users.UsersList.Add(newUser);
			return Users.UsersList;
		}

		public User GetUser(int id)
		{
			return Users.UsersList.Find(i=>i.Id.Equals(id));
		}

		public bool CreateUser(User user)
		{
			Users.UsersList.Add(user);
			return true;
		}

		public void UpdateUser(User user)
		{
			var updateUser = Users.UsersList.FirstOrDefault(x => x.Id == user.Id);
			if (updateUser == null) return;
			updateUser.Name = user.Name;
			updateUser.Email = user.Email;
			updateUser.UserName = user.UserName;
		}

		public void DeleteUser(int user)
		{
			var itemToRemove = Users.UsersList.Single(i => i.Id == user);
			Users.UsersList.Remove(itemToRemove);
		}
	}
}
