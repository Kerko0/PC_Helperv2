using PC_helper.Data.Models;

namespace PC_helper.Data.Repositories.Interfaces
{
	public interface IRAMRepository
	{
		Task<IEnumerable<RAM>> GetAll();
	}
}
