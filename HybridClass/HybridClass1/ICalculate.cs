using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HybridClass1
{
    public interface ICalculate
    {
        public int ProjectMark { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public void CalculateUG();
    }
}