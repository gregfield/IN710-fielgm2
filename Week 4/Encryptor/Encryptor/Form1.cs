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
            Encryptor newEncryption = new Encryptor();
            string input = InputTextBox.Text;
            //checks there is something to encrypt
            if (input != "")
            {
                //if rot13
                if (rdbtnROT13.Checked)
                {
                    newEncryption.encryption = new ROT13Encryptor();
                    OutputTextBox.Text = newEncryption.EncryptInputText(input);

                }
                //if reverse string
                else if (rdbtnReverse.Checked)
                {
                    newEncryption.encryption = new ReverseString();
                    OutputTextBox.Text = newEncryption.EncryptInputText(input);
                }
                //if neither selected
                else
                {
                    MessageBox.Show("Please select an encryption type!");

                }
            }
            else
            {
                MessageBox.Show("Please enter text to encrypt!");
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            Encryptor newDecryption = new Encryptor();
            string input = InputTextBox.Text;
            //checks there is something to encrypt
            if (input != "")
            {
                //if rot13
                if (rdbtnROT13.Checked)
                {
                    newDecryption.encryption = new ROT13Encryptor();
                    OutputTextBox.Text = newDecryption.DecryptInputText(input);

                }
                //if reverse string
                else if (rdbtnReverse.Checked)
                {
                    newDecryption.encryption = new ReverseString();
                    OutputTextBox.Text = newDecryption.DecryptInputText(input);
                }
                //if neither selected
                else
                {
                    MessageBox.Show("Please select an encryption type!");

                }
            }
            else
            {
                MessageBox.Show("Please enter text to Decrypt!");
            }
        }
    }
}
