using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class passwordverification
    {
        static void Main(string[] args)

        {
            string userchoice = string.Empty;
            do
            {

                string orgusername = "MaheshPonnapalli";
                string orgpassword = "27may2004@mahi";
                int attempts = 0;
                int maxattempts = 3;
                while (attempts < maxattempts)
                {
                    Console.Write("Enter username:");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password:");
                    string Password = Console.ReadLine();
                    if (username == orgusername && Password == orgpassword)
                    {
                        Console.WriteLine("Login successful");
                        Console.WriteLine("Welcome {0}", orgusername);
                        break;
                    }
                    else if (username == orgusername && Password != orgpassword)
                    {
                        Console.WriteLine("password was incorrect");
                        attempts++;
                    }
                    else if (username != orgusername && Password == orgpassword)
                    {
                        Console.WriteLine("username not exist");
                        attempts++;
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Both username and password were incorrect");
                        
                    }
                    if (attempts < maxattempts)
                    {
                        Console.WriteLine("Do you want to try again type yes or no:");
                    }
                    else
                    {
                        
                        break;
                    }
                    userchoice = Console.ReadLine().ToUpper();
                    do
                    {
                        
                        if (userchoice != "YES" && userchoice != "NO")
                        {
                            Console.WriteLine("Invalid choice say yes or no!!");
                        }
                        
                    } while (userchoice != "YES" && userchoice != "NO");


                    
                }
                if (attempts == maxattempts)
                {
                    Console.WriteLine("maximum limit reached try after some time");
                    break;
                }
            } while (userchoice == "yes");
           
        }
    }
    }
