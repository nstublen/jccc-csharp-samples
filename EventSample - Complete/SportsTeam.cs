using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWalkthrough
{
    public class RecordChangedEventArgs : EventArgs
    {
        public uint Wins;
        public uint Losses;
    }

    public delegate void RecordChangedEventHandler(object sender, RecordChangedEventArgs e);

    public class SportsTeam
    {
        private uint mWins;
        private uint mLosses;

        // Constructors for the Team class

        public SportsTeam()
        {
        }

        public SportsTeam(uint inWins, uint inLosses, int inStreak)
        {
            Wins = inWins;
            Losses = inLosses;
        }

        // Properties for the Team class

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
                if (RecordChanged != null)
                {
                    RecordChanged(this, new RecordChangedEventArgs() { Wins = mWins, Losses = mLosses });
                }
            }
        }

        public uint Wins
        {
            get { return mWins; }
            private set
            {
                mWins = value;
                if (RecordChanged != null)
                {
                    RecordChanged(this, new RecordChangedEventArgs() { Wins = mWins, Losses = mLosses });
                }
            }
        }

        public double WinPercentage
        {
            get { return (GamesPlayed != 0) ? (double)Wins / GamesPlayed : 0; }
        }

        // Methods for the Team class

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

        public event RecordChangedEventHandler RecordChanged;
    }
}
