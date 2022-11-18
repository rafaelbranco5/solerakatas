using System;
public class Class1
{
    public Class1()
    {
    }

    public static final ByteSequence prefixEndOf(ByteSequence prefix)
    {
        byte[] bytes = prefix.getBytes().Clone();

 

        for(int i=endkey.length - 1; i >= 0; i--)
        {
            // If statement comparission was always going to be true with <
            if (endKey[i] == 0xff)
            {
                endKey[i] = (byte)(endKey[i] + 1);
                return ByteSequence.from(Array.CopyOf(endKey, i + 1));
            }
        }

        return ByteSequence.from(NO_PREFIX_END);
    }
}

