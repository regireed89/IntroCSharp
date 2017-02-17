using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatForms
{
    public class Player : IAttacker, IPlayerState
    {
        public Player() { }
        public Player(int health, int damage, int speed)
        {
            m_health = health;
            m_damage = damage;
            m_attackspeed = speed;
            FSM<PlayerStates> fsm = new FSM<PlayerStates>();
            currentstate = PlayerStates.INIT;
        }

        public PlayerStates currentstate;
        private int m_health;
        private int m_damage;
        private int m_attackspeed;

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
            this.currentstate = PlayerStates.IDLE;
        }

        public void Idle()
        {
            if (this.Health <= 0)
            {
                this.currentstate = PlayerStates.DEAD;
                GameManager.Instance.playerlist.Remove(this);
            }
        }

        public bool Attack()
        {
            DoDamage(this);
            GameManager.Instance.activeplayer.currentstate = PlayerStates.IDLE;
            return true;
        }

        public void Dead()
        {
            EndTurn();
        }

        public void Update()
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
                    EndTurn();
                    break;



            }

        }
    }
}
