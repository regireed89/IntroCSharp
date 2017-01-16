﻿using System;
using System.Windows.Forms;


namespace Finite
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
        }
        
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            combatManager.ActiveCharacter.EndTurn();   
        }
    }
}
