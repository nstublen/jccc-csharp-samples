using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWalkthrough
{
    // Step 1b: We need to define a class with the event arguments.

    // Step 3b: We need to define a "delegate" type.

    public class SportsTeam
    {
        private uint mWins;
        private uint mLosses;

        // Constructors for the SportsTeam class

        public SportsTeam()
        {
        }

        public SportsTeam(uint inWins, uint inLosses, int inStreak)
        {
            Wins = inWins;
            Losses = inLosses;
        }

        // Properties for the SportsTeam class

        public uint GamesPlayed
        {
            get { return Wins + Losses; }
        }

        public uint Losses
        {
            get { return mLosses; }
            private set
            {
                mLosses = value;

                // Step 1a: We need to pass some arguments with our event (RecordChangedEventArgs).
                // Step 2a: We need an "event" to trigger (RecordChanged).
                // Step 3a: We need to define a "delegate" as a pattern for the event listeners (RecordChangedEventHandler).
                // Step 4: We need to trigger the event if there are any listeners.
                // Step 5: We also need to trigger the event when "Wins" changes.
            }
        }

        public uint Wins
        {
            get { return mWins; }
            private set
            {
                mWins = value;
            }
        }

        public double WinPercentage
        {
            get { return (GamesPlayed != 0) ? (double)Wins / GamesPlayed : 0; }
        }

        // Methods for the SportsTeam class

        public void LoseOneGame()
        {
            Losses++;
        }

        public void Reset()
        {
            Wins = 0;
            Losses = 0;
        }

        public void WinOneGame()
        {
            Wins++;
        }

        // Events for the SportsTeam class

        // Step 2b: We need to define an "event".
    }
}
