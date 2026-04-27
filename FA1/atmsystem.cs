using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class AtmSystem
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> bankBranches = new Dictionary<string, Dictionary<string, string>>();

            bankBranches.Add("FNB", new Dictionary<string, string>() { { "AccountNumber", "1010" }, { "Pin", "0000" }, { "Balance", "100000" } });
            bankBranches.Add("ABSA", new Dictionary<string, string>() { { "AccountNumber", "2020" }, { "Pin", "1111" }, { "Balance", "200000" } });
            bankBranches.Add("CAPITEC", new Dictionary<string, string>() { { "AccountNumber", "3030" }, { "Pin", "2222" }, { "Balance", "340000" } });
            bankBranches.Add("NEDBANK", new Dictionary<string, string>() { { "AccountNumber", "4040" }, { "Pin", "3333" }, { "Balance", "1000000" } });
            bankBranches.Add("AFRICAN BANK", new Dictionary<string, string>() { { "AccountNumber", "5050" }, { "Pin", "4444" }, { "Balance", "550000" } });

            Console.WriteLine("===== WELCOME TO ZS ATM SYSTEM =====");
            Console.WriteLine();
            Console.WriteLine("Choose a Bank Branch : ");
            foreach (var branch in bankBranches.Keys)
            {
                Console.WriteLine("- " + branch);
            }

            Console.Write("\nEnter Branch Name : ");
            string chosenBranch = Console.ReadLine().ToUpper();

            if (!bankBranches.ContainsKey(chosenBranch))
            {
                Console.WriteLine("Invalid Bank Branch!");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter Account Number : ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter Pin Number : ");
            string pinNumber = Console.ReadLine();

            if (bankBranches[chosenBranch]["AccountNumber"] != accountNumber || bankBranches[chosenBranch]["Pin"] != pinNumber)
            {
                Console.WriteLine("Invalid Account Number Or Pin Number!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nAccess Granted! Welcome!");

            while (true)
            {
                Console.WriteLine("\n===== CHOOSE A TRANSACTION =====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice : ");

                int transactionChoice;
                if (!int.TryParse(Console.ReadLine(), out transactionChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (transactionChoice)
                {
                    case 1:
                        double bal = Convert.ToDouble(bankBranches[chosenBranch]["Balance"]);
                        Console.WriteLine("Current Balance : R" + bal.ToString("F2"));
                        break;

                    case 2:
                        Console.Write("Enter Amount To Withdraw : R");
                        double withdrawAmount;
                        if (!double.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
                        {
                            Console.WriteLine("Invalid amount.");
                            break;
                        }
                        double currentBalance = Convert.ToDouble(bankBranches[chosenBranch]["Balance"]);
                        if (withdrawAmount > currentBalance)
                        {
                            Console.WriteLine("Insufficient Funds!");
                        }
                        else
                        {
                            currentBalance -= withdrawAmount;
                            bankBranches[chosenBranch]["Balance"] = currentBalance.ToString();
                            Console.WriteLine("Withdrawal Successful!");
                            Console.WriteLine("Amount Withdrawn : R" + withdrawAmount.ToString("F2"));
                            Console.WriteLine("New Balance      : R" + currentBalance.ToString("F2"));
                            Console.WriteLine("Transaction Time : " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));
                        }
                        break;

                    case 3:
                        Console.Write("Enter Amount To Deposit : R");
                        double depositAmount;
                        if (!double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                        {
                            Console.WriteLine("Invalid amount.");
                            break;
                        }
                        double currentBal = Convert.ToDouble(bankBranches[chosenBranch]["Balance"]);
                        currentBal += depositAmount;
                        bankBranches[chosenBranch]["Balance"] = currentBal.ToString();
                        Console.WriteLine("Deposit Successful!");
                        Console.WriteLine("Amount Deposited : R" + depositAmount.ToString("F2"));
                        Console.WriteLine("New Balance      : R" + currentBal.ToString("F2"));
                        Console.WriteLine("Transaction Time : " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));
                        break;

                    case 4:
                        Console.WriteLine("\nThank You For Using ZS ATM System!");
                        Console.WriteLine("Transaction Time : " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3 or 4.");
                        break;
                }
            }
        }
    }
}