using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventWalkthrough
{
    public partial class FormEventSender : Form
    {
        SportsTeam mTeam = new SportsTeam();
        Random mRandom = new Random();

        public FormEventSender()
        {
            InitializeComponent();
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            mTeam.WinOneGame();
        }

        private void btnLose_Click(object sender, EventArgs e)
        {
            mTeam.LoseOneGame();
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
        }

        private void btnListener_Click(object sender, EventArgs e)
        {
            new FormEventListener(mTeam).Show();
        }
    }
}
