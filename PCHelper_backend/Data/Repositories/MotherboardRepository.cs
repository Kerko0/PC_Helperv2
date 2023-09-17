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

        public async Task<IEnumerable<Motherboard>> GetAll()
        {
            return await _context.Motherboards.Select(x => new Motherboard
            {
                Name = x.Name,
                Tier = x.Tier,
                Price = x.Price,
                RAM = x.RAM,

            }).ToListAsync();
        }
		public async Task<Motherboard> GetMotherboardByTier(int tier)
		{
			var motherboard = await _context.Motherboards.Where(x => x.Tier == tier).FirstOrDefaultAsync();
			return motherboard;
			
		}

        public Task<string> AddMotherboards(List<Motherboard> mobos)
        {
            _context.Motherboards.AddRange(mobos);
            _context.SaveChanges();

            return Task.FromResult("Motherboards Added!");
        }

        public Task<string> DeleteAll()
        {
            for (int i = 1; i < 4; i++)
            {
                _context.Motherboards.Where(x => x.Tier == i).ExecuteDelete();
            }

            _context.SaveChanges();

            return Task.FromResult("Deleted all Motherboards");
        }

    }
}
