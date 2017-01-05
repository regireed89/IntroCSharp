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
            //Console.WriteLine("Hello World");

            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            //List<Student> students = new List<Student>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Student s = new Student();
            //    students.Add(s);
            //    Console.WriteLine(s.ToString());
            //}
            {
                Zombie z = new Zombie(500, 100);
                Player p = new Player(500, 100);

                List<Zombie> Zom = new List<Zombie>();
                for (int i = 0; i < 5; i++)
                {                    
                    Zom.Add(z);
                    
                }
                List<Player> Play = new List<Player>();
                for (int i = 0; i < 5; i++)
                {
                    Play.Add(p);
                }
                for (int i = 0; i < 5; i++)
                {
                    Random random = new Random();
                    int x = random.Next(0, 5);

                    
                    player1.Attack(zom1);                   
                    Console.WriteLine(player1.Health);
                    Console.WriteLine(zom1.Health);
                    Console.ReadLine();
                }
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
        public Entity(int h, int att)
        {
            health = h;
            attackPower = att;
        }
        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        private int attackPower;
        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }
        public virtual bool Attack(Entity e)
        {

            e.Health -= AttackPower;
            return true;
        }
        private string name;
        public string Name;
    }

    class Zombie : Entity
    {
        public Zombie() { }
        public Zombie(int a, int b)
        {
            Health = a;
            AttackPower = b;

        }
        override public bool Attack(Entity e)
        {
            e.Health -= AttackPower;
            return true;
        }
    }

    class Player : Entity
    {
        public Player() { }
        public Player(int a, int b) : base(a,b) { }
        override public bool Attack(Entity e)
        {
            e.Health -= AttackPower;
            return true;
        }
        public bool Defend() { return true; }
    }
}
