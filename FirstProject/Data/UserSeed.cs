using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FirstProject.Data
{
    public class UserSeed
    {
        private ILogger<UserSeed> _logger;

        public UserSeed(ILogger<UserSeed> logger)
        {
            _logger = logger;
        }

        public static async Task SeedAsync(IApplicationBuilder applicationBuilder, ILoggerFactory loggerFactory, int? retry = 0)
        {
            var retryForAvaiability = retry.Value;

            try
            {
                using (var scope = applicationBuilder.ApplicationServices.CreateScope())
                {
                    var context = (UserContext)scope.ServiceProvider.GetService(typeof(UserContext));

                    var logger = (ILogger<UserSeed>)scope.ServiceProvider.GetService(typeof(ILogger<UserSeed>));
                    logger.LogDebug("Begin UserSeed SeedAsync");

                    context.Database.Migrate();

                    if (!context.AppUsers.Any())
                    {
                        context.AppUsers.Add(new AppUser() { Name = "quliting" });
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                if (retryForAvaiability <= 10)
                {
                    retryForAvaiability++;

                    var logger = loggerFactory.CreateLogger(typeof(UserSeed));
                    await SeedAsync(applicationBuilder, loggerFactory, retryForAvaiability);
                }
            }
        }
    }
}
