using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridClass2
{
    public interface ICalculate
    {
        public void Deposit(int money);
        public void WithDraw(int money);
        public void BalanceCheck();
    }
}