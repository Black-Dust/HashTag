using System;
using System.Collections.Generic;

namespace HashTag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter tags: ");
            string tags = Console.ReadLine();

            
            string[] outtag = tags.Split
                    (new char[] { ';', ',' },
                        StringSplitOptions.RemoveEmptyEntries);

            


            //char[] charsToTrimm = { ' ' };
            char[] charsToTrimmStart = { ' ', '#' };
            

            foreach (string i in outtag)
            {
                //i.Removr(0);

                Console.WriteLine("\"" + i.TrimStart(charsToTrimmStart) + "\"");

                //bool startsWith = i.StartsWith("#");
                /*if (i.StartsWith("#"))
                {
                    Console.WriteLine("\"" + i.Replace("#", "") + "\"");
                }
                else
                {
                    Console.WriteLine("\"" + i.Trim(charsToTrimm) + "\"");
                }*/
            }
            Console.ReadLine();
        }
    }
}