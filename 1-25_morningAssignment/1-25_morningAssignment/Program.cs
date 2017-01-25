using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_25_morningAssignment
{
    class Program
    {
        static public char Invert(char s)
        {
            return ((s == '0') ? '1' : '0');
        }

        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;
                tail = value.Substring(4);
                head = value.Remove(4, 4);
            }
            string value;
            string tail;
            string head;
            public override string ToString()
            {
                return value;
            }
            public string Head
            {
                get
                {
                    return head;
                }
            }

            public string Tail
            {
                get
                {
                    return tail;
                }
            }
        }

        static void Main(string[] args)
        {
            Gene gene = new Gene("11111111");
            string back = gene.Tail;
            string front = gene.Head;
            for(int i = 0; i < back.Length; i++)
            {
                foreach (char c in back)
                {
                    char newfront = Program.Invert(c);
                                     
                }
            } 
        }
    }
    //class Program
    //{
    //    //public string Strangs(string a)
    //    //{
    //    //    a =  "1 1 1 1  1 1 1 1";
    //    //    a.Substring
    //    //    string[] ar = new string[255];


    //    //    return a;
    //    //}
    //    static void Main(string[] args)
    //    {

    //    }

    //}
}
