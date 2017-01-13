using System;

using System.Windows.Forms;


namespace Finite
{
    public partial class Form1 : Form
    {

        Combat combatManager;
        Party firstParty;
        Character characterOne; 
        public Form1()
        {
            InitializeComponent();
            combatManager = new Combat();
            firstParty = new Party();
            characterOne = new Character();       
        }
        
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            combatManager.AddParty(firstParty);
            firstParty.AddCharacter(characterOne);
            combatManager.ActiveCharacter.EndTurn();   
        }


    }
}
