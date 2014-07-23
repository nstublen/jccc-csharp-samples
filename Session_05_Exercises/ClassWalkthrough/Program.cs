using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClassWalkthrough
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Diagnostics.Debug.WriteLine("==> Program.Main");
            System.Diagnostics.Debug.Indent();

            System.Diagnostics.Debug.WriteLine("- Create team with default record");
            SportsTeam defaultRecord = new SportsTeam();

            System.Diagnostics.Debug.WriteLine("- Create team with initial record");
            SportsTeam initialRecord = new SportsTeam(5, 3);

            System.Diagnostics.Debug.WriteLine("- Create my team");
            SportsTeam myTeam = new SportsTeam();

            Random random = new Random();
            for (int index = 0; index < 5; ++index)
            {
                System.Diagnostics.Debug.WriteLine("- Determine a win or loss");
                if (random.Next(0, 10) > 3)
                {
                    myTeam.WinOneGame();
                }
                else
                {
                    myTeam.LoseOneGame();
                }

                System.Diagnostics.Debug.WriteLine("- Report new record");
                System.Diagnostics.Debug.WriteLine(String.Format("My team's record after {0} games is {1:f3}.", myTeam.GamesPlayed, myTeam.WinPercentage));
            }

            System.Diagnostics.Debug.Unindent();
        }
    }
}
