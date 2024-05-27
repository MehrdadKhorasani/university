using System;
using System.Collections.Generic;

namespace Banker
{
    // User class
    class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public User(string name, int id, decimal balance)
        {
            Name = name;
            Id = id;
            Balance = balance;
        }
    }

    // Bank operations class
    class Bank
    {
        private List<User> users = new List<User>();
        private int nextId = 100;

        // Create User Method
        public void CreateUser(string name, decimal balance)
        {
            var user = new User(name, nextId++, balance);
            users.Add(user);
            Console.WriteLine($"User {name} created with ID {user.Id} and balance {balance}");
        }

        // Increase Balance Method
        public void Increase(int id, decimal amount)
        {
            var user = users.Find(u => u.Id == id);
            if (user != null)
            {
                user.Balance += amount;
                Console.WriteLine($"Increased {amount} to user ID {id}. New balance: {user.Balance}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        // Decrease Balance Method
        public void Decrease(int id, decimal amount)
        {
            var user = users.Find(u => u.Id == id);
            if (user != null)
            {
                // Check if user has the money!
                if (user.Balance >= amount)
                {
                    user.Balance -= amount;
                    Console.WriteLine($"Decreased {amount} from user ID {id}. New balance: {user.Balance}");
                }
                else
                {
                    Console.WriteLine("User doesn't have enough Money!");
                }
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        // Transfer Balance Method
        public void Transfer(int id1, decimal amount, int id2)
        {
            var user1 = users.Find(u => u.Id == id1);
            var user2 = users.Find(u => u.Id == id2);

            if (user1 != null && user2 != null)
            {
                if (user1.Balance >= amount)
                {
                    user1.Balance -= amount;
                    user2.Balance += amount;
                    Console.WriteLine($"Transferred {amount} from user ID {id1} to user ID {id2}. New balances: {user1.Balance} (ID {id1}), {user2.Balance} (ID {id2})");
                }
                else
                {
                    Console.WriteLine("User doesn't have enough Money for transfer!");
                }
            }
            else
            {
                Console.WriteLine("One or both users not found.");
            }
        }

        // Display Users Method
        public void DisplayUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Balance: {user.Balance}");
            }
        }
    }

    // Users with username & password (Authentication)
    class AuthUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public AuthUser(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    class Program
    {
        static List<AuthUser> authUsers = new List<AuthUser>
        {
            new AuthUser("admin", "1234")
        };

        static bool Authenticate(string username, string password)
        {
            foreach (var authUser in authUsers)
            {
                if (authUser.Username == username && authUser.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Increase Balance");
                Console.WriteLine("3. Decrease Balance");
                Console.WriteLine("4. Transfer Balance");
                Console.WriteLine("5. Display Users");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter admin username: ");
                        string username = Console.ReadLine() ?? "";
                        Console.Write("Enter admin password: ");
                        string password = Console.ReadLine() ?? "";

                        if (Authenticate(username, password))
                        {
                            Console.Write("Enter user name: ");
                            string name = Console.ReadLine() ?? "";
                            Console.Write("Enter initial balance: ");
                            decimal balance = decimal.Parse(Console.ReadLine() ?? "");
                            bank.CreateUser(name, balance);
                        }
                        else
                        {
                            Console.WriteLine("Authentication failed. User not authorized to create new users.");
                        }
                        break;
                    case "2":
                        Console.Write("Enter user ID to increase balance: ");
                        int idIncrease = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("Enter amount to increase: ");
                        decimal amountIncrease = decimal.Parse(Console.ReadLine() ?? "");
                        bank.Increase(idIncrease, amountIncrease);
                        break;
                    case "3":
                        Console.Write("Enter user ID to decrease balance: ");
                        int idDecrease = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("Enter amount to decrease: ");
                        decimal amountDecrease = decimal.Parse(Console.ReadLine() ?? "");
                        bank.Decrease(idDecrease, amountDecrease);
                        break;
                    case "4":
                        Console.Write("Enter sender user ID: ");
                        int idSender = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("Enter amount to transfer: ");
                        decimal amountTransfer = decimal.Parse(Console.ReadLine() ?? "");
                        Console.Write("Enter receiver user ID: ");
                        int idReceiver = int.Parse(Console.ReadLine() ?? "");
                        bank.Transfer(idSender, amountTransfer, idReceiver);
                        break;
                    case "5":
                        bank.DisplayUsers();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
