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
            var e = Enum.GetValues(typeof(T));
            foreach (var v in e)
            {
                State s = new State(v as Enum);
                states.Add(s.name, s);
            }
        }
        Dictionary<string, State> states;
        private Dictionary<string, List<State>> transitions = new Dictionary<string, List<State>>();


        public void AddTransiton<V>(V current, V next)
        {

            //State s = current as State;
            // var tmp = transitions[s.name];
        }

        public bool ValidTransition()
        {
            return true;
        }
        public void ChangeState(PlayerStates s)
        {
            if (ValidTransition())
            {
                GameManager.Instance.activeplayer.currentstate = s;
            }
        }

        public void Start()
        {
            //GameManager.Instance.lastattackerp1 = GameManager.Instance.firstparty[0];
            //GameManager.Instance.lastattackerp2 = GameManager.Instance.secondparty[0];
            GameManager.Instance.activeplayer = GameManager.Instance.playerlist[0];
            GameManager.Instance.activeplayer.currentstate = PlayerStates.INIT;
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
