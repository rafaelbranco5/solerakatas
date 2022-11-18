using System;

 

public class Class1
{
    public Class1()
    {
    }

 

    private bool checkDimensions(CLIQEUNIT other, int e)
    {
        for(int i = 0, j = 0; i < e; i++, j += 2)
        {
            // Bug was in the final part of the If Satetement, where it was comparing bounds to itself.
            // Fixed by replacing bounds[j + 1] with others.bounds[j + 1]
            if (dims[i] != other.dims || bounds[j] != other.bounds[j] || bounds[j + 1] != other.bounds[j + 1]) 
            {
                return false;
            }
        }

 

        return true;

 

    }

 

}