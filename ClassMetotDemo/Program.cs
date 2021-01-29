using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            customer customer1 = new customer(); //yeni bir müşteri tanımlıyoruz
            customer1.id = 001;
            customer1.name = "Alex Smith";
            customer1.cell = 3547492;
            customer1.totalbalance = 26945.00;
            customer1.securityanswer = " Ares.";

            customer customer2 = new customer();

            customer2.id = 002;
            customer2.name = "John Adams";
            customer2.cell = 4954730;
            customer2.totalbalance = -34936.87;
            customer2.securityanswer = "1989";

            customer customer3 = new customer();
            customer3.id = 003;
            customer3.name = "Jane Alba";
            customer3.cell = 6429892;
            customer3.totalbalance = 43683.65;
            customer3.securityanswer = "Denmark";

            customer customer4 = new customer();

            customer4.id = 004;
            customer4.name = "Ben Adler";
            customer4.cell = 9841004;
            customer4.totalbalance = -283204.93;
            customer4.securityanswer = "Smith";

            customer[] customers = new customer[] { customer1  , customer2 , customer3 , customer4  };
            foreach (customer customer in customers)
            {
                Console.WriteLine("----Customer List----")
                Console.WriteLine("Name: " + customer.name);
                Console.WriteLine("ID: " +customer.id);
                Console.WriteLine("Cell Number: " + customer.cell);
                Console.WriteLine("Total Balance: " + customer.totalbalance + "$");
                Console.WriteLine("Security Answer: " + customer.securityanswer);
            }

            Console.ReadKey();

        }
    }

    class customer 
    {
        public string name { get; set; }
        public int cell { get; set; }
        public int id { get; set; }
        public double totalbalance { get; set; }
        public string securityanswer { get; set; }

    }
}
