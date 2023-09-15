using PC_helper.Data.Models;

namespace PC_helper.Data.Repositories.Interfaces
{
	public interface IGPURepository
	{
		Task<IEnumerable<GPU>> GetAll();
		Task<GPU> GetGPUByTierAndBrand(int tier, string brand);
	}
}