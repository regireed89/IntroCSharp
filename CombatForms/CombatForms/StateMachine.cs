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



    public class FSM : IStateMachine
    {
        public FSM()
        {
            states = new List<State>();
        }
        List<State> states;
        Enum currentstate;

        public void TransitonStates(Enum next)
        {
            if (ValidTransition())
            {
                currentstate = next;
            }
        }

        public bool ValidTransition()
        {
            return true;
        }

        public void AddState(Enum e)
        {
            states.Add(e);
        }
        public void Start()
        {
            
        }

        public void Update()
        {
            
        }
    }



    public class State
    {
        public State() { }
        public State(Enum e)
        {
            name = e.ToString();
        }
        public string name;
    }
}
