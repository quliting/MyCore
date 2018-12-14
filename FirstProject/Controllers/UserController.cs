using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.EntityFrameworkCore;
using FirstProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstProject.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : BaseController
    {
        private UserContext _userContext;
        private ILogger<UserController> _logger;
        public UserController(UserContext userContext,ILogger<UserController> logger)
        {
            _userContext = userContext;
            _logger = logger;
        }

        [Route("/url")]
        [HttpGet]
        public string GetUrl()
        {
            return "234234";
        }
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var user = _userContext.AppUsers.AsNoTracking().Include(item => item.Properties)
                .SingleOrDefaultAsync(item => item.Id == UserIdentity.UserId);

            if (user == null)
            {
                throw new UserOperationException("用户ID查询失败！");
            }
            return new JsonResult(user);
        }

        [Route("")]
        [HttpPatch]
        public async Task<IActionResult> Path()
        {
            return new JsonResult(new
            {
                message = "welcome to gitlab ci build",
                user = await _userContext.AppUsers.SingleOrDefaultAsync(item => item.Name == "quliting")
            });
        }
    }
}
