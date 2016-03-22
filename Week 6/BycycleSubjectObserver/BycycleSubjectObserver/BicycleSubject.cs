using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BycycleSubjectObserver
{
    public class BicycleSubject : IBicycleSubject
    {
        private List<IBicycleObserver> observerList;
        private int currentRPM;

        public BicycleSubject(int data)
        {
            currentRPM = data;
            observerList = new List<IBicycleObserver>();
        }

        public void addObserver(IBicycleObserver obj)
        {
            observerList.Add(obj);
        }


        public void removeObserver(IBicycleObserver obj)
        {
            observerList.Remove(obj);
        }

        public void notifyObservers()
        {
            foreach (BicycleObserver currObserver in observerList)
            {
                currObserver.Update(currentRPM);
            }
        }

        public int CurrentRPM
        {
            get { return currentRPM; }
            set { currentRPM = value; }
        }
    }
}
