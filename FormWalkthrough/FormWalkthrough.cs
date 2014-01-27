using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormWalkthrough
{
    public partial class FormWalkthrough : Form
    {
        SportsTeam mTeam = new SportsTeam();
        Random mRandom = new Random();

        public FormWalkthrough()
        {
            InitializeComponent();
        }

        private void UpdateStats()
        {
            lblWins.Text = mTeam.Wins.ToString();
            lblLosses.Text = mTeam.Losses.ToString();
            lblPercentage.Text = mTeam.WinPercentage.ToString("f3");
            if (mTeam.Streak == 0)
            {
                lblStreak.Text = "-";
            }
            else
            {
                lblStreak.Text = String.Format("{0}{1}", mTeam.Streak > 0 ? 'W' : 'L', Math.Abs(mTeam.Streak).ToString());
            }
        }

        private void FormWalkthrough_Load(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            mTeam.WinOneGame();
            UpdateStats();
        }

        private void btnLose_Click(object sender, EventArgs e)
        {
            mTeam.LoseOneGame();
            UpdateStats();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < 1000; ++index)
            {
                if (mRandom.Next(0, 10) > 3)
                {
                    btnWin_Click(sender, e);
                }
                else
                {
                    btnLose_Click(sender, e);
                }
                Update();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mTeam.Reset();
            UpdateStats();
        }
    }
}
