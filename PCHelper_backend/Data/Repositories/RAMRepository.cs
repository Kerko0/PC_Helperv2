using Microsoft.EntityFrameworkCore;
using PC_helper.Data.Models;
using PC_helper.Data.Repositories.Interfaces;

namespace PC_helper.Data.Repositories
{
	public class RAMRepository : IRAMRepository
	{
		private readonly DataContext _context;

		public RAMRepository(DataContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<RAM>> GetAll()
		{
			return await _context.RAMs.Select(x => new RAM
			{
				Capacity = x.Capacity,
				Type = x.Type,
				Price = x.Price
			}).ToListAsync();
		}

	}
}
