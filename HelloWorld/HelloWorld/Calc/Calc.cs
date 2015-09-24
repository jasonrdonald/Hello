using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Calculator
{
    public class Calc
    {
        private double m_balance;// { get; set; }
        public double Balance { get { return m_balance; } set { m_balance = value; } }
        public string name { get; set; }

        public void Withdraw(double amount)
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException(amount.ToString(), "Withdrawal exceeds balance!");
            }
        }

        public Calc(string cname, double balance)
        {
            this.Balance = balance;
            this.name = cname;
        }
    }
}