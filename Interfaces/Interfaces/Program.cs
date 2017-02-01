using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Interfaces
{

    public enum State
    {
        INIT = 0,
        IDLE = 1,
        ATTACK = 2,
        EXIT = 3,
    }


    public class Entity : IDamageable, IDamager
    {
        public Entity() { }
        public Entity(string name, float health, float damage)
        {
            name = m_name;
            health = m_health;
            damage = m_damage;
        }
        float m_health;
        float m_damage;
        string m_name;

        string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        float Health
        {
            get { return m_health; }
            set { m_health = value; }
        }
        float Damage
        {
            get { return m_damage; }
            set { m_damage = value; }
        }
        State currentstate;
        void ChangeState(State next)
        {
            currentstate = next;
        }
        bool ValidTransition()
        {
            return false;
        }

        public float TakeDamage(float damageamount)
        {
            this.Health -= damageamount;
            return this.Health;
        }

        public IDamager DoDamage(IDamager i)
        {
            throw new NotImplementedException();
        }
    }


    class Ninja : Entity
    {

        public Ninja() { }
        public Ninja(string name, float health, float damage)
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

        public void ThrowKnife(Zambie target)
        {
            target.Health -= this.Damage;
        }

        public void Meditate(Ninja target)
        {
            target.Health += 10;
        }
    }


    class Zambie : Entity
    {
        public Zambie() { }
        public Zambie(string name, float health, float damage)
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
        State currentstate;
        public void Bite(Ninja target)
        {
            target.Health -= this.Damage;
        }

        public void EatBrain(Zambie target)
        {
            target.Health += 10;
        }
    }



    class Program
    {


        static void Main(string[] args)
        {
            Ninja shadow = new Ninja("shadow", 100, 10);
            Zambie grrr = new Zambie("grrr", 100, 10);
            


        }
    }
}
