using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rubic.DbContext;
using Rubic.Models;
using Rubic.Models.Dto;

namespace Rubic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public IMapper _mapper;
        public MoneyBotContext _context;
<<<<<<< HEAD
        public UserController(MoneyBotContext context, IMapper mapper)
=======
        public UserController(MoneyBotContext context)
>>>>>>> 164a5fa87a697a2c2c8c03c6e8fcaeeffa1f364d
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("register")]
        public async Task<ActionResult> Register(UserIdentity userIdentity)
        {
            User user = new User()
            {
                PhoneNumberPrefix = userIdentity.PhoneNumberPrefix,
                PhoneNumber = userIdentity.PhoneNumber,
                Password = userIdentity.Password,
            };
            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPost("SingIn")]
        public async Task<ActionResult> SingIn(UserIdentity userIdentity)
        {
            User user = await _context.Users.FirstOrDefaultAsync(g => g.PhoneNumberPrefix == userIdentity.PhoneNumberPrefix
            && g.PhoneNumber == userIdentity.PhoneNumber
            && g.Password == userIdentity.Password
            );
            if (user == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpGet("Back")]
        public async Task<ActionResult> Back(UserIdentity userIdentity)
        {
            User user = await _context.Users.FirstOrDefaultAsync(g => g.PhoneNumberPrefix == userIdentity.PhoneNumberPrefix
            && g.PhoneNumber == userIdentity.PhoneNumber
            && g.Password == userIdentity.Password
            );
            if (user == null)
            {
                return NotFound();
            }
            return Ok();
        }
<<<<<<< HEAD
        [HttpGet("{userId}")]
        public async Task<ActionResult<UserInformationDto>> Get(int userId)
        {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (user == null) return NotFound();


            UserInformationDto userInformationDto =
                _mapper.Map<UserInformationDto>(user);
            return userInformationDto;
        }
    }
}
=======
        [HttpPost("register")]
        public async Task<ActionResult> Register(UserIdentity userIdentity)
        {
            User user = new User()
            {
                PhoneNumberPrefix = userIdentity.PhoneNumberPrefix,
                PhoneNumber = userIdentity.PhoneNumber,
                Password = userIdentity.Password,
            };
            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPost("SingIn")]
        public async Task<ActionResult> SingIn(UserIdentity userIdentity)
        {
            User user = await _context.Users.FirstOrDefaultAsync(g => g.PhoneNumberPrefix == userIdentity.PhoneNumberPrefix 
            && g.PhoneNumber == userIdentity.PhoneNumber
            && g.Password == userIdentity.Password
            );
            if (user == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpGet("Back")]
        public async Task<ActionResult> Back(UserIdentity userIdentity)
        {
            User user = await _context.Users.FirstOrDefaultAsync(g => g.PhoneNumberPrefix == userIdentity.PhoneNumberPrefix
            && g.PhoneNumber == userIdentity.PhoneNumber
            && g.Password == userIdentity.Password
            );
            if (user == null)
            {
                return NotFound();
            }
            return Ok();
        }
}
>>>>>>> 164a5fa87a697a2c2c8c03c6e8fcaeeffa1f364d
