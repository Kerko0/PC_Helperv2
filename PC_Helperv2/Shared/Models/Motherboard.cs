﻿using System.ComponentModel.DataAnnotations;

namespace PC_helper.Shared.Models
{
	public class Motherboard
	{
		[Key]
		public string Name { get; set; }

		public int Tier { get; set; }

		public int RAM { get; set; }

		public decimal Price { get; set; }
	}
}
