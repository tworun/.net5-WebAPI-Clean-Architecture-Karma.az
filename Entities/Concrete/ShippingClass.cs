﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class ShippingClass : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Ammount { get; set; }
		public string IsGlobal { get; set; }
		public string Type { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
