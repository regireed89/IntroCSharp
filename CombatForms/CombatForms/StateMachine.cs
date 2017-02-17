using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            State s1 = new State(current as Enum);
            State s2 = new State(next as Enum);
            List<State> tmp = new List<State>();
            tmp.Add(s1);
            tmp.Add(s2);
            transitions.Add(tmp[0].name + "->" + tmp[1].name, tmp);
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
