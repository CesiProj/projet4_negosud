using Buisness;
using DI_Commun.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Services
{
    public class UserService : IUserService
    {

        private IRoleService _roleService;

        public UserService(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public List<User> Users = new()
            {
                new User(1, "John Doe"),
                new User(2, "John Doe"),
                new User(3, "John Doe", "lol@jean.fr"),
                new User(4, "John Doe", "youpi@park.com"),

            };

        public User Add(User user)
        {
            // Add user to database
            if (Users.Find(u => u.Email == user.Email) == null)
            {
                Users.Add(user);
                return user;
            }
            return null;
        }

        public bool Update(User user)
        {
            // Update user in database
            if (Users.Find(u => u.Email == user.Email) != null)
            {
                Users.Find(u => u.Email == user.Email).Name = user.Name;
                Users.Find(u => u.Email == user.Email).Email = user.Email;
                Users.Find(u => u.Email == user.Email).Phone = user.Phone;
                //Users.Find(u => u.Email == user.Email).Address = user.Address;
                Users.Find(u => u.Email == user.Email).Role = user.Role;
                return true;
            }

            return false;
        }

        public bool Delete(User user)
        {
            // Delete user from database
            if (Users.Find(u => u.Id == user.Id) != null)
            {
                Users.Remove(user);
                return true;
            }
            return false;
        }

        public bool IfMailExists(string email)
        {
            // Check if email exists in database
            return GetAll().Any(u => u.Email == email);
        }

        public User GetById(int id)
        {
            // Get user from database
            return GetAll().Find(user => user.Id == id);
        }

        public List<User> GetAll()
        {
            return Users;
        }

        public bool AddRole(int userId, int roleId)
        {
            // Add role to user in database
            if (Users.Find(u => u.Id == userId) != null && _roleService.GetById(roleId) != null && Users.Find(u => u.Id == userId).Role == null)
            {
                Users.Find(u => u.Id == userId).Role = _roleService.GetById(roleId);
                return true;
            }
            return false;
        }
    }
}
