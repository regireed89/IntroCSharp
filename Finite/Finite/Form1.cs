using System;

using System.Windows.Forms;


namespace Finite
{
    public partial class Form1 : Form
    {

        Combat combatManager;       
        public Form1()
        {
            InitializeComponent();
            combatManager = new Combat();            
        }
        
       
        private void button3_Click(object sender, EventArgs e)
        {                                  
            combatManager.ActiveCharacter.EndTurn();   
        }


    }
}
