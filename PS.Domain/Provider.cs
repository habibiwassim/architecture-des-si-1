using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider : Concept
    {

        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }

        private string pwd;

        public string Password
        {
            get { return pwd; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20) { pwd = value; }
                else System.Console.WriteLine("Le mot de passe doit être dans l'intervalle [5,20]\n");
            }
        }


        private string confirmpassword;

        public string ConfirmPassword
        {

            get { return confirmpassword; }
            set
            {
                if (value.Equals(Password) == false) System.Console.WriteLine("Veuillez confirmer votre mot de passe");
                else
                {
                    confirmpassword = value;
                    System.Console.WriteLine("Confirmé !");
                }
            }
        }

        //public string ConfirmPassword { get; set; }


        public string UserName { get; set; }
        public IList<Product> Products { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("UserName: " + UserName + "\nIsApproved: " + IsApproved);
        }

        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = P.Password.CompareTo(P.ConfirmPassword) == 0;
        }

        public static void SetIsApproved(string password, string confirmPassword, bool isApproved)
        {
            isApproved = password.CompareTo(confirmPassword) == 0;
        }

        public static bool SetIsApproved(string password, string confirmPassword)
        {
            if (password.CompareTo(confirmPassword) == 0) return true;
            else return false;

        }
    }
}