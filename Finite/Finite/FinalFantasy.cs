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
        public void AddParty(Party p)
        {
            parties.Add(p);
            p.onPartyEnd += NextParty;
        }

        public Party activeParty;
        public Character activeCharacter;

        public Party ActiveParty
        {
            get
            {
                return activeParty;
            }
            set
            {
                activeParty = value;
            }
        }
        public Character ActiveCharacter
        {
            get
            {
                return activeCharacter;
            }
            set
            {
                activeCharacter = value;
            }
        }

        public int i = 0;
        public void NextParty()
        {
            activeParty = parties[i];
            if (i > parties.Count)
            {
                i = 0;              
            }

            else if (activeCharacter == null)
            {
                i = 0;
                
                activeParty = parties[i++];
                activeCharacter = activeParty.characters[i];
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


        /// <summary>
        /// adds a new character to a list of characters 
        /// </summary>  
        /// <param name="c"></param>  
        /// <returns></returns> 
        public void AddCharacter(Character c)
        {
            characters.Add(c);
            c.onEndTurn += NextPlayer;

        }
        public delegate void OnPartyEnd();
        public OnPartyEnd onPartyEnd;
        public Character activeIndex;
        public Character ActiveIndex
        {
            get
            {
                return activeIndex;
            }
            set
            {
                activeIndex = value;
            }
        }

        public int i = 0;
        /// <summary>  
        ///moves to next player in the list  
        /// </summary>  
        /// <returns></returns> 
        public void NextPlayer()
        {
            if (i >= characters.Count)
            {
                i = 0;               
            }
            activeIndex = characters[i];
            i++;
            
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

        public delegate void OnEndTurn();
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











