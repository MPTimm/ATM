using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            Console.WriteLine("Olá, digite o valor do saque:");
            int Withdraw = Convert.ToInt32(Console.ReadLine());

            atm.calculateNotes(Withdraw);

            atm.ViewBalance();

            atm.Deposit(1000);

            atm.ViewBalance();


        }
    }
}
