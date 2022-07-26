using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
     class StringOperations
    {
        public int findLength(string str)
        {
            return str.Length;
        }
        public string reverseString(string str)
        {
            char[] reverseString = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--) ;
            {
                char c = reverseString[i];
                reverseString[i] = reverseString[j];
                reverseString[j] = c;

            }
            return new string(reverseString);
        }
       
       public static void Main(string[] args)
        {
            int ch;
            do
            {
                StringOperations so = new StringOperations();
                Console.WriteLine("-----------------");
                Console.WriteLine("enter your choice :\n1.find length of string \n2,reverse String\n3.compare two strings\n4.exit");
                Console.WriteLine("--------------------------");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter a string to find length: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("length of {0} is : {1}", str, so.findLength(str));
                        break;
                    case 2:
                        Console.WriteLine("enter a string to reverse it:");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("reverse of {0} is :{1}", str2, so.reverseString(str2));
                        break;
                    case 3:
                        Console.WriteLine("enter 1st string:");
                        string str3 = Console.ReadLine();
                        Console.WriteLine("enter 2nd string :");
                        string str4 = Console.ReadLine();
                        if (str3.Equals(str4))
                        {
                            Console.WriteLine("{0} and {1} are equal.", str3, str4);
                        }
                        else
                        {
                            Console.WriteLine("{0} and {1} are not equal", str3, str4);
                        }
                        break;
                    case 4:
                        Console.WriteLine("bye!");
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;
                }
            } while (ch != 4);

                 
            
       }
     }
}
