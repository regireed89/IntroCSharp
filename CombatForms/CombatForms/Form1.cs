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

        List<Player> all = new List<Player>();
       
        public Form1()
        {
             
            
                
        }

        private void Attack_Click(object sender, EventArgs e)
        {
          
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            foreach(Player p in )
            DataManagement<Player>.Serialize("MyGame", )
            
        }

        private void load_Click(object sender, EventArgs e)
        {

        }
    }
}
