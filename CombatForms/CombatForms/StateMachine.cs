using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

   

    public class FSM : IStateMachine
    {
        public FSM() { states = new List<State>(); }
        List<State> states;
       

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void TransitonStates(State next)
        {
            throw new NotImplementedException();
        }

        public bool ValidTransition()
        {
            throw new NotImplementedException();
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
