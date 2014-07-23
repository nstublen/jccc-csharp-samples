using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSorter
{
    public partial class FormNumberSorter : Form
    {
        public FormNumberSorter()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string numberList = txtNumbers.Text.Trim(',', ' ');

            string[] split = numberList.Split(',');

            List<int> numbers = new List<int>();
            foreach (string item in split)
            {
                numbers.Add(int.Parse(item.Trim()));
            }
            numbers.Sort();

            string allNumbers = "";
            foreach (int number in numbers)
            {
                allNumbers += number.ToString() + "\r\n";
            }
            txtSortedNumbers.Text = allNumbers;
        }
    }
}
