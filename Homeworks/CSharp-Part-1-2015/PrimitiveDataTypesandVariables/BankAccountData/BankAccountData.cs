//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types
//and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        decimal accountBalance = 957.42m;
        string bankName = "Burkan Bank EAD";
        string IBAN = "BG48BKBK91301011253302";
        long creditCard1 = 4539796271822228;
        long creditCard2 = 4716242088821017;
        long creditCard3 = 4929251871136908;
    }
}

