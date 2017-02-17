using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public class Party
    {

        public Party()
        {
            players = new List<Player>();
        }
        List<Player> players;

        public void AddPlayer(Player p)
        {

            //players.Add(p);
            //p.onEndTurn += NextPlayer;
            if (players.Count <= currentID)
            {
                players.Add(p);
                activePlayer = players[currentID];
                p.onEndTurn += GetNext;
                return;
            }
            players.Add(p);
            p.onEndTurn += GetNext;
        }

        public delegate void OnPartyEnd();
        public OnPartyEnd onPartyEnd;

        public Player lastAttacker;
        public Player LastAttacker
        {
            get { return lastAttacker; }
            set { lastAttacker = value; }
        }
        public Player activePlayer;
        public Player ActivePlayer
        {
            get { return activePlayer; }
            set { activePlayer = value; }
        }
        int currentID = 0;

        public void GetNext()
        {
            //GameManager.Instance.activeplayer = GameManager.Instance.playerlist[i];
            //i++;
            //if (i + 1 == GameManager.Instance.playerlist.Count())
            //{
            //    i = 0;
            //}
            if (currentID >= players.Count - 1)
            {
                currentID = 0;
                activePlayer = players[currentID];
                if (onPartyEnd != null)
                    onPartyEnd.Invoke();
                return;
            }
            currentID++;
            activePlayer = players[currentID];

        }

        public void EndTurn()
        {
            if (onPartyEnd != null)
            {
                onPartyEnd.Invoke();
            }
        }
    }
}
