using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katarange
{
    internal class Program
    {
        public class Kata{
            public bool contains(string a, string b) {
                int range11 = int.Parse(a.Substring(1, a.IndexOf(",")-1));
                int range12 = int.Parse(a.Substring(a.IndexOf(",")+1, (a.Substring(a.IndexOf(",")+1)).Length -1 ));

                int range21 = int.Parse(b.Substring(1, b.IndexOf(",") - 1));
                int range22 = int.Parse(b.Substring(b.IndexOf(",")+1, (b.Substring(b.IndexOf(",") + 1)).Length - 1));

                if (a[0] == '[' && a[a.Length -1] == ']')
                {
                    return range11 <= range21 && range12 >= range22;
                }
                else if (a[0] == '(' && a[a.Length - 1] == ')')
                {
                    return range11 < range21 && range12 > range22;
                }
                else if (a[0] == '[' && a[a.Length - 1] == ')')
                {
                    return range11 <= range21 && range12 > range22;
                }
                else
                {
                    return range11 < range21 && range12 >= range22;
                }

            }
            public void GetAll(string a) {
                int range11 = int.Parse(a.Substring(1, a.IndexOf(",") - 1));
                int range12 = int.Parse(a.Substring(a.IndexOf(",")+1, (a.Substring(a.IndexOf(",") + 1)).Length - 1));
                for (int i = range11; i < range12; i++)
                {

                }
            }

            public bool overlaps(string a, string b)
            {
                int range21 = int.Parse(a.Substring(1, a.IndexOf(",") - 1));
                int range22 = int.Parse(a.Substring(a.IndexOf(",")+1, (a.Substring(a.IndexOf(",") + 1)).Length - 1));

                int range11 = int.Parse(b.Substring(1, b.IndexOf(",") - 1));
                int range12 = int.Parse(b.Substring(b.IndexOf(",")+1, (b.Substring(b.IndexOf(",") + 1)).Length - 1));

                if (a[0] == '[' && a[a.Length - 1] == ']')
                {
                    return range11 <= range21 || range12 >= range22;
                }
                else if (a[0] == '(' && a[a.Length - 1] == ')')
                {
                    return range11 < range21 || range12 > range22;
                }
                else if (a[0] == '[' && a[a.Length - 1] == ')')
                {
                    return range11 <= range21 || range12 > range22;
                }
                else
                {
                    return range11 < range21 || range12 >= range22;
                }

            }

            public bool equals(string a, string b) {
                return a == b;
            }
        } 
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            bool e = kata.contains("[2,7)", "[2,3]");
            Console.WriteLine(e);
        }
    }
}
