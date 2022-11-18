using System;

namespace ConsoleApp2
{
    class User
    {
        public User(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public override string ToString() => $"Id - {Id}, Login - {Login}, Password - {Password}.";
    }
    class Program
    {
        static void Main()
        {
            User anna = new User(1, "Anna226", "1234");
            User olga = new User(2, "Olga99", "qwerty");
            Console.WriteLine(anna);
            Console.WriteLine(olga);
            User[] users = { anna, olga };
            foreach (User i in users)
            {
                Console.WriteLine(i);
            }
        }
    }
}
