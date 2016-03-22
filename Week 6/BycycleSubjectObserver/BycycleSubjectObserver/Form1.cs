using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BycycleSubjectObserver
{
    public partial class Form1 : Form
    {
        BicycleSubject bikeSubject;
        RPMCalc rpm;
        CalorieCalc calorie;
        DistanceCalc dist;
        public Form1()
        {
            InitializeComponent();
            bikeSubject = new BicycleSubject(0);
            rpm = new RPMCalc(labelRPM, bikeSubject);
            calorie = new CalorieCalc(labelCalories, bikeSubject);
            dist = new DistanceCalc(labelDistance, bikeSubject);
        }

        private void changeRPMBtn_Click(object sender, EventArgs e)
        {
            bikeSubject.CurrentRPM = Int32.Parse(RPMTextBox.Text.ToString());
            bikeSubject.notifyObservers();
        }
    }
}
