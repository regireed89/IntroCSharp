using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{

    public class FSM<T>
    {
        public FSM()
        {          
            states = new Dictionary<string, State>();
            transitions = new Dictionary<string, List<State>>();
            var e = Enum.GetValues(typeof(T));
            foreach (var v in e)
            {
                State s = new State(v as Enum);
                states.Add(s.name, s);
            }
        }
        Dictionary<string, State> states;
        Dictionary<string, List<State>> transitions;


       

        public void AddTransiton(State current, State next)
        {
            
        }

        public bool ValidTransition()
        {
            return true;
        }

        public void AddState(Enum e)
        {
            State s = new State(e);
            states.Add(s.name, s);
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
