using Buisness;
using DI_Commun.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Services
{
    public class RoleService : IRoleService
    {

        public List<Role> Roles = new List<Role>()
        {
            new Role() {Id = 1, Name = "Admin"},
            new Role() {Id = 2, Name = "Guest"}
        };

        public Role Add(Role role)
        {
            if (Roles.Find(r => r.Id == role.Id) == null)
            {
                Roles.Add(role);
                return role;
            }
            else
            {
                return null;
            }
        }

        public bool Delete(Role role)
        {
            if (Roles.Find(r => r.Id == role.Id) != null)
            {
                Roles.Remove(role);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Role> GetAll()
        {
            return Roles;
        }

        public Role GetById(int id)
        {
            return Roles.Find(r => r.Id == id);
        }

        public bool Update(Role role)
        {
            if (Roles.Find(r => r.Id == role.Id) != null)
            {
                Roles.Remove(Roles.Find(r => r.Id == role.Id));
                Roles.Add(role);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
