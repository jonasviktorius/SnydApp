using System;
using System.Collections.Generic;

namespace Snyd
{
	public class Person
	{
		public int PersonId { get; set; }

		public string Name { get; set; }

		public Cup Cup { get; set; }

		public List<Game> PreviousGames { get; set; }
	}
}
