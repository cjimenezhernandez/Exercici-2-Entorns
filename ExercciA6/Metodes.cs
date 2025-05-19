using System;
using System.Collections.Generic;

public class Metodes
{
    public static List<int> comptadorMultiples(int limit)
    {
        List<int> multiples = new List<int>();

        for (int i = 1; i < limit; i++)
        {
            if (i % 7 == 0)
            {
                multiples.Add(i);
            }
        }

        return multiples;
    }
}
