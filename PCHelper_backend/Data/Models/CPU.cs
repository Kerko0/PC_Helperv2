using System.ComponentModel.DataAnnotations;

namespace PC_helper.Data.Models
{
	public class CPU
	{
		[Key]

        public int Tier { get; set; }
        public string Name { get; set; }
		public string Brand { get; set; }
		public decimal Price { get; set; }
	}
}
