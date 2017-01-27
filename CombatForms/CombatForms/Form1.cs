using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatForms
{
    public partial class Form1 : Form
    {
        Combat combatManager;
        Party firstParty;
        Character Jim;
        Character John;
        Character Joe;
        Party secondParty;
        Character Billy;
        Character Bob;
        Character Bo;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            combatManager = new Combat();
            firstParty = new Party();
            combatManager.AddParty(firstParty);
            Jim = new Character();
            firstParty.AddCharacter(Jim);
            John = new Character();
            firstParty.AddCharacter(John);
            Joe = new Character();
            firstParty.AddCharacter(Joe);
            secondParty = new Party();
            combatManager.AddParty(secondParty);
            Billy = new Character();
            secondParty.AddCharacter(Billy);
            Bob = new Character();
            secondParty.AddCharacter(Bob);
            Bo = new Character();
            secondParty.AddCharacter(Bo);

            combatManager.ActiveParty = firstParty;
            combatManager.ActiveParty.ActiveIndex = firstParty.characters[0];
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            combatManager.ActiveParty.ActiveIndex.EndTurn();

            if (combatManager.ActiveParty.ActiveIndex == firstParty.characters[0])
            {
                progressBar1.Value -= 10;
            }
            else if (combatManager.ActiveParty.ActiveIndex == firstParty.characters[1])
            {
                progressBar2.Value -= 10;
            }
            else if (combatManager.ActiveParty.ActiveIndex == firstParty.characters[2])
            {
                progressBar3.Value -= 10;
            }
            if (combatManager.ActiveCharacter == secondParty.characters[0])
            {
                progressBar4.Value -= 10;
            }
            else if (combatManager.ActiveCharacter == secondParty.characters[1])
            {
                progressBar5.Value -= 10;
            }
            else if (combatManager.ActiveCharacter == secondParty.characters[2])
            {
                progressBar6.Value -= 10;
            }
        }
    }
}
