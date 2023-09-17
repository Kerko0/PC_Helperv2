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

        public Task<string> AddRAM(List<RAM> rams)
        {
            _context.RAMs.AddRange(rams);
            _context.SaveChanges();

            return Task.FromResult("RAM Added!");
        }

        public Task<string> DeleteAll()
        {
            for (int i = 1; i < 4; i++)
            {
                _context.RAMs.Where(x => x.Id == i).ExecuteDelete();
            }

            _context.SaveChanges();

            return Task.FromResult("Deleted all RAM");
        }

    }
}
