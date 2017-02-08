using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    public enum PlayerStates
    {
        INIT = 0,
        IDLE = 1,
        ATTACK = 2,
        ENDTURN = 3,
        DEAD = 4,
    }



    class TurnManager
    {
        public TurnManager() { parties = new List<Party>(); }
        List<Party> parties;

        public void AddParty(Party p)
        {
            parties.Add(p);
        }
        public Party activeParty;
        public Party Active
        {
            get { return activeParty; }
            set { activeParty = value; }
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
        Player activePlayer;
        public Player ActivePlayer
        {
            get { return activePlayer; }
            set { activePlayer = value; }
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

        }

        readonly PlayerStates currentstate = PlayerStates.INIT;
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

        public bool Attack()
        {
            DoDamage(this);
            return true;
        }

        public void Dead()
        {
            EndTurn();
        }

        public void Update()
        {
            while (true)
            {
                switch (this.currentstate)
                {
                    case PlayerStates.INIT:
                        Initialize();
                        break;
                    case PlayerStates.IDLE:
                        Idle();
                        break;
                    case PlayerStates.ATTACK:
                        Attack();
                        break;
                    case PlayerStates.DEAD:
                        Dead();
                        break;
                    case PlayerStates.ENDTURN:
                        Idle();
                        break;

                }
            }
        }


    }
}


