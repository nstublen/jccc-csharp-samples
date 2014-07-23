using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebuggingWalkthrough
{
    public partial class FormDebugging : Form
    {
        private int mClickCount = 0;

        public FormDebugging()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            string clickLocalVariable = "Click Again";

            mClickCount++;
            clickProcessing();

            btnClickMe.Text = clickLocalVariable;
        }

        private void clickProcessing()
        {
            double processLocalVariable = 5.6;
            this.Tag = processLocalVariable;

            if (mClickCount % 2 == 0)
            {
                Console.WriteLine("We're going to break...");
                breakExecution();
            }
            else
            {
                Console.WriteLine("We're NOT going to break...");
            }
        }

        private void breakExecution()
        {
            // When the debugger breaks, you can examine
            // local variables, watch class variables,
            // examine the call stack, etc.
            System.Diagnostics.Debugger.Break();
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            try
            {
                doSomethingBad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void doSomethingBad()
        {
            throw new NotImplementedException();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int safe = 1;
            int notSafe = 0;

            double result = divide(5, notSafe);
            Console.WriteLine(result);
        }

        private double divide(int inDividend, int inDivisor)
        {
            //Debug.Assert(inDivisor != 0);
            return inDividend / inDivisor;
        }
    }
}
