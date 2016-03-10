using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        List<Character> characterList = new List<Character>();
        public Form1()
        {
            InitializeComponent();

            characterList.Add(new King("Stewie"));
            characterList.Add(new Queen("Meg"));
            characterList.Add(new Knight("Lancelot"));
            characterList.Add(new Knight("Irving"));
            characterList.Add(new Troll("Grumpy"));
            foreach (Character character in characterList)
            {
                checkedListBox1.Items.Add(character.Name);
                checkedListBox2.Items.Add(character.Name);
            }
        }

        //add character
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            string characterName = txtName.Text;

            if(characterName != "")
            {
                if(rdKing.Checked)
                {
                    characterList.Add(new King(characterName));
                    rdKing.Checked = false;
                }
                else if (rdQueen.Checked)
                {
                    characterList.Add(new Queen(characterName));
                    rdQueen.Checked = false;
                }
                else if (rdKnight.Checked)
                {
                    characterList.Add(new Knight(characterName));
                    rdKnight.Checked = false;
                }
                else if (rdTroll.Checked)
                {
                    characterList.Add(new Troll(characterName));
                    rdTroll.Checked = false;
                }
                else
                {
                    MessageBox.Show("Please Select a Type for the Character");
                }
                txtName.Clear();
                checkedListBox1.Items.Clear();
                checkedListBox2.Items.Clear();

                foreach (Character character in characterList)
                {
                    checkedListBox1.Items.Add(character.Name);
                    checkedListBox2.Items.Add(character.Name);
                }

            }
            else
            {
                MessageBox.Show("Please enter a character name");
            }
        }

        //change weapon
        private void button1_Click(object sender, EventArgs e)
        {
           foreach(int checkedCharacter in checkedListBox2.CheckedIndices)
           {
               if (rdSword.Checked)
               {
                   characterList[checkedCharacter].Weapon = new Sword();
                   rdSword.Checked = false;
               }
               else if (rdKnife.Checked)
               {
                   characterList[checkedCharacter].Weapon = new Knife();
                   rdKnife.Checked = false;
               }
               else if (rdBow.Checked)
               {
                   characterList[checkedCharacter].Weapon = new Bow();
                   rdBow.Checked = false;
               }
               else
               {
                   MessageBox.Show("Select a weapon as well Please");
               }
               checkedListBox2.SetItemCheckState(checkedCharacter, CheckState.Unchecked);
           }
        }

        //get the two characters to battle
        private void btnBattle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<int> battleCharacters = new List<int>();

            foreach (int checkedCharacter in checkedListBox1.CheckedIndices)
            {
                battleCharacters.Add(checkedCharacter);
                checkedListBox1.SetItemCheckState(checkedCharacter, CheckState.Unchecked);
            }

            if (battleCharacters.Count == 2)
            {
                foreach (int battlingCharacter in battleCharacters)
                {
                    listBox1.Items.Add(characterList[battlingCharacter].Name);
                    listBox1.Items.Add(characterList[battlingCharacter].Declaim());
                    listBox1.Items.Add(characterList[battlingCharacter].Weapon.UseWeapon());
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show("Please select 2 characters");
            }
        }
    }
}
