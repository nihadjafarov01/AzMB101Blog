﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Twitter.Business.Dtos.AuthDtos;
using Twitter.Business.Services.Interfaces;

namespace Twitter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService { get; }
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterDto dto)
        {
            await _userService.CreateAsync(dto);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetAll());
        }
    }
}
