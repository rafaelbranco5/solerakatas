String grid = "";

 

for (int i = 0; i < 6; i++)
{
    grid += " O O O O O O O \n";
}

 

grid += "-A-B-C-D-E-F-G-\n";

 

bool winner = false;

 

while (!winner)
{

 

    Console.Clear();
    Console.WriteLine(grid);

 

    Console.WriteLine("Player Yellow Turn: ");

 

    char input = ValidateInput();
    InsertPlayerMove('Y', input);

 

    Console.Clear();
    Console.WriteLine(grid);

 

    winner = WinnerMove('Y', input);
    if (winner)
    {
        Console.WriteLine("\n\n PLAYER YELLOW WINS");
        break;
    }

 

    Console.WriteLine("");
    Console.WriteLine("Player Red Turn: ");

 

    input = ValidateInput();
    InsertPlayerMove('R', input);

 

    Console.Clear();    
    Console.WriteLine(grid);

 

    winner = WinnerMove('R', input);
    if (winner)
    {
        Console.WriteLine("\n\n PLAYER RED WINS");
        break;
    }

 

}

void InsertPlayerMove(char player, char input)
{

 

    int ColumnNumber = 1 + ((input - 65) * 2);

 


    for (int i = 0; i < 6; i++)
    {
        if (grid[((i + 1) * 16) + ColumnNumber] != 'O')
        {
            char[] modifiedGrid = grid.ToCharArray();
            modifiedGrid[((i) * 16) + ColumnNumber] = player;
            grid = new string(modifiedGrid);
            break;
        }
    }

 


}

 

char ValidateInput()
{

 

    Console.Write("Column: ");
    char inputColumn = Console.ReadLine().ToCharArray()[0];

 

    while (inputColumn < 65 || inputColumn > 71)
    {
        Console.WriteLine("Invalid Input - Please enter upper letter between A - G");
        Console.Write("Column: ");
        inputColumn = Console.ReadLine().ToCharArray()[0];
    }

 


    return inputColumn;
}

 

bool WinnerMove(char player, char input)
{

 

    int ColumnNumber = 1 + ((input - 65) * 2);

 

    for (int i = 0; i < 6; i++)
    {
        if (grid[(i * 16) + ColumnNumber] == player)
        {

 

            //Check Left
            int coincidence = 1;
            int tmpColumn = ColumnNumber - 2;
            while (tmpColumn > 0)
            {
                if(grid[(i * 16) + tmpColumn] == player)
                {
                    coincidence++;
                    if(coincidence == 4)return true;
                }
                else
                {
                    break;
                }
                tmpColumn -= 2;
            }

 


            //Check Right
            coincidence = 1;
            tmpColumn = ColumnNumber + 2;
            while (tmpColumn < 16)
            {
                if (grid[(i * 16) + tmpColumn] == player)
                {
                    coincidence++;
                    if (coincidence == 4) return true;
                }
                else
                {
                    break;
                }
                tmpColumn += 2;
            }

 

            //Check bottom
            coincidence = 1;
            int tmpRow = i + 1;
            while (tmpRow < 6)
            {
                if (grid[(tmpRow * 16) + ColumnNumber] == player)
                {
                    coincidence++;
                    if (coincidence == 4) return true;
                }
                else
                {
                    break;
                }
                tmpRow++;
            }

 

            //Check left diagonally bottom
            coincidence = 1;
            tmpRow = i + 1;
            tmpColumn = ColumnNumber - 2;
            while (tmpColumn > 0 && tmpRow < 6)
            {
                if (grid[(tmpRow * 16) + tmpColumn] == player)
                {
                    coincidence++;
                    if (coincidence == 4) return true;
                }
                else
                {
                    break;
                }
                tmpRow++;
                tmpColumn -= 2;
            }

 

            //Check right diagonally bottom
            coincidence = 1;
            tmpRow = i + 1;
            tmpColumn = ColumnNumber + 2;
            while (tmpColumn < 16 && tmpRow < 6)
            {
                if (grid[(tmpRow * 16) + tmpColumn] == player)
                {
                    coincidence++;
                    if (coincidence == 4) return true;
                }
                else
                {
                    break;
                }
                tmpRow++;
                tmpColumn += 2;
            }

 

            //Check left diagonally top
            coincidence = 1;
            tmpRow = i - 1;
            tmpColumn = ColumnNumber - 2;
            while (tmpColumn > 0 && tmpRow >= 0)
            {
                if (grid[(tmpRow * 16) + tmpColumn] == player)
                {
                    coincidence++;
                    if (coincidence == 4) return true;
                }
                else
                {
                    break;
                }
                tmpRow++;
                tmpColumn -= 2;
            }

 

            //Check right diagonally top
            coincidence = 1;
            tmpRow = i + 1;
            tmpColumn = ColumnNumber + 2;
            while (tmpColumn < 16 && tmpRow >= 0)
            {
                if (grid[(tmpRow * 16) + tmpColumn] == player)
                {
                    coincidence++;
                    if (coincidence == 4) return true;
                }
                else
                {
                    break;
                }
                tmpRow++;
                tmpColumn += 2;
            }

 

 


        }
    }

 


    return false;
}