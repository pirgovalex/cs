using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class Client
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Purchases { get; set; }
        public float Sum { get; set; }
        public string Rating
        {
            get
            {
                if (Purchases < 100)
                {
                    return "*";
                }
                else if (100 <= Purchases && Purchases <= 299)
                {
                    return "**";
                }
                else if (300 <= Purchases && Purchases <= 499)
                {
                    return "***";
                }
                else if (500 <= Purchases && Purchases <= 999)
                {
                    return "****";
                }
                else if (1000 <= Purchases && Purchases <= 9999)
                {
                    return "*****";
                }
                else
                {
                    return "invalid input detected";
                }
            }
        }

        public Client(string name, string date, int purchases, float sum)
        {
            Name = name;
            Date = date;
            Purchases = purchases;
            Sum = sum;
        }

        public static Client CreateClientFromInput()
        {
            Console.Write("Please input Name ");
            string name = Console.ReadLine();

            Console.Write("Please input Login Date ");
            string date = Console.ReadLine();

            Console.Write("Please input Purchases ");
            int purchases = int.Parse(Console.ReadLine());

            Console.Write("Please input sum of purchases ");
            float sum = float.Parse(Console.ReadLine());

            return new Client(name, date, purchases, sum);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Date: {Date}, Purchases: {Purchases}, Sum: {Sum}, Rating: {Rating}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            List<Client> clients = new List<Client>();
            for (int i = 0; i < n; i++)
            {
                clients.Add(Client.CreateClientFromInput());
            }

            var filteredClients = clients.Where(c => c.Rating == "**").ToList();
            filteredClients.Sort((x, y) => y.Sum.CompareTo(x.Sum));
            filteredClients.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (Client client in clients)
            {
                Console.WriteLine(client);
            }

            Console.WriteLine("--------------------------------------");

            foreach (Client client in filteredClients)
            {
                Console.WriteLine(client);
            }

            Console.Write("Please input rating to find ");
            int userfindrating = int.Parse(Console.ReadLine());
            string rating = new string('*', userfindrating);

            var filteredbyuser = clients.Where(n => n.Rating == rating).GroupBy(c => c.Date.Split('.').Last()).OrderBy(g => g.Key);

            foreach (var group in filteredbyuser)
            {
                Console.WriteLine($"Year: {group.Key}");
                foreach (Client client in group)
                {
                    Console.WriteLine(client);
                }
            }
        }
    }
}
