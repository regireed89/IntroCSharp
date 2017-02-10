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
        
        
       
        public Form1()
        {
             
            Player billy = new Player(100, 10, 7);
            Player bob = new Player(100, 10, 3);
            Player bo = new Player(100, 10, 10);
            Player jim = new Player(100, 10, 8);
            Player john = new Player(100, 10, 5);
            Player joe = new Player(100, 10, 2);
            
                
        }

        private void Attack_Click(object sender, EventArgs e)
        {
           
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            

        }

        private void load_Click(object sender, EventArgs e)
        {

        }
    }
}
