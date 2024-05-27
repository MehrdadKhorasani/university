using System.Collections.Generic;

namespace BankApp
{
    public class User
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
    public class Bank
    {
        private List<User> users = new List<User>();
        private int nextId = 100;

        public void CreateUser(string name, decimal balance)
        {
            var user = new User(name, nextId++, balance);
            users.Add(user);
        }

        public bool Increase(int id, decimal amount)
        {
            var user = users.Find(u => u.Id == id);
            if (user != null)
            {
                user.Balance += amount;
                return true;
            }
            return false;
        }

        public bool Decrease(int id, decimal amount)
        {
            var user = users.Find(u => u.Id == id);
            if (user != null && user.Balance >= amount)
            {
                user.Balance -= amount;
                return true;
            }
            return false;
        }

        public bool Transfer(int id1, decimal amount, int id2)
        {
            var user1 = users.Find(u => u.Id == id1);
            var user2 = users.Find(u => u.Id == id2);

            if (user1 != null && user2 != null && user1.Balance >= amount)
            {
                user1.Balance -= amount;
                user2.Balance += amount;
                return true;
            }
            return false;
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }

}
