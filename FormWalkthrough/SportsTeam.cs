using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormWalkthrough
{
    class SportsTeam
    {
        private uint mWins;
        private uint mLosses;
        private int mStreak;

        // Constructors for the Team class

        public SportsTeam()
        {
            System.Diagnostics.Debug.WriteLine("==> SportsTeam.SportsTeam()");
            System.Diagnostics.Debug.Indent();

            System.Diagnostics.Debug.WriteLine("- using field default values");

            System.Diagnostics.Debug.Unindent();
        }

        public SportsTeam(uint inWins, uint inLosses, int inStreak)
        {
            System.Diagnostics.Debug.WriteLine(String.Format("==> SportsTeam.SportsTeam({0}, {1})", inWins, inLosses));
            System.Diagnostics.Debug.Indent();

            Wins = inWins;
            Losses = inLosses;
            mStreak = inStreak;

            System.Diagnostics.Debug.Unindent();
        }

        // Properties for the Team class

        public uint GamesPlayed
        {
            get
            {
                System.Diagnostics.Debug.WriteLine("==> SportsTeam.GamesPlayed.get");
                System.Diagnostics.Debug.Indent();

                uint result = Wins + Losses;

                System.Diagnostics.Debug.Unindent();
                return result;
            }
        }

        public uint Losses
        {
            get
            {
                System.Diagnostics.Debug.WriteLine("==> SportsTeam.Losses.get");
                System.Diagnostics.Debug.Indent();

                uint result = mLosses;

                System.Diagnostics.Debug.Unindent();
                return result;
            }
            private set
            {
                System.Diagnostics.Debug.WriteLine("==> SportsTeam.Losses.set");
                System.Diagnostics.Debug.Indent();

                mLosses = value;

                System.Diagnostics.Debug.Unindent();
            }
        }

        public int Streak
        {
            get
            {
                System.Diagnostics.Debug.WriteLine("==> SportsTeam.Wins.get");
                System.Diagnostics.Debug.Indent();

                int result = mStreak;

                System.Diagnostics.Debug.Unindent();
                return result;
            }
        }

        public uint Wins
        {
            get
            {
                System.Diagnostics.Debug.WriteLine("==> SportsTeam.Wins.get");
                System.Diagnostics.Debug.Indent();

                uint result = mWins;

                System.Diagnostics.Debug.Unindent();
                return result;
            }
            private set
            {
                System.Diagnostics.Debug.WriteLine("==> SportsTeam.Wins.set");
                System.Diagnostics.Debug.Indent();

                mWins = value;

                System.Diagnostics.Debug.Unindent();
            }
        }

        public double WinPercentage
        {
            get
            {
                System.Diagnostics.Debug.WriteLine("==> SportsTeam.WinPercentage");
                System.Diagnostics.Debug.Indent();

                double result = (GamesPlayed != 0) ? (double)Wins / GamesPlayed : 0;

                System.Diagnostics.Debug.Unindent();
                return result;
            }
        }

        // Methods for the Team class

        public void LoseOneGame()
        {
            System.Diagnostics.Debug.WriteLine("==> SportsTeam.LoseOneGame");
            System.Diagnostics.Debug.Indent();

            Losses++;
            if (Streak > 0)
            {
                mStreak = -1;
            }
            else
            {
                mStreak--;
            }

            System.Diagnostics.Debug.Unindent();
        }

        public void Reset()
        {
            Wins = 0;
            Losses = 0;
            mStreak = 0;
        }

        public void WinOneGame()
        {
            System.Diagnostics.Debug.WriteLine("==> SportsTeam.WinOneGame");
            System.Diagnostics.Debug.Indent();

            Wins++;
            if (Streak < 0)
            {
                mStreak = 1;
            }
            else
            {
                mStreak++;
            }

            System.Diagnostics.Debug.Unindent();
        }
    }
}
