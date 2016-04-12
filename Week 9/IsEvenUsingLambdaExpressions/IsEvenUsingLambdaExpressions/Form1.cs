using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsEvenUsingLambdaExpressions
{
    public partial class Form1 : Form
    {
       List<int> randomNumbers;
        public Form1()
        {
            InitializeComponent();

            randomNumbers = new List<int>();
        }

        private void generateRandoms_Click(object sender, EventArgs e)
        {
            randomNumbers.Clear();
            listBox1.Items.Clear();
            Random randNumbers = new Random();
            for(int i = 0; i < 100; i++)
            {
                randomNumbers.Add(randNumbers.Next(100));
            }

            foreach(int currentInt in randomNumbers)
            {
                listBox1.Items.Add(currentInt.ToString());
            }
        }

        private void selectEvens_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            List<int> evens = randomNumbers.FindAll((x) => x % 2 == 0);
            foreach (int currentInt in evens)
            {
                listBox2.Items.Add(currentInt);
            }
        }

        private void selectLessThan10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            List<int> lessThanTen = randomNumbers.FindAll((x) => x < 10);
            foreach (int currentInt in lessThanTen)
            {
                listBox2.Items.Add(currentInt);
            }
        }
    }
}
