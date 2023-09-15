using System.ComponentModel.DataAnnotations;

namespace PC_helper.Data.Models
{
	public class RAM
	{
		[Key]

		public int Id { get; set; }

		public int Capacity { get; set; }

		public int Type { get; set; }

		public decimal Price { get; set; }

	}
}
