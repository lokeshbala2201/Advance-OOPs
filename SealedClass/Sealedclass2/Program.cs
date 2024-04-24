using System;
using Sealedclass2;
namespace SealedClass2;
class Program
{
    public static void Main(string[] args)
    {
        Patientinfo patinet1=new Patientinfo("Loki","Bala",101,"Chennai","Fever");
        DoctorInfo Doctor1=new DoctorInfo("Loki","Bala",101,"Chennai","Fever","Vasudevan","Dev"); //sealed class cannot inherit to other classes
        Doctor1.DisplayInfo();
    }
}