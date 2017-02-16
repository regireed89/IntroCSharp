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
            InitializeComponent();               
        }

        private void Attack_Click(object sender, EventArgs e)
        {           
            GameManager.Instance.activeplayer.Update();
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            GameManager.Instance.activeplayer.Update();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataManagement<Player>.Serialize("MyGame", GameManager.Instance.activeplayer);
            DataManagement<Player>.Serialize("MyGame", GameManager.Instance.player1);
            DataManagement<Player>.Serialize("MyGame", GameManager.Instance.player2);
            DataManagement<Player>.Serialize("MyGame", GameManager.Instance.player3);
            DataManagement<Player>.Serialize("MyGame", GameManager.Instance.player4);
            DataManagement<Player>.Serialize("MyGame", GameManager.Instance.player5);
            DataManagement<Player>.Serialize("MyGame", GameManager.Instance.player6);

        }

        private void load_Click(object sender, EventArgs e)
        {
            DataManagement<Player>.Deserialize("MyGame");
        }
    }
}
