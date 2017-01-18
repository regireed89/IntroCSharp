using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finite
{
    class FinalFantasy { }

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

        public Party activeParty = new Party();
        public Character activeCharacter;
        public int i = 0;
        public Party ActiveParty
        {
            set
            {
               activeParty = parties[i];               
            }
        }
        public Character ActiveCharacter
        {
            get
            {
                return activeParty.characters[i];
            }
            set
            {
                activeCharacter = activeParty.characters[i];
            }
        }
       

        public bool NextParty()
        {
            activeCharacter = activeParty.characters[i++];
             if (activeCharacter == null)
            {
                activeParty = parties[i++];
                return true;
            }
            else
            {
                return false;
            }
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
        
        
        Character c;
        /// <summary>  
        ///moves to next player in the list  
        /// </summary>  
        /// <returns></returns> 
        public bool NextPlayer()
        {
            
            c = characters[ActiveIndex++];
            if(characters[ActiveIndex] == null)
            {
                
                return false;
            }
            else
            {
                return true;
            }
            
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











