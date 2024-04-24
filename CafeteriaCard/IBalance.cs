using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCard
{
    /// <summary>
    /// This is interface for IBalance <see cref="IBalance"/> 
    /// </summary>
    public interface IBalance
    {
        //property define
        int WalletBalance { get; }
        //method define 
        void WalletRecharge(int money);
        void DeductAmount(int money);    
    }
}