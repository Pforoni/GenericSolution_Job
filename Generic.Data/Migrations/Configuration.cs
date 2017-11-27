namespace Generic.Data.Migrations
{
    using Generic.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    //public partial class Configuration : DbMigration
    internal sealed class Configuration : DbMigrationsConfiguration<GenericContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(GenericContext context)
        {
            context.RoleSet.AddOrUpdate(r => r.Name, GenerateRoles());
            
            var atleta = new AthleteUser()
            {
                Email = "paulo.foroni@gmail.com",
                Username = "paulo",
                HashedPassword = "XwAQoiq84p1RUzhAyPfaMDKVgSwnn80NCtsE8dNv3XI=",
                Salt = "mNKLRbEFCH8y1xIyTXP4qA==",
                IsLocked = false,
                DateCreated = DateTime.Now,
                DateNasc = DateTime.Now,
                CPF = "311311311-07",
                RG = "",
                Naturalidade = "",
                Tipo = 2,
                CRA = "AABB"
            };

            var doutor = new DoctorUser()
            {
                Email = "paulo.foroni@hotmail.com",
                Username = "foroni",
                HashedPassword = "XwAQoiq84p1RUzhAyPfaMDKVgSwnn80NCtsE8dNv3XI=",
                Salt = "mNKLRbEFCH8y1xIyTXP4qA==",
                IsLocked = false,
                DateCreated = DateTime.Now,
                DateNasc = DateTime.Now,
                CPF = "311311311-07",
                RG = "",
                Naturalidade = "",
                Tipo = 1,
                CRM = "CCDD"
            };

            context.UserSet.AddOrUpdate(atleta);
            context.UserSet.AddOrUpdate(doutor);

            // username: chsakell, password: homecinema
            //context.UserSet.AddOrUpdate(u => u.Email, new User[]{
            //    new User()
            //    {
            //        Email="paulo.foroni@gmail.com",
            //        Username="paulo",
            //        HashedPassword ="XwAQoiq84p1RUzhAyPfaMDKVgSwnn80NCtsE8dNv3XI=",
            //        Salt = "mNKLRbEFCH8y1xIyTXP4qA==",
            //        IsLocked = false,
            //        DateCreated = DateTime.Now,
            //        DateNasc = DateTime.Now,
            //        CPF = "311311311-07",
            //        RG = "",
            //        Naturalidade = "",
            //    }
            //});

            // // create user-admin for chsakell
            //context.UserRoleSet.AddOrUpdate(new UserRole[] {
            //    new UserRole() {
            //        RoleId = 1, // admin
            //        UserId = 1  // paulo
            //    }
            //});


        }
        private Role[] GenerateRoles()
        {
            Role[] _roles = new Role[]{
                new Role()
                {
                    Name="Admin"
                },
                new Role()
                {
                    Name="Atleta"
                }
            };

            return _roles;
        }
        
    }
}
