using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            Console.WriteLine();
            if (s1 == "Hello console")
            {
                string s2 = "Hello World";
                Console.WriteLine(s2);
            }
            else
            {
                Console.WriteLine("Huh?");
            }
            JustForFun obj;// obj is declared to be a "JustForFun" objext
            obj = new JustForFun();// "obj" is now instantiated
            obj.showmessage("Just for fun");
            obj.showmessage(21);
            Console.WriteLine("");

            s1 = obj.getline();
            Console.ReadKey();
        }
    }
    class JustForFun
    {
        int i, j;
        public void showmessage(string message)// This defines the method "showmessage" | Void tells us that this message won't return a value to its caller | Message has been declared, and must be used within the method
        {
            Console.WriteLine(message);// The "Console" object will use the method "WriteLine" to output the string "message"
        }

        public void // Tells the compiler that there's nothing to be returned
            showmessage// This is the method's name
            (int intmessage)// This/these are argunemt(s) being sent into the method
        {
            Console.Write(intmessage);
        }
        public string getline()
        {
            string var // Declares string "var"
                = Console.ReadLine();// Assigns a value to "var" based on the user's input to "Console"
            Console.WriteLine(var);
            return var;
        }
    }

}
