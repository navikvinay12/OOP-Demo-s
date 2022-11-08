using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal abstract class Ibank
    {
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void CheckBalance();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }
}
