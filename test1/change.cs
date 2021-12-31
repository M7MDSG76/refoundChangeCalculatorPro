using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class change
    {
        
        public int FiveHundered { get; set; }
        public int Onehundred { get; set; }
        public int Fifty { get; set; }
        public int Tweinty { get; set; }
        public int Ten { get; set; }
        public int Five { get; set; }
        public int Two { get; set; }
        public int One { get; set; }

        public void Change(int input)
        {
            FiveHundered = input / 500;
            input %= 500;
          for(int i = 1; i <= FiveHundered;i++)
                Console.Write( "\t500");
            Onehundred = input / 100;
            input %= 100;
            for (int i = 1; i <= Onehundred; i++)
                Console.Write("\t100");
            Fifty = input / 50;
            input %= 50;
            for (int i = 1; i <=Fifty; i++)
                Console.Write("\t50");
            Tweinty = input / 20;
            input %= 20;
            for (int i = 1; i <= Tweinty; i++)
                Console.Write("\t20");
            Ten = input / 10;
            input %= 10;
            for (int i = 1; i <=Ten; i++)
                Console.Write("\t10");
            Five = input / 5;
            input %= 5;
            for (int i = 1; i <= Five; i++)
                Console.Write("\t5");
            Two = input / 2;
            input %= 2;
            for (int i = 1; i <= Two; i++)
                Console.Write("\t2");
            One = input / 1;
            input %= 1;
            for (int i = 1; i <= One; i++)
                Console.Write("\t1");
        }
        public void App()
        {
            Console.WriteLine("enter Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Paid: ");
            int paid = int.Parse(Console.ReadLine());
            int refound = paid - price;
            Console.WriteLine($"refound: {refound} ,");
            change Customer = new change();
            Customer.Change(refound);
        }
    }
}
