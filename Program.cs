using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            {
                // Create Variables

                char exi = 'Y';// for  loop exit codition   

                 while ((exi != 'q')&&(exi != 'Q'))
                {


                    Console.Write("Input Your Name :  ");
                    string name = Console.ReadLine();  

                    var reg = new Regex(@"^$|([^a-zA-Z]+)|^.$");  //^$-empty sting   ^.$ -one chatacter string 
                    Match exis = reg.Match(name);
                    ConsoleColor currentForeground = Console.ForegroundColor;
                    if (exis.Success)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Input");
                    }
                    else
                    {
                        name = name.ToLower();
                        Console.ForegroundColor = ConsoleColor.Green; //doesn't take int as enum replacement ...=10;
                        Console.WriteLine("Hello " + char.ToUpper(name[0]) + name.Substring(1));
                    }
                    Console.ForegroundColor = currentForeground;
                    Console.WriteLine("Type \'Q\' for quit or any other key to continue");
                    exi = Console.ReadKey().KeyChar;
                    Console.Clear();

                }
            }

           // to do: 

             
        }
    }
}
