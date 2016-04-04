using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {
        List<Garden> gardens;
        ListBox listBox;
        public GardenManager(ListBox listBox)
        {
            gardens = new List<Garden>();
            this.listBox = listBox;
        }

        public void AddGarden(Garden garden)
        {
            gardens.Add(garden);
        }

        public void ProcessGardens(GardensDelegate gardenDelegate)
        {
            listBox.Items.Clear();
            foreach (Garden currentGarden in gardens)
            {
                listBox.Items.Add(gardenDelegate(currentGarden));
            }
        }

        public String AreaReport(Garden garden)
        {
            return String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetArea());
        }

        public String ChargesReport(Garden garden)
        {
            return String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetAccountBalance());
        }
    }
}
