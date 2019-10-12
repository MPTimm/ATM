using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATM
    {
        private int Note50;
        private int Note10;
        private int Note5;
        private int Note1;
        private double balance;

        public void calculateNotes(int value)
        {
            int bkp = value;

            while (value > 0)
            {
                //Calculate amount of banknotes of 50
                if (value >= 50)
                    Note50 = value / 50;

                //Calculate de currently value of withdraw
                value %= 50;

                //Calculate amount of banknotes of 10
                if (value >= 10)
                    Note10 = value / 10;

                //Calculate de currently value of withdraw
                value %= 10;

                //Calculate amount of banknotes of 5
                if (value >= 5)
                    Note5 = value / 5;

                //Calculate de currently value of withdraw
                value %= 5;

                //Calculate amount of banknotes of 1
                if (value >= 1)
                    Note1 = value / 1;

                //Calculate de currently value of withdraw
                value %= 1;
            }

            Console.WriteLine(Note50 + "\n");
            Console.WriteLine(Note10 + "\n");
            Console.WriteLine(Note5 + "\n");
            Console.WriteLine(Note1 + "\n");

            balance -= bkp;
        }

        public void Deposit(int value)
        {
            balance += value;
        }

        public void ViewBalance()
        {
            Console.WriteLine("Seu saldo atual é de:" + balance);
        }
    }
}
