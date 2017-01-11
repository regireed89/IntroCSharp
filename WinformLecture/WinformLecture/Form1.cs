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
        public int Exp(Player p)
        {


        }
    }





}
