using Microsoft.EntityFrameworkCore;
using PC_helper.Data.Models;
using PC_helper.Data.Repositories.Interfaces;

namespace PC_helper.Data.Repositories
{
	public class MotherboardRepository : IMotherboardRepository
	{
		private readonly DataContext _context;

		public MotherboardRepository(DataContext context)
		{
			_context = context;
		}


		public async Task<Motherboard> GetMotherboardByTier(int tier)
		{
			var motherboard = await _context.Motherboards.Where(x => x.Tier == tier).FirstOrDefaultAsync();
			return motherboard;
			
		}

	}
}
