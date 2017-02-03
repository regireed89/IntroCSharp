using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    interface IStateMachine
    {
        void Start();
        void Update();
        void TransitonStates(State next);
        bool ValidTransition();
        void AddState(State s);

    }
}
