using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HybridClass2
{
    public class IDInfo:PersonalInfo
    {
        public int VoteID { get; set; }
        public long AdharID { get; set; }
        public string PanID { get; set; }
        public IDInfo(string name,DateTime dob,long phone,Gender gender,int voterID,long aadharId,string panID ):base(name,dob,phone,gender)
        {
            VoteID=voterID;
            AdharID=aadharId;
            PanID=panID;
        }

    }
}