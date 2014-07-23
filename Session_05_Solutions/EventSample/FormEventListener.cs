using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCC.Samples.EventSample
{
    public partial class FormEventListener : Form
    {
        SportsTeam mTeam;

        public FormEventListener(SportsTeam inTeam)
        {
            InitializeComponent();

            mTeam = inTeam;
            mTeam.RecordChanged += new RecordChangedEventHandler(SportsTeam_RecordChangedEventHandler);

            lblWins.Text = mTeam.Wins.ToString();
            lblLosses.Text = mTeam.Losses.ToString();
        }

        private void SportsTeam_RecordChangedEventHandler(object sender, RecordChangedEventArgs e)
        {
            lblWins.Text = e.Wins.ToString();
            lblLosses.Text = e.Losses.ToString();
            Update();
        }
    }
}
