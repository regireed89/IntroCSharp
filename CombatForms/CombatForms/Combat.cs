using System;
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

    public class Combat
    {
        public Combat()
        {
            parties = new List<Party>();
        }
        List<Party> parties;

        public void AddParty(Party p)
        {
            parties.Add(p);

        }
        public Party activeParty;
        public Party ActiveParty
        {
            get { return activeParty; }
            set { activeParty = value; }
        }

    }
}


