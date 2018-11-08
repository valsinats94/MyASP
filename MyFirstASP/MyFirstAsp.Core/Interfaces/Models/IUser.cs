using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAsp.Core.Interfaces.Models
{
    public interface IUser
    {
        int Id { get; set; }

        string Name { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

        string Password { get; set; }

        string Email { get; set; }

        string PersonalNumber { get; set; }
    }
}
