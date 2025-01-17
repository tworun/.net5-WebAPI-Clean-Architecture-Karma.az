﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class ShopCategory : BaseEntity, IEntity
	{
		public Shop Shop { get; set; }
		public Category Category { get; set; }
	}
}
