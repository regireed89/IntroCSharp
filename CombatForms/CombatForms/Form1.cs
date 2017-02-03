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
        FSM fsm;
        public Form1()
        {
            fsm = new FSM();
            fsm.Start();
            
            

        }
       
        

    }

}
