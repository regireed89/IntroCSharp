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
            return true;
        }

        public Character ActiveCharacter
        {
            get
            {
                Party p1 = parties[0];
                return p1.characters[0];
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

        public void EndTurn()
        {

        }
        /// <summary>
        /// adds a new character to a list of characters  
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool AddCharacter(Character c)
        {
            characters.Add(c);
            c.onEndTurn += NextPlayer;
            return false;
        }
        public delegate void OnPartyEnd();
        OnPartyEnd onPartyEnd;

        /// <summary>
        ///moves to next player in the list 
        /// </summary>
        /// <returns></returns>
        public bool NextPlayer()
        {
            ActiveIndex = 0;
            
            return false;
        }
        public int ActiveIndex = 0;
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
