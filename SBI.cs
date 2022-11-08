using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class SBI : Ibank
    {
        public override void ValidateCard()
        {
            Console.WriteLine("SBI bank card validation");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI bank withdraw money ");
        }
        public override void CheckBalance()
        {
            Console.WriteLine("SBI bank check balance");
        }
        public override void BankTransfer()
        {
            Console.WriteLine("Welcome to SBI Bank transfer ");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("SBI bank Mini Statement");
        }
    }
}
