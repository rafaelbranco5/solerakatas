using System;

public class Class1
{
    public Class1()
    {
    }

     protected PreDeConModel computeLocalModel(DoubleDBIDList neighbors, ....)
    {
        final int referenceSetSize = neighbors.size();
        ....
        //Shouldn´t happen:
        // If statement should include the possibility of variable referenceSetSize being 0, otherwise the code might attempt to divide by 0 in the following for loop
        if(referenceSetSize <= 0)
        {
            LOG.warning("Empty reference set - should at least include the query point!");
            return new PreDeConModel(Intger.MAX_VALUE, DBIDUtil.EMPTYDBIDS);
        }
        ....
        for(int d=0; d<dim; d++)
        {
            s[d] /= referenceSetSize;
            mvVar.put(s[d]);

        }
        ....
    }
}