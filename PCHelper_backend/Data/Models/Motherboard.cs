using System.ComponentModel.DataAnnotations;

namespace PC_helper.Data.Models
{
	public class Motherboard
	{
		[Key]

        public int Tier { get; set; }
        public string Name { get; set; }

		public int RAM { get; set; }

		public decimal Price { get; set; }
	}
}
