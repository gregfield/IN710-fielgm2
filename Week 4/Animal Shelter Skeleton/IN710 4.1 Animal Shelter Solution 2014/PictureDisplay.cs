using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public class PictureDisplay: IDisplay
    {
        public static List<PictureBox> PictureBoxList;

        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            PictureBoxList = pictureBoxList;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            for (int i = 0; i < critterList.Count; i++)
            {
                PictureBoxList[i].Load(critterList[i].ImageFileName);
            }
        }

        public void clearDisplay()
        {
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                PictureBoxList[i].Image = null;
            }

        }
    }
}
