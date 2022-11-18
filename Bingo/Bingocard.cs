using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bingo
{
    public class Bingocard
    {
        public int[,]? card;
        private Random _rng = new Random();
        ArrayList listOfNumbers = new ArrayList();

        ArrayList cardNumberList = new ArrayList();
        public Bingocard(){}

        public Bingocard(int[,] card){
            this.card = card;
        }

        public int[,] generatecard()
        {
            int[,] generatedCard = {{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0}};
            int lower = 1, upper =16;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        continue;
                    }else
                    {
                    int number = _rng.Next(lower, upper);

                        while(listOfNumbers.Contains(number))
                        {
                            number = _rng.Next(lower, upper);
                            
                        }
                        listOfNumbers.Add(number);
                        generatedCard[i,j] = number;
                    }
                    
                }
                lower += 15;
                upper += 15;
            }
            return generatedCard;
        }

        public void printCard(int[,] card)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    System.Console.Write('-' + card[i,j].ToString() + '-');
                }
                System.Console.WriteLine();
            }
        } 

        public Boolean checkNumber( string numberInString, int[,] a)
        {
            int number = int.Parse(numberInString);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a[i,j] == number){
                        return true;
                    }
                }
            }
            return false;
        }
    }
}