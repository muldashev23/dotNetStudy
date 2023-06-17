﻿using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{   
    [Authorize]
    public class UsersController: BaseApiController
    {   
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        [HttpGet] // GET http://loca....../api/users
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
        [HttpGet("{id}")] // GET http://loca....../api/users/{id}
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }
        [HttpPost] //Post http://loca....../api/users
        public ActionResult<AppUser> PostUser([FromBody]AppUser user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
    
}
