using BlogMvcApp.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //roles
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole()
                {
                    Name="admin",
                    Description="admin role"
                };
                manager.Create(role);

            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole()
                {
                    Name = "user",
                    Description = "user role"
                };
                manager.Create(role);
            }
            //users
            if (!context.Users.Any(i => i.Name == "emrebatukan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "emre",
                    Surname = "batukan",
                    UserName = "emrebatukan",
                    Email = "batukan0emre@gmail.com",
                };
                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "admin");
            }
            if (!context.Users.Any(i => i.Name == "alibaba"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "ali",
                    Surname = "baba",
                    UserName = "alibaba",
                    Email = "alibaba@gmail.com",
                };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }
            base.Seed(context);
        }
    }
}