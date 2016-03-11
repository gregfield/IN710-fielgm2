using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public class TextDisplay: IDisplay
    {
        public static ListBox ShowCritterListBox;

        public TextDisplay(ListBox listbox)
        {
            ShowCritterListBox = listbox;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            for (int i = 0; i < critterList.Count; i++)
            {
                ShowCritterListBox.Items.Add(critterList[i].Name + " the " + critterList[i].Species);
            }
        }

        public void clearDisplay()
        {
            ShowCritterListBox.Items.Clear();
        }
    }
}
