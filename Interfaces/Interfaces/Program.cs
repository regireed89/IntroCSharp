using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    class Ninja : IDamager, IDamageable
    {
        public Ninja(string n, int h, int d)
        {
            n = m_name;
            h = m_health;
            d = m_damage;
        }
        public int m_health;
        public int m_damage;
        public string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }
        public int Damage
        {
            get { return m_damage; }
            set { m_damage = value; }
        }
        

    }
    class Zambie : IDamager, IDamageable
    {
        public Zambie(string n, int h, int d)
        {
            n = m_name;
            h = m_health;
            d = m_damage;
        }
        public int m_health;
        public int m_damage;
        public string m_name;
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }
        public int Damage
        {
            get { return m_damage; }
            set { m_damage = value; }
        }

        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
