using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    enum State
    {
        INIT = 0,
        ATTACK = 1,
        DEFEND = 2,
        EXIT = 3,
    }


    class FSM
    {
        State currentState;
        void ChangeState(State current, State next) { }
        bool ValidTransition() { return true; }
    }
    public class Entity : IDamager, IDamageable
    {
        public Entity() { }
        public Entity(string name, float health, float damage)
        {
            name = m_name;
            health = m_health;
            damage = m_damage;
        }
        public float m_health;
        public float m_damage;
        public string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public float Health
        {
            get { return m_health; }
            set { m_health = value; }
        }
        public float Damage
        {
            get { return m_damage; }
            set { m_damage = value; }
        }

        public void HitEm(float behit)
        {
            
        }

        public float TakeDamage(float damageamount)
        {
            m_health -= damageamount;
            return m_health;
        }
    }
    class Ninja : Entity
    {
        public Ninja() { }
       
        public void ThrowKnife(Zambie target)
        {

        }

        public void Meditate(Ninja heal)
        {

        }
        

    }

    class Zambie : Entity
    {
        public Zambie() { }

        public void Bite(Ninja target)
        {

        }

        public void EatBrain(Zambie heal)
        {

        }


    }



    class Program
    {
        static void Main(string[] args)
        {
           




        }
    }
}
