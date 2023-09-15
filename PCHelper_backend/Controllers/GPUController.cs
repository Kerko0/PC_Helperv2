using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PC_helper.Data.Repositories.Interfaces;
using PC_helper.Data.Models;

namespace PC_helper.Controllers
{

	[Microsoft.AspNetCore.Mvc.Route("GPU")]
	[ApiController]
	public class GPUController : ControllerBase
	{
		private readonly IGPURepository _gpuRepository;

		public GPUController(IGPURepository gpuRepository)
		{
			_gpuRepository = gpuRepository;
		}

		[HttpGet("all")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<GPU>>> GetAll()
		{
			var gpus = await _gpuRepository.GetAll();
			return Ok(gpus);
		}

		[HttpGet("{tier:int}/{brand}")]
		public async Task<ActionResult<GPU>> GetGPUByTierAndBrand(int tier, string brand)
		{
			var gpu = await _gpuRepository.GetGPUByTierAndBrand(tier, brand); 
			return Ok(gpu);
		}
	}
}
