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
            // Step 7: We need to become a listener.

            lblWins.Text = mTeam.Wins.ToString();
            lblLosses.Text = mTeam.Losses.ToString();
        }

        // Step 6: We need a method to handle events
    }
}
