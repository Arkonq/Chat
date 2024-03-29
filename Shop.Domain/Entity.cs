﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Domain
{
	public abstract class Entity
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public DateTime CreationDate { get; set; } = DateTime.Now;
	}
}
