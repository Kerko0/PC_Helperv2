using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_helper.Shared.Models
{
	public class PC
	{
		public CPU cpu { get; set; }
		public GPU gpu { get; set; }
		public Motherboard motherboard { get; set; }
		public RAM RAM { get; set; }
	}
}
