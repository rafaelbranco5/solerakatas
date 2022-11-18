using System;

public class Class1
{
    public Class1()
    {
    }

    public string GetStrippedSubstring()
    {
        int sstart = start, ssend = end;

 

        while(sstart < ssend)
        {
            char c = input.charAt(sstart);
            // If statement was doing the reverse of what it was supposed to do
            // Before it was removing every char except the ones listed bellow
            if(c == ' ' || c == '\n' || c == '\r' || c == '\t')
            {
                break;
            }
            ++sstart;
        }
        ....
    }
}