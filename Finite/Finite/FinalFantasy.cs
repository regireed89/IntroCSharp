using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finite
{
    class FinalFantasy
    {
        class Combat
        {
            public Combat() { parties = new List<Party>(); }
            List<Party> parties; 
            public bool AddParty(Party p)
            {
                parties.Add(p);
                return true;
            }                      
        }

        class Party 
        {
            public Party() { characters = new List<Character>(); }
            List<Character> characters; 
            public bool EndTurn()
            {
                return false;
            }
            public bool AddCharacter(Character c)
            {
                characters.Add(c);
                return false;
            }
        }
        class Character 
        {
            public Character() { }
            public bool Attack()
            {
                return false;
            }
            public bool Defend()
            {
                return false;
            }            
            public bool EndTurn()
            {
                return false;
            }
        }      
    }
}
