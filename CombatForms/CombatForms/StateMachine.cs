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

    public class FSM
    {
        private PlayerStates currentstate;
        public FSM() { states = new List<State>(); }
        List<State> states;
        public void Start()
        {
            currentstate = PlayerStates.INIT;
        }
        public void Update() { }
        public void TransitonStates(PlayerStates current, PlayerStates next)
        {
            current = currentstate;
            if (CanChangeStates() == true)
            {
                currentstate = next;
            }
        }
        public bool CanChangeStates()
        {
            return true;
        }
        public void AddState(State s)
        {
            states.Add(s);
        }
    }



    public class State
    {
        public State() { }
        public State(string s)
        {
            name = s;
        }
        public string name;
      


     
        
    }
}
