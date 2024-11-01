using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    public class Cuenta
    {
        private string _accountnum;
        private string _accountholder;
        private int _balance;

        public Cuenta()
        {
            _accountnum = "000000000"; 
            _accountholder = "Sin titular";     
            _balance = 0;                 
        }
        public Cuenta(string accountnum, string accountholder, int balance)
        {
            _accountnum = accountnum;
            _accountholder = accountholder;
            _balance = balance;
        }
        public string Accountnum
        {
            get => _accountnum;
            set => _accountnum = value;
        }
        public string Accountholder
        {
            get => _accountholder;
            set => _accountholder = value;
        }
        public int Balance
        {
            get => _balance;
            set => _balance = value;
        }

        public void Deposit(int amount)
        {
            if (amount < 0) { Console.WriteLine("La cantidad debe ser postiva"); }
            else { Balance += amount; }
        }
        public void Withdraw(int amount)
        {
            if (amount > Balance) { Console.WriteLine("La cantidad que desea sacar es mayor a su balance"); }
            else { Balance -= amount; }
        }
        public void Transfer(int amount, string destinyaccount)
        {
            if (amount <= 0) { Console.WriteLine("Transaccion invalida"); }
            else { Balance -= amount; Console.WriteLine($"Se realizo la transferencia de {amount} a la cuenta {destinyaccount}\n"); }
        }
        public void ShowAccount()
        {
            Console.WriteLine($"Titular de la cuenta: {Accountholder}\nNumero de Cuenta: {Accountnum}\nSaldo de la cuenta: {Balance}\n");
        }
    }
}