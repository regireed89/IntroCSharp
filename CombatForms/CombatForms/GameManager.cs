using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    class GameManager
    {
        Party party1 = new Party();
        Party party2 = new Party();
        Player jim = new Player(100, 10, 6014);
        Player john = new Player(100, 10, 41);
        Player joe = new Player(100, 10, 65914);
        //new up when we access the property Instance
        private static GameManager instance;
        //private because someone to new up this instance
        private GameManager() { }
        //this is actually how we access it
        //how u use it Singleton.Instance."some variable"
        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }
    }
}
