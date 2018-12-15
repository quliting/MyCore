using FirstProject.Controllers;
using System;
using FirstProject.Data;
using FirstProject.Model;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace XUnitTestProject1
{
    public class UserControllerTest
    {
        private UserContext GetUserContext()
        {
            var option = new DbContextOptionsBuilder<UserContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var userContext = new UserContext(option);

            userContext.AppUsers.Add(new AppUser() { Id = 1, Name = "quliting" });
            userContext.SaveChanges();
            return userContext;
        }
        [Fact]
        public void Test1()
        {
           var context= GetUserContext();
            //var controller=new UserController();
        }
    }
}
