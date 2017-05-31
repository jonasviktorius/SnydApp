using System;
using System.Collections.Generic;

namespace Snyd
{
	public class Game
	{
		public int GameId { get; set; }

		public List<Person> Participants { get; set; }

		public int RoundNumber { get; set; }
	}
}
