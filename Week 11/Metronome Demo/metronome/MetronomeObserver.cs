using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    //form controls delegate
    public delegate void FormControl(metronomeEventArgs me);


    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if (spinBox.InvokeRequired)
            {
                //making new delegate
                FormControl formControl = new FormControl(updateSpinBox);
                spinBox.Invoke(formControl, new object[] {e});
            }
            else
            {
                updateSpinBox(e);
            }
        }

        public void updateSpinBox(metronomeEventArgs me)
        {
            spinBox.Value++;
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if (listBox.InvokeRequired)
            {
                FormControl formControl = new FormControl(updateListBox);
                listBox.Invoke(formControl, new object[] { e });
            }
            else
            {
                updateListBox(e);
            }
        }

        public void updateListBox(metronomeEventArgs me)
        {
            DateTime currDateTime = me.currentTime;
            listBox.Items.Add(currDateTime.ToString());
        }
    }






            
}
