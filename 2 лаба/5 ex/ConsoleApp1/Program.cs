using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                { "Admin","adminA"},
                {"User","userU"},
                {"Owner","ownerO"}
            };

            Dictionary<string, string> status = new Dictionary<string, string>()
            {
                { "Admin","admin"},
                {"User","user"},
                {"Owner","owner"}
            };

            for (; ; )
            {
                Console.WriteLine(" ");
                Console.WriteLine("Write '1' if U want to login");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    string login = AskLogin(data);
                    string password = AskPassword(login, data);
                    string stat = status[login];
                    Console.WriteLine("Your status " + stat);
                    if (stat == "admin")
                    {
                        for (; ; )
                        {
                            Console.WriteLine("Write '+' if U wont to create new user or '-' if no");
                            string otvet = Console.ReadLine();
                            if (otvet == "+")
                            {
                                AddUser(data, status);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    Console.WriteLine("Do u want to log out? 1 - yes  2 - if no");
                    string otvet2 = Console.ReadLine();

                    if (otvet2 == "2")
                    {
                        break;
                    }

                }
                else
                {
                    break;
                }
            }


        }

        static string AskLogin(Dictionary<string, string> data)
        {
            for (; ; )
            {
                Console.WriteLine(" ");
                Console.WriteLine("Write login pls");
                string login = Console.ReadLine();
                if (data.ContainsKey(login))
                {
                    return login;
                }
                Console.WriteLine("Wrong login");
            }
        }

        static string AskPassword(string login, Dictionary<string, string> data)
        {
            string password;
            for (; ; )
            {
                Console.WriteLine(" ");
                Console.WriteLine("Write password pls");
                password = Console.ReadLine();
                if (password == data[login])
                {
                    Console.WriteLine("You are logged in");
                    return password;
                }
                Console.WriteLine("Wrong password");
            }
        }

        static void AddUser(Dictionary<string, string> data, Dictionary<string, string> status)
        {
            string login;
            string password;
            for (; ; )
            {
                Console.WriteLine(" ");
                Console.WriteLine("Write login of new user");
                login = Console.ReadLine();
                if (data.ContainsKey(login))
                {
                    Console.WriteLine("This login is already taken");
                }
                else
                {
                    break;
                }
            }

            for (; ; )
            {
                Console.WriteLine(" ");
                Console.WriteLine("Write password of new user");
                password = Console.ReadLine();

                Console.WriteLine("Write password one more time");
                string passwordChek = Console.ReadLine();

                if (password == passwordChek)
                {
                    break;
                }
                Console.WriteLine("Passwords mismatch");
            }

            data.Add(login, password);
            status.Add(login, "user");
            Console.WriteLine(" ");
            Console.WriteLine("New user created ");
        }

    }
}
