using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IFamilyInfo : IShowData
    {
        public string FatherName { get; set; }
        public string MotherName { get; set; }

        
    }

}