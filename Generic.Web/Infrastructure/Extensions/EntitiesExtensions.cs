using Generic.Entities;
using Generic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Generic.Web.Infrastructure.Extensions
{
    public static class EntitiesExtensions
    {
        public static void UpdateUser(this User user, RegistrationViewModel userVm)
        {
            user.DateNasc = userVm.DateNasc;
            user.CPF = userVm.CPF;
            user.RG = userVm.RG;
            user.Naturalidade = userVm.Naturalidade;
            
        }

    }
}