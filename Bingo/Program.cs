using System;
using System.Collections;
using Bingo;

int maxDraws = 75;
Random rng = new Random();
ArrayList listOfNumbers = new ArrayList();

Bingocard cards = new Bingocard();

int[,] slip1 = cards.generatecard();
int[,] slip2 = cards.generatecard();

int countSlip1=0;
int countSlip2=0;

int i = 0;
while (i < maxDraws)
{
    int number = rng.Next(1, 76);
    if(!listOfNumbers.Contains(number))
    {
        listOfNumbers.Add(number);
        i++;

        if (cards.checkNumber(number, slip1)){
            countSlip1++;
        }
        if (cards.checkNumber(number, slip2)){
            countSlip2++;
        }
    }
    if (countSlip1 == 24 && countSlip2 == 24) {
        System.Console.WriteLine("It's a tie!");
        break;
    }else if (countSlip1 == 24) {
        System.Console.WriteLine("Palyer 1 wins!");
        break;
    }else if (countSlip2 == 24){
        System.Console.WriteLine("Palyer 2 wins!");
        break;
    }
}
/*

for (int x = 0; x < maxDraws; x++)
{
    if (cards.checkNumber(listOfNumbers[x].ToString(), slip1)){
        countSlip1++;
    }else if(cards.checkNumber(listOfNumbers[x].ToString(), slip2))
    {
        countSlip2++;
    }
}
*/