namespace BankAccounts
{
    using BankAccounts.Interfaces;
    using BankAccounts.Models;

    public class Start
    {
        public static void Main()
        {
            var testAcount = new DepositAccount(new Company("Abc", "040304123"), 3.47m);
            System.Console.WriteLine(testAcount);
            System.Console.WriteLine(testAcount.Deposit(1200m));
            System.Console.WriteLine(testAcount.Withdraw(-101m));
            System.Console.WriteLine(testAcount.CalculateInterest(10));
            var anotherTest = new MortgageAccount(new Company("Abc", "040304123"), 5);
            System.Console.WriteLine(anotherTest.Deposit(120m));
            System.Console.WriteLine(anotherTest.CalculateInterest(13));
        }
    }
}
