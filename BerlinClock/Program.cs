string[] inputTime;
Console.WriteLine("Please input the time: ");
string? input = Console.ReadLine();

inputTime = input.Split(":");
int hours = int.Parse(inputTime[0]);
int minutes = int.Parse(inputTime[1]);
int seconds = int.Parse(inputTime[2]);

wrtiteSecondes(seconds);
writeHours(hours);
writeminutes(minutes);

Console.WriteLine("Input Berlin Clock Rime: ");
string berlinTime = Console.ReadLine();

writeDigital(berlinTime);

void wrtiteSecondes(int seconds)
{
    if (seconds % 2 == 0)
    {
        Console.Write("Y");
    }else{
        Console.Write("O");
    }
}

void writeminutes(int minutes)
{
    String firstMinutesLine = "";
    String secondMinutesLine = "";

    int block5Minutes = minutes / 5;
    int block1Minutes = minutes % 5;

    for(int i = 1; i<=11; i++)
    {
        if(i <= block5Minutes)
        {
            if(i % 3 == 0)
            {
                firstMinutesLine += "R";
            }
            else
            {
                firstMinutesLine += "Y";
            }
        }
        else
        {
            firstMinutesLine += "O";
        }
    }
    for (int i = 0; i < 4; i++)
    {
        if(i < block1Minutes)
        {
            secondMinutesLine += "Y";
        }
        else
        {
            secondMinutesLine += "O";
        }
    }
    Console.Write(firstMinutesLine);
    Console.Write(secondMinutesLine);
}

void writeHours(int hours)
{
    String firsthoursLine = "";
    String secondhoursLine = "";
 
    int block5Hours = hours / 5;
    int block1Hours = hours % 5;
 
    for(int i = 0; i < 4; i++)
    {
        if(i < block5Hours)
        {
            firsthoursLine += "R";
        }
        else
        {
            firsthoursLine += "O";
        }
 
        if(i < block1Hours)
        {
            secondhoursLine += "R";
        }
        else
        {
            secondhoursLine += "O";
        }
    }
 
    Console.Write(firsthoursLine);
    Console.Write(secondhoursLine);
 
}

void writeDigital(string BerlinHours)
{
    string Seconds = BerlinHours.Substring(0,1);
    string Hours5block = BerlinHours.Substring(1, 4);
    string Hours1block = BerlinHours.Substring(5, 4);
    string Minutes5Block = BerlinHours.Substring(9, 11);
    string Minutes1Block = BerlinHours.Substring(20);

 

    String Digitaloutput = "";

 

    int Hours = 0;
    for(int i=0 ; i < 4; i++)
    {
        if (Hours5block[i] == 'R')
        {
            Hours += 5;
        }
        if (Hours1block[i] == 'R')
        {
            Hours += 1;
        }

 

    }

 

    int minuts = 0;
    for (int i = 0; i < 11; i++)
    {
        if (Minutes5Block[i] != 'O')
        {
            minuts += 5;
        }
    }

 

    for (int i = 0; i < 4; i++)
    {
        if (Minutes1Block[i] != 'O')
        {
            minuts += 1;
        }
    }

 

    Random r = new Random();
    int secods = r.Next(30) * 2; ;

    if (Seconds[0] != 'Y')
    {
        secods--;
    }

    Console.WriteLine(Hours.ToString() + ":" + minuts.ToString() + ":" + secods.ToString());

}