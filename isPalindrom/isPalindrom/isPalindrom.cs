using System;

namespace isPalindrom
{
    class isPolindr
    {
        

        static void Main(string[] args)
        {
            

            string str = "";
            bool isPal;
            char key = '1';

            if (args.Length != 0)
            {
                key = '1';
                foreach (string st in args)
                    str += st;
            }
                

            while (true)
            {
                if (str == "")
                {
                    menu();
                    key = Console.ReadLine()[0];
                } 
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        if (str == "")
                        {
                            Console.WriteLine("Enter your palindrom:");
                            str = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(str);
                        }
                        str = MissSymbols(str);
                        isPal = true;
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (str[i] != str[str.Length - i - 1])
                            {
                                isPal = false;
                                break;
                            }
                        }

                        if (isPal) Console.WriteLine("Your string is the palindrom");
                        else Console.WriteLine("Your string is not the palindrom");

                        Console.WriteLine("Press any button");
                        Console.ReadKey();
                        str = "";
                        break;
                    case '0':
                        return;
                }
            }
        }

        static string MissSymbols(string str)
        {
            string outp = "";
            foreach (char ch in str)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    outp += ch;
                }
            }
            return outp;
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("1. Approve that string is palindrome");
            Console.WriteLine("0. Exit");
        }
    }
}
