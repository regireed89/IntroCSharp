using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student s = new Student();
                students.Add(s);
                Console.WriteLine(s.ToString());
            }


        }
    }

    class Vehicle
    {
        public Vehicle()
        {

        }
        public float speed;
        private int tires;
        private int doors;
        private bool steering;
        public int passengers;
    }

    class Car : Vehicle
    {
        public Car() { }
    }

    class Student
    {
        public Student() { }
        public Student(int a)
        {
            id = a;
        }
        int id;
    }

    class Entity
    {
        public Entity() { }
        public Entity(int h,int att)
        {
            health = h;
            attackPower = att;
        }
        private int health;
        protected int Health
        {
            get { return health; }
        }
        private int attackPower;
        public int AttackPower
        {
            get { return attackPower; }
        }
        public virtual bool Attack(Entity e)
        {           
            return true;
        }
        private string name;
        public string Name;
    }

   class Zombie:Entity
    {
        public Zombie() { }
        public Zombie(int a, int b) { }
        override public bool Attack(Entity e)
        {
            return true;
        }
    }

    class Player:Entity
    {
        public Player() { }
        public Player (int a, int b) { }
        override public bool Attack(Entity e)
        {
            return true;
        }
        public bool Defend() { return true; }
    }
}
