using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class P12_revWordInsen
    {
        public static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] pangramwords = pangram.Split(' ');
            foreach(string s in pangramwords)
            {
                char[] chars = s.ToCharArray();
                System.Array.Reverse(chars);
                foreach(char c in chars)
                {
                    Console.Write(c);
                }
                Console.Write(" ");
            }
        }
    }
}
