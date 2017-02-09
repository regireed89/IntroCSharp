using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public class Singleton
    {
        //new up when we access the property Instance
        private static Singleton instance;
        //private because someone to new up this instance
        private Singleton() { }
        //this is actually how we access it
        //how u use it Singleton.Instance."some variable"
        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
