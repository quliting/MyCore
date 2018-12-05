using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class BaseController : ControllerBase
    {
        protected UserIdentity UserIdentity => new UserIdentity() { UserId = 1, Name = "quliting" };

    }
}
