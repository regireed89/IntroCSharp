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
        delegate int onClick();
        Player Regi = new Player(0,0);
        
        int valMax()
        {
            return progressBar1.Maximum += 100;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            onClick a = valMax;
            Regi.Experience += 10;
            progressBar1.Value = Regi.Experience;
            
        }      
    }

    class Player
    {
       public Player() { }
        public Player(int l, int e)
        {
            m_level = l;
            m_experience = e; 
        }
        private int m_experience;
        public int Experience
        {
            get{ return m_experience; }
            set { m_experience = value; }
        }
        private int m_level;
            public int Level
        {
            get { return m_level; }
            set { m_level = value; }
        }        
    }
    
        
    


}
