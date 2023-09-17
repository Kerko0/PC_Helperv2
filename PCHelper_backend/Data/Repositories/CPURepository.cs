using Microsoft.EntityFrameworkCore;
using PC_helper.Data.Models;
using PC_helper.Data.Repositories.Interfaces;

namespace PC_helper.Data.Repositories
{
	public class CPURepository : ICPURepository
	{
		private readonly DataContext _context;

		public CPURepository(DataContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<CPU>> GetAll()
		{
			return await _context.CPUs.Select(x => new CPU
			{
				Name = x.Name,
				Tier = x.Tier,
				Brand = x.Brand,
				Price = x.Price,
			}).ToListAsync();
		}

		public async Task<CPU> GetCPUByTier(int tier)
		{
			var cpu = await _context.CPUs.Where(x => x.Tier == tier).FirstOrDefaultAsync();
			return cpu;
			
		}

		public Task<string> AddCPUs(List<CPU> cpus)
		{
			_context.CPUs.AddRange(cpus);
			_context.SaveChanges();

			return Task.FromResult("CPUs Added!");		
		}

		public Task<string> DeleteAll()
		{
			for (int i = 1; i < 4; i++)
			{
				_context.CPUs.Where(x => x.Tier == i).ExecuteDelete();
			}

			_context.SaveChanges();

			return Task.FromResult("Deleted all CPUs");
		}
	}
}
