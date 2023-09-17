using PC_helper.Data.Models;

namespace PC_helper.Data.Repositories.Interfaces
{
	public interface IMotherboardRepository
	{
		Task<IEnumerable<Motherboard>> GetAll();
		Task<Motherboard> GetMotherboardByTier(int tier);

		Task<string> AddMotherboards(List<Motherboard> mobos);

		Task<string> DeleteAll();
	}
}
