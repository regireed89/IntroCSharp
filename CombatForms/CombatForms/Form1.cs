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
            GameManager.Instance.fsm.ChangeState(PlayerStates.ATTACK);
            GameManager.Instance.activeplayer.Update();
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            GameManager.Instance.fsm.ChangeState(PlayerStates.ENDTURN);
            GameManager.Instance.activeplayer.Update();
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = GameManager.Instance.activeplayer.ToString();
        }
        private void save_Click(object sender, EventArgs e)
        {
            DataManagement<Player>.Serialize("ItsAllGood", GameManager.Instance.activeplayer);
            DataManagement<Player>.Serialize("ItsAllGood", GameManager.Instance.player1);
            DataManagement<Player>.Serialize("ItsAllGood", GameManager.Instance.player2);
            DataManagement<Player>.Serialize("ItsAllGood", GameManager.Instance.player3);
            DataManagement<Player>.Serialize("ItsAllGood", GameManager.Instance.player4);
            DataManagement<Player>.Serialize("ItsAllGood", GameManager.Instance.player5);
            DataManagement<Player>.Serialize("ItsAllGood", GameManager.Instance.player6);
        }

        private void load_Click(object sender, EventArgs e)
        {
            DataManagement<Player>.Deserialize("ItsAllGood");
        }


    }
}
