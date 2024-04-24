using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This interface contains the details of customer balance Details<see cref="IBalance"/> 
    /// </summary>
    public interface IBalance
    {
        //properties
        //only define
        public int Balance { get; set; }

        //method
        public void WalletRecharge(int money);
        public void DeductBalance(int money);
    }
}