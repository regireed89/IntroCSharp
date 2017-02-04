using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    class TurnManager
    {
        public TurnManager() { parties = new List<Party>(); }
        List<Party> parties;

        public void AddParty(Party p)
        {
            parties.Add(p);
        }
        public Party activeparty;
        public Party Active
        {
            get { return activeparty; }
            set { activeparty = value; }
        }
    }

    class Party
    {

        public Party() { players = new List<Player>(); }
        List<Player> players;

        public void AddCharacter(Player p)
        {
            players.Add(p);
        }

        public delegate void OnPartyEnd();
        public OnPartyEnd onPartyEnd;
        Player lastattacker;
        Player activeplayer;
        public Player ActivePlayer
        {
            get { return activeplayer; }
            set { activeplayer = value; }
        }
        public void NextPlayer()
        {

        }
        public void EndTurn()
        {
            if (onPartyEnd != null)
            {
                onPartyEnd.Invoke();
            }
        }
    }

    class Player : IAttacker, IPlayerState
    {
        public Player() { }
        public Player(int h, int d, int s)
        {
            h = m_health;
            d = m_damage;
            s = m_attackspeed;
            FSM fsm = new FSM();
            State currentstate = new State();
        }

        int m_health;
        int m_damage;
        int m_attackspeed;

        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }
        public int Damage
        {
            get { return m_damage; }
            set { m_damage = value; }
        }
        public int AttackSpeed
        {
            get { return m_attackspeed; }
            set { m_attackspeed = value; }
        }

        public delegate void OnEndTurn();
        public OnEndTurn onEndTurn;
        public void EndTurn()
        {
            if (onEndTurn != null)
            {
                onEndTurn.Invoke();
            }
        }

        public void DoDamage(Player p)
        {
            p.Health -= this.Damage;       
                 
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Idle()
        {
            throw new NotImplementedException();
        }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public void Dead()
        {
            throw new NotImplementedException();
        }
    }
}


