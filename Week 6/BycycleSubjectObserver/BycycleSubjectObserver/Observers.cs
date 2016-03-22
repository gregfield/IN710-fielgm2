using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BycycleSubjectObserver
{
    public class RPMCalc : BicycleObserver
    {
        public RPMCalc(Label displayLabel, BicycleSubject bikeSubject) : base (displayLabel, bikeSubject)
        { }
        public override void Update(int data)
        {
            currRpm = data;
            currComputedValue = currRpm;
            Display();
        }
    }

    public class CalorieCalc : BicycleObserver
    {
        public CalorieCalc(Label displayLabel, BicycleSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        { }
        public override void Update(int data)
        {
            currRpm = data;
            currComputedValue = 5 * currRpm;
            Display();
        }
    }

    public class DistanceCalc : BicycleObserver
    {
        public DistanceCalc(Label displayLabel, BicycleSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        { }
        public override void Update(int data)
        {
            currRpm = data;
            currComputedValue = (205 * currRpm)/ 100000 ;
            Display();
        }
    }
}
