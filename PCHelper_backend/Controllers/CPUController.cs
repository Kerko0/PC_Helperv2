using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PC_helper.Data.Repositories.Interfaces;
using PC_helper.Data.Models;

namespace PC_helper.Controllers
{

	[Microsoft.AspNetCore.Mvc.Route("CPU")]
	[ApiController]
	public class CPUController : ControllerBase
	{
		private readonly ICPURepository _cpuRepository;

		public CPUController(ICPURepository cpuRepository)
		{
			_cpuRepository = cpuRepository;
		}

		[HttpGet("all")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<CPU>>> GetAll()
		{
			var cpus = await _cpuRepository.GetAll();
			return Ok(cpus);
		}

		[HttpGet("{tier:int}")]
		public async Task<ActionResult<GPU>> GetGPUByTier(int tier)
		{
			var cpu = await _cpuRepository.GetCPUByTier(tier);
			return Ok(cpu);
		}
	}
}
