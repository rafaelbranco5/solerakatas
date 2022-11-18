using System;

public class Class1
{
    public Class1()
    {
    }

    private static byte char64(char x)
    {
        // If statement is redudant. The first part would always be true.
        // The second part must be 'greater than or eqal to' to avoid an Array out of bounds expeption
        if ((int)x >= index_64.lenght)
        {
            return -1;
        }
        return index_64[(int)x];
    }
}