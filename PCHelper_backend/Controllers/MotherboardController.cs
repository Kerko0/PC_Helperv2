using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PC_helper.Data.Repositories.Interfaces;
using PC_helper.Data.Models;

namespace PC_helper.Controllers
{

	[Microsoft.AspNetCore.Mvc.Route("Mobo")]
	[ApiController]
	public class MotherboardController : ControllerBase
	{
		private readonly IMotherboardRepository _motherboardRepository;

		public MotherboardController(IMotherboardRepository motherboardRepository)
		{
			_motherboardRepository = motherboardRepository;
		}

		[HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Motherboard>>> GetAll()
        {
            var mobos = await _motherboardRepository.GetAll();
            return Ok(mobos);
        }


        [HttpGet("{tier:int}")]
		public async Task<ActionResult<Motherboard>> GetMotherboardByTier(int tier)
		{
			var mobo = await _motherboardRepository.GetMotherboardByTier(tier);
			return Ok(mobo);
		}

        [HttpPost("add")]
        public async Task<ActionResult> AddMotherboards(List<Motherboard> mobos)
        {
            await _motherboardRepository.AddMotherboards(mobos);
            return Ok();
        }

        [HttpDelete("all")]

        public async Task<ActionResult> DeleteAll()
        {
            await _motherboardRepository.DeleteAll();
            return Ok();
        }
    }
}
