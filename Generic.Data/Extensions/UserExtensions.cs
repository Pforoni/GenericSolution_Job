using Generic.Data.Repositories;
using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Extensions
{
    public static class UserExtensions
    {
        public static User GetSingleByUsername(this IEntityBaseRepository<DoctorUser> userRepository, string username)
        {
            //var a = userRepository.GetAll().OfType<DoctorUser>
            return userRepository.GetAll().FirstOrDefault(x => x.Username == username);
        }
    }
}
