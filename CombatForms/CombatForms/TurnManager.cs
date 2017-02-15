﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

    public class TurnManager
    {
        public TurnManager()
        {
            party1 = new List<Party>();
            party2 = new List<Party>();
            allplayers = new List<Player>();
        }
        List<Party> party1;
        List<Party> party2;
        List<Player> allplayers;

        public void AddParty(Party p)
        {
            party1.Add(p);

        }
        public Party activeParty;
        public Party ActiveParty
        {
            get { return activeParty; }
            set { activeParty = value; }
        }
        public void NextPlayer()
        {


        }
    }



    public class Party
    {

        public Party()
        {
            players = new List<Player>();
        }
        List<Player> players;

        public void AddPlayer(Player p)
        {
            players.Add(p);
            
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

        public void EndTurn()
        {
            if (onPartyEnd != null)
            {
                onPartyEnd.Invoke();
            }
        }
    }



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

        PlayerStates currentstate;
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
            }
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


