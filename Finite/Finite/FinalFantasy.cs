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
            if (parties.Count > 2)
            {
                parties.Remove(parties[2]);
                return true;
            }
            p.onPartyEnd += NextParty;
            
            return true;
        }

        Party p1;
        public int activeIndex = 0;
        public Character ActiveCharacter
        {
            get
            {
                p1 = parties[activeIndex];
                return p1.characters[activeIndex];
            }
        }

        public bool NextParty()
        {
            if (p1.characters[activeIndex] == null)
            {
                p1 = parties[activeIndex++];
            }
            p1.characters[0] = ActiveCharacter;
            return true;
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
        /// adds a new character to a list of characters 
        /// </summary>  
        /// <param name="c"></param>  
        /// <returns></returns> 
        public bool AddCharacter(Character c)
        {
            characters.Add(c);
            c.onEndTurn += NextPlayer;
            return true;
        }
        public delegate bool OnPartyEnd();
        public OnPartyEnd onPartyEnd;

        /// <summary>  
        ///moves to next player in the list  
        /// </summary>  
        /// <returns></returns> 
        public bool NextPlayer()
        {

            return false;
        }

        public void EndTurn()
        {
            if (onPartyEnd != null)
            {
                onPartyEnd.Invoke();
            }
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











