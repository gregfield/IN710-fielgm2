using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            //checks there is something to encrypt
            if (input != "")
            {
                //if rot13
                if (rdbtnROT13.Checked)
                {
                    ROT13Encryptor encryptor = new ROT13Encryptor();
                    OutputTextBox.Text = encryptor.EncryptString(input);
                }
                //if reverse string
                else if (rdbtnReverse.Checked)
                {
                    ReverseString encryptor = new ReverseString();
                    OutputTextBox.Text = encryptor.EncryptString(input);
                }
                //if neither selected
                else
                {
                    MessageBox.Show("Please select an encryption type!");

                }
            }
            else
            {
                MessageBox.Show("Please enter text to convert!");
            }
        }
    }
}
