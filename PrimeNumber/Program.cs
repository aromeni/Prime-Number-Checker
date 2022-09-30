
// a prime number is a number that is divisible only by itself and 1
// should have only two divisors/
// iterate between 1 and number inputted by user and check if divisors == 2

int userNumber = 0;
int tempNumnber;
string userInput ="";

do
{
    Console.WriteLine("Enter a number to determine if it is a prime number: ");
    userInput = Console.ReadLine();

    bool userEntry = int.TryParse(userInput, out tempNumnber);
    if (userEntry)
    {
        userNumber = tempNumnber;
        int divisor = 0;
        for (int i = 1; i <= userNumber; i++)
        {
            if (userNumber % i == 0)
            {
                divisor++;
            }
        }

        if (divisor == 2)
        {
            Console.WriteLine("{0} is prime number.", userNumber);
        }
        else
        {
            Console.WriteLine("{0} is not a prime number.", userNumber);
        }
    }
    else
    {
        Console.WriteLine("Sorry, Invalid Entry. Please enter a postive integer to check: ");
    }
}
while (userNumber > 0);










