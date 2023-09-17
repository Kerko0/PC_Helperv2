using Microsoft.EntityFrameworkCore;
using PC_helper.Data.Models;
using PC_helper.Data.Repositories.Interfaces;

namespace PC_helper.Data.Repositories
{
	public class GPURepository : IGPURepository
	{
		private readonly DataContext _context;

		public GPURepository(DataContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<GPU>> GetAll()
		{
			return await _context.GPUs.Select(x => new GPU
			{
				Name = x.Name,
				Tier = x.Tier,
				Brand =x.Brand,
				Price =x.Price,

			}).ToListAsync();
		}

		public async Task<GPU> GetGPUByTierAndBrand(int tier, string brand)
		{
			var gpusByTier = await _context.GPUs.Where(x => x.Tier == tier).ToListAsync();
			var gpu = gpusByTier.Where(x => x.Brand == brand).FirstOrDefault();
			return gpu;

		}

        public Task<string> AddGPUs(List<GPU> gpus)
        {
            _context.GPUs.AddRange(gpus);
            _context.SaveChanges();

            return Task.FromResult("GPUs Added!");
        }

        public Task<string> DeleteAll()
        {
            for (int i = 1; i < 4; i++)
            {
                _context.GPUs.Where(x => x.Tier == i).ExecuteDelete();
            }

            _context.SaveChanges();

            return Task.FromResult("Deleted all GPUs");
        }

    }
}
