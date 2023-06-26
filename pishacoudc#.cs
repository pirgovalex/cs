using System;
using System.Collections.Generic;
using System.Linq;



    public class Customer{
        public string Name {get;set;}
        public int Counter{get;set;}
        public int Room{get;set;}
        public float Price{get;set;}
        public DateTime expectedENTER{get;set;}
        public DateTime expectedEXIT{get;set;}
        public Customer Customer_Parse(string input)
    {
        string[] values = input.Split(' ');

        Customer customer = new Customer();
        customer.Name = values[0];
        customer.Counter = int.Parse(values[1]);
        customer.Room = int.Parse(values[2]);
        customer.Price = float.Parse(values[3]);
        customer.expectedENTER = DateTime.Parse(values[4]);
        customer.expectedEXIT = DateTime.Parse(values[5]);

        return customer;
    }


    }
    public class Program
    {
       static void Main(string[] args)
        {
            int n =2;
            List<Customer> customers=new List<Customer>();

            for(int i=0;i<=2;i++)
            {
                Console.Write("Please input Name,Number of people,room number,price,Check in and Check out\nPlease separate with ' ' ");
                Customer customer=new Customer();
                var input=Console.ReadLine();
                customer = customer.Customer_Parse(input);
                

                customers.Add(customer);
            }
            foreach (Customer c in customers)
            {
                Console.WriteLine($"name: {c.Name} how many people: {c.Counter} which room: {c.Room} Price: {c.Price} When they punched in: {c.expectedENTER} and out: {c.expectedEXIT}");

            }
         }
        } 

    

    