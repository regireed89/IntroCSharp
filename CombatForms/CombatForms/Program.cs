using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CombatForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            TurnManager turn = new TurnManager();
            
            Party party1 = new Party();
            Player jim = new Player(100, 10, 60);
            Player john = new Player(100, 10, 41);
            Player joe = new Player(100, 10, 65);
            party1.AddPlayer(jim);
            party1.AddPlayer(john);
            party1.AddPlayer(joe);
            GameManager.Instance.firstparty = party1;
            GameManager.Instance.player1 = jim;
            GameManager.Instance.player2 = john;
            GameManager.Instance.player3 = joe;

            Party party2 = new Party();
            Player billy = new Player(100, 10, 9);
            Player bob = new Player(100, 10, 49);
            Player bo = new Player(100, 10, 89);
            party2.AddPlayer(billy);
            party2.AddPlayer(bob);
            party2.AddPlayer(bo);
            GameManager.Instance.secondparty = party2;
            GameManager.Instance.player4 = billy;
            GameManager.Instance.player5 = bob;
            GameManager.Instance.player6 = bo;


            List<Player> allplayers = new List<Player>();
            allplayers.Add(jim);
            allplayers.Add(john);
            allplayers.Add(joe);
            allplayers.Add(billy);
            allplayers.Add(bob);
            allplayers.Add(bo);

            

           // allplayers.ForEach(x => Debug.WriteLine(x.AttackSpeed));
            allplayers.Sort((a, b) => a.AttackSpeed.CompareTo(b.AttackSpeed));
            // allplayers.ForEach(x => Debug.WriteLine(x.AttackSpeed));


            GameManager.Instance.playerlist = allplayers;
            Debug.WriteLine(GameManager.Instance.activeplayer.AttackSpeed);
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
