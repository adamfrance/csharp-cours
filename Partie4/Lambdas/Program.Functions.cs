partial class Program
{
    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11: // Special cases for 11th to 13th.
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }

    // static int FibImperative(uint term)
    // {
    //     if (term == 0)
    //     {
    //         throw new ArgumentOutOfRangeException();
    //     }
    //     else if (term == 1)
    //     {
    //         return 0;
    //     }
    //     else if (term == 2)
    //     {
    //         return 1;
    //     }
    //     else
    //     {
    //         return FibImperative(term - 1) + FibImperative(term - 2);
    //     }
    // }

    // static void RunFibImperative()
    // {
    //     for (uint i = 1; i <= 30; i++)
    //     {
    //         WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
    //           arg0: CardinalToOrdinal(i),
    //           arg1: FibImperative(term: i));
    //     }
    // }

    static int FibFunctional(uint term) => term switch
    {
        0 => throw new ArgumentOutOfRangeException(),
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };

    static void RunFibFunctional()
    {
        for (uint i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
              arg0: CardinalToOrdinal(i),
              arg1: FibFunctional(term: i));
        }
    }


}