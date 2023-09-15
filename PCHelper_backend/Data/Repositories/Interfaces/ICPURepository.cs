using PC_helper.Data.Models;

namespace PC_helper.Data.Repositories.Interfaces
{
	public interface ICPURepository
	{
		Task<IEnumerable<CPU>> GetAll();
		Task<CPU> GetCPUByTier(int tier);
	}
}
