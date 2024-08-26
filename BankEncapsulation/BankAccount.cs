namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0.00;

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public void Withdrawal(double amount)
    {
        if (amount > _balance)
        {
            _balance = _balance;
        }
        
        else
        {
            _balance -= amount;
        }
    }
    
    public double GetBalance()
    {
        return _balance; 
    }

    public void User()
    {
        Console.WriteLine("What are you here for today:  1(Deposit) or 2(Withdrawal)?");
        var userInput = double.Parse(Console.ReadLine());
            
        switch (userInput)
        {
            case 1:
                Console.WriteLine("How much are you depositing today?");

                var depositAmount = double.Parse(Console.ReadLine());
                Deposit(depositAmount);

                Console.WriteLine($"Your deposit is complete! Your balance is now ${GetBalance()}.");
                break;
                
            case 2:
                Console.WriteLine("Great, how much do you want to withdraw?");

                var withdrawAmount = double.Parse(Console.ReadLine());
                Withdrawal(withdrawAmount);

                Console.WriteLine($"Your withdrawal is complete! Your balance is now ${GetBalance()}.");
                break;
                
            default:
                Console.WriteLine("That is not a valid selection.  Try again: 1(Deposit) or 2(Withdrawal)?");
                break;
        }
        
        while (true)
        {
            
            Console.WriteLine("Anything else?  1(Deposit) or 2(Withdrawal) or 3(Exit)?");
            userInput = double.Parse(Console.ReadLine());
            
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("How much are you depositing today?");

                    var depositAmount = double.Parse(Console.ReadLine());
                    Deposit(depositAmount);

                    Console.WriteLine($"Your deposit is complete! Your balance is now ${GetBalance()}.");
                    break;

                case 2:
                    Console.WriteLine("Great, how much do you want to withdraw?");

                    var withdrawAmount = double.Parse(Console.ReadLine());
                    Withdrawal(withdrawAmount);

                    Console.WriteLine($"Your withdrawal is complete! Your balance is now ${GetBalance()}.");
                    break;
                
                case 3:
                    Console.WriteLine("Okay, have a great day!");
                    return;

                default:
                    Console.WriteLine("That is not a valid selection.  Try again: 1(Deposit) or 2(Withdrawal) or 3(Exit)?");
                    break;
            }
        }
    }
  
}