﻿using PC_helper.Data.Models;

namespace PC_helper.Data.Repositories.Interfaces
{
	public interface IMotherboardRepository
	{
		Task<Motherboard> GetMotherboardByTier(int tier);
	}
}
