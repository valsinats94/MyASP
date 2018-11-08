using MyFirstAsp.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAsp.Database.Models
{
    public class User : IUser
    {
        public int Id { get; set; }
         
        public string Name { get; set; }
         
        public string LastName { get; set; }
         
        public int Age { get; set; }
         
        public string Password { get; set; }
         
        public string Email { get; set; }
         
        public string PersonalNumber { get; set; }

        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   Id == user.Id &&
                   PersonalNumber == user.PersonalNumber;
        }

        public override int GetHashCode()
        {
            var hashCode = 1898947492;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PersonalNumber);
            return hashCode;
        }
    }
}
