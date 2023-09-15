using System.ComponentModel.DataAnnotations;

namespace PC_helper.Data.Models
{
	public class CPU
	{
		[Key]
		public string Name { get; set; }
		public string Brand { get; set; }
		public int Tier { get; set; }

		public decimal Price { get; set; }
	}
}
