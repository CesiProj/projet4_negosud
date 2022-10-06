using DI_Commun.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Commun.Model
{
    public class User: Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private string _password;
        public string? Phone { get; set; }
        //public Address Address { get; set; }
        public Role Role { get; set; }
        public string IgnoreMe { get; set; }

        public User(
            int Id,
            string Name
        ) : this(Id, Name, null, null, null, null)
        {}

        public User(
            int Id,
            string Name,
            string Email
        ) : this(Id, Name, Email, null, null, null)
        {}
        
        public User (
            int Id,
            string Name,
            string Email,
            string Password,
            string Phone,
            //Address Address,
            Role Role
        )
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this._password = Password;
            this.Phone = Phone;
            //this.Address = Address;
            this.Role = Role;
        } 
    }
}
