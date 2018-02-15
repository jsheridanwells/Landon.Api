﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace Landon.Api.Controllers
{
    [Route("/")]
    [ApiVersion("1.0")]
    public class RootController : Controller
    {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null)
            };
            return Ok(response);
        }
    }
}   
