using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qwick_Foodz
{
    public interface IBalance
    {
        //properties
        public int WalletBalance { get;  }

        //methods
        //only define
        public void WalletRecharge(int money);
        public void DeductBalance(int Money);
    }
}