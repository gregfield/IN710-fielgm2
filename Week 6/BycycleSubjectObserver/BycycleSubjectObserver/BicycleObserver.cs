using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BycycleSubjectObserver
{
    public abstract class BicycleObserver : IBicycleObserver
    {
        protected int currRpm;
        protected double currComputedValue;
        protected Label displayLabel;
        protected BicycleSubject bikeSubject;

        public BicycleObserver(Label displayLabel, BicycleSubject bikeSubject)
        {
            this.displayLabel = displayLabel;

            currRpm = 0;
            currComputedValue = 0;
            this.bikeSubject = bikeSubject;
            //much important. sign observer to subject
            bikeSubject.addObserver(this);
        }
        public abstract void Update(int data);

        public void Display()
        {
            displayLabel.Text = currComputedValue.ToString("F2");
        }
    }
}
