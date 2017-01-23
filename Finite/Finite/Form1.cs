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

            combatManager.ActiveParty = firstParty;
            combatManager.ActiveParty.ActiveIndex = firstParty.characters[0];
             

            

        }



        private void button3_Click(object sender, EventArgs e)
        {

            combatManager.ActiveParty.ActiveIndex.EndTurn();


            combatManager.ActiveParty.EndTurn();
            



            if (combatManager.ActiveParty.ActiveIndex == firstParty.characters[0])
            {
                textBox1.Text = "d";
            }
            else if (combatManager.ActiveParty.ActiveIndex == firstParty.characters[1])
            {
                textBox2.Text = "dfghjk";
            }
            else if (combatManager.ActiveParty.ActiveIndex == firstParty.characters[2])
            {
                textBox3.Text = "dfghjk";
            }
            else if (combatManager.ActiveCharacter == secondParty.characters[0])
            {
                textBox4.Text = "tgbhjk";
            }
            else if (combatManager.ActiveCharacter == secondParty.characters[1])
            {
                textBox5.Text = "dfghjk";
            }
            else if (combatManager.ActiveCharacter == secondParty.characters[2])
            {
                textBox6.Text = "dfghjk";
            }

        }
    }
}
