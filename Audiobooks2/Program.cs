namespace Audiobooks2;

class Program
{
    static void Main(string[] args)
    {

        double priceOfA = 9.95;
        int booksIncludedA = 10;
        double additionalBooksA = 2.00;

        double priceOfB = 13.95;
        double additionalBooksB = 1.00;
        int booksIncludedB = 20;
        double priceOfC = 19.95;
        double additionalBooksC = 0;
        int booksIncludedC = -1;

        string[] validChoices = new string[] { "A", "B", "C" };

        char choice = new char();
        string response = new string("");
        int numBooks = 0;
        int extraBooks = 0;
        double totalCharges = 0;

       




        while (!Char.IsAsciiLetter(choice))
        {
            Console.WriteLine($"Enter the letter of the Audiobooks package you purchased (A, B, or C)");
            response = Console.ReadLine();
            if (String.IsNullOrEmpty(response) || !validChoices.Contains(response))
            {
                response = "&";
                Console.WriteLine("Invalid Choice Entered, please try again :)");
            }
            else
            {
                choice = response.ToCharArray()[0];
            }
        }

        do
        {
            Console.WriteLine("Enter the number of audiobooks that you read: ");
            numBooks = Convert.ToInt32(Console.ReadLine());
            if (numBooks <= 0)
            {
                Console.WriteLine("Error, number must be greater than or equal to 0");
            }
        } while (numBooks <= 0);

        if (choice == 'A')
        {
            if (booksIncludedA < 0) // unlimited
            {
                totalCharges = priceOfA;
            }
            else
            {
                if (numBooks - booksIncludedA <= 0)
                {
                    extraBooks = 0;
                }
                else
                {
                    extraBooks = numBooks - booksIncludedA;
                }
                totalCharges = priceOfA + (extraBooks * additionalBooksA);
            }
        }

        if (choice == 'B')
        {
            if (booksIncludedB < 0)
            {
                totalCharges = priceOfB;
            }
            else
            {
                if (numBooks - booksIncludedB <= 0)
                {
                    extraBooks = 0;
                }
                else
                {
                    extraBooks = numBooks - booksIncludedB;
                }
                totalCharges = priceOfB + (extraBooks * additionalBooksB);
            }
        }

        if (choice == 'C')
        {
            if (booksIncludedC < 0)
            {
                totalCharges = priceOfC;
            }
            else
            {
                if (numBooks - booksIncludedC <= 0)
                {
                    extraBooks = 0;
                }
                else
                {
                    extraBooks = numBooks - booksIncludedC;
                }
                totalCharges = priceOfC + (extraBooks + additionalBooksC);
            }

        }
        Console.WriteLine($"Total charges for {numBooks} {(numBooks > 1 ? "books" : "book")} with plan {choice} is ${totalCharges}");
    }

}

    


