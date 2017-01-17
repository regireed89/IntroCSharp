using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;  
using System.Threading.Tasks; 
using System.Windows.Forms; 
 
namespace Finite 
{ 
    class FinalFantasy 
    { 
         
    }
    class Combat 
    { 
        public Combat() { parties = new List<Party>(); } 
        List<Party> parties; 
        /// <summary> 
        /// adds a new party to a list of parties 
        /// </summary> 
        /// <param name="p"></param> 
        /// <returns></returns> 
        public bool AddParty(Party p) 
        { 
            parties.Add(p);
            if (parties.Count > 3)
            {
                parties.Remove(parties[2]);
            }
            p.onPartyEnd += NextParty;
            return true; 
        } 
        public int activeIndex = 0; 
        public Character ActiveCharacter 
        {
            get 
            { 
                Party p1 = parties[activeIndex];
                return p1.characters[activeIndex];
            }            
        }
        public bool NextParty() 
        {         
            
            return false; 
        } 
    }







    class Party 
    { 
        public Party() 
        { 
            characters = new List<Character>(); 
        }
        public List<Character> characters;

        public int ActiveIndex = 0;
        /// <summary>
        /// adds a new character to a list of characters   s
        /// </summary>  
        /// <param name="c"></param>  
        /// <returns></returns> 
        public bool AddCharacter(Character c) 
        { 
            characters.Add(c); 
            c.onEndTurn += NextPlayer; 
            return false; 
        } 
        public delegate bool OnPartyEnd();
        public OnPartyEnd onPartyEnd;
        
        public void EndTurn()
        {
            if (onPartyEnd != null)
            {
                onPartyEnd.Invoke();
            }
        } 
         
        /// <summary>  
        ///moves to next player in the list  
        /// </summary>  
        /// <returns></returns> 
        public bool NextPlayer()  
        { 
            ActiveIndex++;

            return false;
        }

        
    }








    class Character 
    { 
        public Character() 
        { 

        }

        public bool Attack()
        {
            return false;
        }

        public bool Defend()
        {
            return false;
        }

        public delegate bool OnEndTurn();
        public OnEndTurn onEndTurn; 

        public void EndTurn()
        {
            if (onEndTurn != null)
            {
                onEndTurn.Invoke();
            }
        }
    }
}
 










