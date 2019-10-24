using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Domain
{
	public class Chat : Entity
	{
		public ICollection<User> Users { get; set; }
		public ICollection<Message> Messages { get; set; }
	}
}
