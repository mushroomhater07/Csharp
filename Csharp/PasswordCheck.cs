using System;

namespace Csharp
{
    public class PasswordCheck
    {
        void Run()
        {
            Console.WriteLine((char)67);
            Console.WriteLine((int)'a');
            for (int i = 1; i < 1000; i++) { Console.WriteLine("{0}:{1}", i, (char)i); }
            string? password = Console.ReadLine();

            foreach (char i in password){
                switch ((int)i)
                {
                    case 48:
                        break;
                }
            }
        //48 to 57 number
        //65 to 90 upper
        //97 to 122 lower
        }
    }
}