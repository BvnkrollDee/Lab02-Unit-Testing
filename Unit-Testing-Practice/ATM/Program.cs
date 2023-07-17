namespace ATM;

public class Program
{
    public static decimal balance;

    static void Main(string[] args) {

    
        balance = 0;
        userInterface();
    }


    static void userInterface()
    {
        Console.WriteLine("Welcome to the Bank broke boi let's get you some mun yunn");

        while (true)
        {
            Console.WriteLine("Here's the menu");
            Console.WriteLine("To view balance press 1");
            Console.WriteLine("To Withdraw press 2");
            Console.WriteLine("To deposit press 3");
            Console.WriteLine("To exit press 4");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                decimal userBalance = ViewBalance();
                Console.WriteLine("Here's your balance {0}", userBalance);
            }
            else if (userInput == "2")
            {
                
                //decimal userBalance = Withdraw(moneyTakenOut);
                if (balance <= 0)
                {
                    Console.WriteLine("you ain't nothing but a broke boi boi boi boiiii");
                }
                else
                {
                    Console.WriteLine("Choose the amount you would like to withdraw");
                    string amountWithdrawn = Console.ReadLine();
                    decimal moneyTakenOut = Convert.ToDecimal(amountWithdrawn);
                    decimal userBalance = Withdraw(moneyTakenOut);
                };
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Pick an amount to deposit.");
                string amountPutIn = Console.ReadLine();
                decimal moneyPutIn = Convert.ToDecimal(amountPutIn);
                //decimal userBalance = Deposit(moneyPutIn);
                if (moneyPutIn <= 0)
                {
                    Console.WriteLine("You cannot do that!");
                }
                else {
                    decimal userBalance = Deposit(moneyPutIn);
                };
            }else if(userInput == "4")
            {
                Console.WriteLine("Come back with some more money next time!");
                Exit();
            };
        }
    }

public static decimal ViewBalance()
    {
        decimal userBalance = balance;

    return balance;

    }

static decimal Withdraw(decimal withdrawAmount)
    {
        balance = balance - withdrawAmount;

        return balance;

    }

    static decimal Deposit(decimal depositAmount)
    {
        balance = balance + depositAmount;

        return balance;
    }


    static bool Exit()
    {
        return false;
    }


 }



