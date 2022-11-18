using System;
using System.Collections;
using Bingo;

int maxDraws = 75;
Random rng = new Random();
ArrayList listOfNumbers = new ArrayList();

Bingocard cards = new Bingocard();

int[,] slip1 = cards.generatecard();
int[,] slip2 = cards.generatecard();



int i = 0;
while (i < maxDraws)
{
    int number = rng.Next(1, 76);
    if(!listOfNumbers.Contains(number))
    {
        listOfNumbers.Add(number);
        i++;
    }  
}
int countSlip1=0;
int countSlip2=0;
for (int x = 0; x < maxDraws; x++)
{
    if (cards.checkNumber(listOfNumbers[x].ToString(), slip1)){
        countSlip1++;
    }else if(cards.checkNumber(listOfNumbers[x].ToString(), slip2))
    {
        countSlip2++;
    }
}
