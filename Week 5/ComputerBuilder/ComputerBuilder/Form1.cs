using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public partial class Form1 : Form
    {
        IComponentFactory newMachine;
        public Form1()
        {
            InitializeComponent();
        }

        private void printSpecsBtn_Click(object sender, EventArgs e)
        {
            if(businessRbtn.Checked)
            {
                newMachine = new BusinessComputerFactory();
            }
            else if(MultiRbtn.Checked)
            {
                newMachine = new MultimediaComputerFactory();
            }
            else
            {
                newMachine = new GamingComputerFactory();
            }

            SpecPrinter currSpecPrinter = new SpecPrinter(newMachine, displaySpecBox);
            currSpecPrinter.printSpec();
        }
    }
}
