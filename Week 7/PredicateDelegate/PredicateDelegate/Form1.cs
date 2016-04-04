using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateDelegate
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
            Predicate<int> isEvenPredicate = new Predicate<int>(isEven);

            List<int> evens = randomNumbers.FindAll(isEvenPredicate);
            foreach (int currentInt in evens)
            {
                listBox2.Items.Add(currentInt);
            }
        }

        private void selectLessThan10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Predicate<int> isLessThanTenPredicate = new Predicate<int>(isLessThan10);

            List<int> lessThanTen = randomNumbers.FindAll(isLessThanTenPredicate);
            foreach (int currentInt in lessThanTen)
            {
                listBox2.Items.Add(currentInt);
            }
        }

        private bool isEven(int inputInteger)
        {
            bool isAnEvenNumber = ((inputInteger % 2) == 0);
            return isAnEvenNumber;
        }

        private bool isLessThan10(int inputInteger)
        {
            bool isLessThan = false;
            if(inputInteger < 10)
            {
                isLessThan = true;
            }
            
            return isLessThan;
        }
    }
}
