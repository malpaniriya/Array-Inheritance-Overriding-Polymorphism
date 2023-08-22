using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    //Create Class Account
    //Account Has : Account Number, Account Type, Balance
    //- Create 1st Method to accept the account details
    //- Create 2nd Method to show account details
    //- Create 3rd method to widraw the money from current balance
    //- Create 4th Method to deposits money to the current balance
    public class Account
    {
        private int Acc_No;
        private string Acc_type;
        private double Acc_bal;

        public void Accept(int Acc_No, string Acc_type, double Acc_bal)
        {
            this.Acc_No = Acc_No;
            this.Acc_type = Acc_type;
            this.Acc_bal = Acc_bal;
        }

        public string Show()
        {
            return $"Account number{Acc_No}\n, Account Type{Acc_type},Account Balance{Acc_bal}";
        }
        public void WithdrawMoney(int Amount)
        {
            if (Acc_bal > Amount)
            {
                Acc_bal = Acc_bal- Amount;
                Console.WriteLine($"Balance after withdrawing money={Acc_bal}\n");
            }
            
        }
    }
}
