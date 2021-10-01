using PS.Domain;
using System;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World!");
            Provider P1 = new Provider
            {
                UserName = "Provider1",
                Password = "12345",
                ConfirmPassword = "12345",
                IsApproved = false
            };

            //System.Console.WriteLine("Méthode a");
            //Provider.SetIsApproved(P1);
            //P1.GetDetails();
            //System.Console.WriteLine("Méthode b");
            //Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, P1.IsApproved);
            //P1.GetDetails();
            System.Console.WriteLine("Méthode b");
            P1.IsApproved = Provider.SetIsApproved(P1.Password, P1.ConfirmPassword);
            P1.GetDetails();
        }
    }
}
