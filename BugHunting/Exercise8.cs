using System;

 

public class Class1
{
    public Class1()
    {
    }

    private void shiftRigthDestructive(int wordsShift, int bitShiftsInWord, Boolean roundpu)
    {
        if (wordshifts == 0 && bitShiftsInWord == 0)
        {
            return;
        }

        assert (wordsShift >=0);
        // variable bitShiftsInWord could have been 0 wich would conflict with a latter call and possibli gain a value of -1
        assert (bitShiftsInWord > 0);
        assert (bitShiftsInWord < 32);
        if (wordsShift >=4){
            zeroclear();
            return;
        }

        final int shiftrestore = 32 - bitShiftsInWord;

        final boolean noRestore = bitShiftsInWord == 0;
        final int roundCarryNoRestoreMask = 1 << 31;
        final int roundCarryMask = (1 << (bitShiftsInWord - 1));
    }

}