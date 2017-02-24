using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLecture
{
    public partial class Form1 : Form
    {
        Player Regi = new Player();
        public Form1()
        {
            InitializeComponent();
            Regi.levelUp += AddXP;//assign AddXP fuction to delegate
            Regi.onLevelUp += UpdateText;//assign UpdateText fuction to delegate
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            Regi.levelUp.Invoke(Regi);//invokes methods assigned to delegates on button click
            Regi.onLevelUp.Invoke(Regi);//invokes methods assigned to delegates on button click
                       
        }

        private void UpdateText(Player p)
        {
            richTextBox1.Text = p.Experience.ToString();//prints experience to textbox in winform 
            richTextBox2.Text = p.Level.ToString();//prints level to textbox in winforms
        }
        private void AddXP(Player p)
        {
            p.Experience += 10;//adds 10 experience points to players experience
            progressBar1.Value = p.Experience;//assigns player experience to progress bar 
            if (progressBar1.Value == progressBar1.Maximum)//checks if progress bar current value is equal to the progress bar maximum value
            {
                p.Level += 1;//player level goes up by one if condition is met
                progressBar1.Maximum *= 2;//the maximum value for progress bar multiplies by 2 when condition is met
                progressBar1.Minimum = p.Experience;//current player experience after level up becomes the new minimum value for progress bar 
                progressBar1.Value = progressBar1.Minimum;//sets progress bar value to the minimum value 
            }
        }
        

        class Player
        {
            public Player()
            {
                m_experience = 0;
                m_level = 1;
                
            }
            private int m_experience;
            public int Experience
            {
                get { return m_experience; }
                set { m_experience = value; }
            }
            private int m_level;
            public int Level
            {
                get { return m_level; }
                set { m_level = value; }
            }
            public delegate void OnLevelUp(Player p);
            public OnLevelUp onLevelUp;
            public delegate void LevelUp(Player p);
            public LevelUp levelUp;
        }

       
    }   
}
