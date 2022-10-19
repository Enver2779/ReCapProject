﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _userService.GetAll();
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("GetbyId")]
        public IActionResult GetbyId(int id)
        {

            var result = _userService.GetbyId(id);
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
    }
}
