using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string UI = "";

            string[] Pnum = new string[7];
            string[] Fname = new string[7];
            string[] Ad = new string[7];

            int shinV = 0;

            while (UI != "/")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("******** MENU ********");
                Console.WriteLine("<. Create New Contact");
                Console.WriteLine(">. View Contacts");
                Console.WriteLine("/. Exit");
                UI = Console.ReadLine();
                

                switch (UI)
                {
                    case "<":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter Name \n ");
                        for (int a = shinV ; a < 7; a++)
                        {
                            
                            Fname[a] = Console.ReadLine();
                            break;
                            
                        }
                    Console.WriteLine(" \n Name Saved as " + Fname[shinV] );
                    Console.WriteLine(" \n Enter " + Fname[shinV] + "'s Phone number");

                       for (int b = shinV; b < 7; b++)
                        {
                          Pnum[b] = Console.ReadLine();
                            
                            break;
                         }

                        Console.WriteLine("Saved \n ");
                        Console.WriteLine(" \n The saved number is " + Pnum[shinV]);
                        Console.WriteLine("\n Enter " + Fname[shinV] + "'s Address ");
                        
                        for (int m = shinV; m < 7; m++)
                        {
                            Ad[m] = Console.ReadLine();
                            break;
                        }
                        Console.WriteLine(" \n The address " + Ad[shinV] + " is saved \n ");
                        shinV++;
                        Console.WriteLine("Creation Process Completed");

                        Console.Read();


                        break;
                case ">":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("View Contacts");
                        for (int q = 0; q < 7; q++)
                        {
                            Console.WriteLine(q + ". Name: " + Fname[q] + " \n   Number: " + Pnum[q] + "\n   Address: " + Ad[q] + "\n \n" );
                            
                        }

                       Console.Read();
                        break;
                case "/":
                    Console.WriteLine("Exit");
                    break;
                                        
            }
            }
            Console.Read();
        }
    }
}
