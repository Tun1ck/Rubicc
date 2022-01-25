using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rubic.DbContext;
using Rubic.Models.Dto;

namespace Rubic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public MoneyBotContext _context;
        public UsersController(MoneyBotContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult Register(UserIdentity userIdentity)
        {
            
        }
    }
}
