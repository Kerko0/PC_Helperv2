﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PC_helper.Data.Repositories.Interfaces;
using PC_helper.Data.Models;
using PC_helper.Controllers;

namespace PC_helper.Server.Controllers
{

	[Microsoft.AspNetCore.Mvc.Route("RAM")]
	[ApiController]
	public class RAMController : ControllerBase
	{
		private readonly IRAMRepository _ramRepository;

		public RAMController(IRAMRepository ramRepository)
		{
			_ramRepository = ramRepository;
		}

		[HttpGet("all")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]

		public async Task<ActionResult<IEnumerable<RAM>>> GetAll()
		{
			var rams = await _ramRepository.GetAll();
			return Ok(rams);
		}
	}
}
