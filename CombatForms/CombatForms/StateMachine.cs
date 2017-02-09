using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{



    public class FSM : IStateMachine
    {
        public FSM()
        {
            states = new Dictionary<string, State>();
        }
        Dictionary<string, State> states;
        State currentstate;

        public void TransitonStates(State next)
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
        public State(string s)
        {
            name = s;
        }
        public string name;
    }
}
