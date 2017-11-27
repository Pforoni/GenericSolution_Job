using Generic.Entities;
using GenericServices.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServices.Abstract
{
    public interface IMembershipService
    {
        MembershipContext ValidateUser(string username, string password);
        DoctorUser CreateUser(string username, string email, string password);
        User GetUser(Guid userId);
        List<Role> GetUserRoles(string username);
        List<DoctorUser> GetUsers();

        List<User> GetAllUsers();
    }
}
