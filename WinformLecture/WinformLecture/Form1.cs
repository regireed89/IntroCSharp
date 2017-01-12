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
        public Form1()
        {
            InitializeComponent();
        }
        Player Regi = new Player();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Regi.Experience += 10;
            progressBar1.Value = Regi.Experience;
            richTextBox1.Text = Regi.Experience.ToString();
            richTextBox2.Text = Regi.Level.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                Regi.Level += 1;
                progressBar1.Maximum *= 2;
                progressBar1.Minimum = Regi.Experience;
                progressBar1.Value = progressBar1.Minimum;               
            }
        }
    }

    class Player
    {
        public Player()
        {
            m_experience = 0;
            m_level = 1;
            //onLevelUp(this);
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
    }





}
