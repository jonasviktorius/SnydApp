using System;
using System.Collections.Generic;

namespace Snyd
{
	public class Game
	{
        public int GameId { get; set; }

        public IEnumerable<Person> Participants { get; set; }

        public int RoundNumber { get; set; }

        public bool IsOngoing { get; set; }

        public bool IsActive { get; set; }


        public Game(IEnumerable<Person> participants, int roundNumber, bool isOngoing, bool isActive)
        {
            Participants = participants;
            RoundNumber = roundNumber;
            IsOngoing = isOngoing;
            IsActive = isActive;
        }

        public override string ToString()
        {
            return $"Participants: {Participants}, RoundNumber: {RoundNumber}, IsOngoing: {IsOngoing}, IsActive: {IsActive}";
        }
    }
}
