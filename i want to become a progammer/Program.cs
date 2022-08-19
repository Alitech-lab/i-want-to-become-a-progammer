using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_want_to_become_a_progammer
{
    internal class Program
    {
        static int SIZE = 24;

        //function to the character and its
        //frequncy in ascending order
        static void printCharWithFreq(string str) 
        {
            // size of the string 'str'
            int n = str .Length;


            // 'freq[]' implemented as hash table
            int[] freq = new int[SIZE];


            // accumulate frequncy of each character
            // in 'str'
            for (int i = 0; i < n; i++)
                freq[str[i] - 'a']++;

            // traverse 'str' from left to right
            for (int i = 0; i < n; i++)
            {
                //if frequncy of character str.charAt(i)
                // is not equal to 0
                if (freq[str[i] - 'a'] != 0)
                {
                    //print the character along with its 
                    // frequncy
                    Console.WriteLine(str[i]);
                    Console.WriteLine(freq[str[i] - 'a'] + " ");  
                    


                    // update frequncy of str.charat(i) to
                    // 0 so that the same racter is not 
                    //printer again
                    freq[str[i] - 'a'] = 0;   
                }   

            }

         
        }

        // Driver program to tes above
        public static void Main()
        {
            string str = "iwanttobecomeaprogrammer";
            printCharWithFreq(str);

        }
    }

}
