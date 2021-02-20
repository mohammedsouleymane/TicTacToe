using System;

namespace TicTacToe
{
    class Program
    {
        static int Winner(char[,] array)
        {
            int player = 0;
            if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 2] == 'X')
                player = 1;
            else if (array[1, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[2, 0] == 'X')
                player = 1;
            else if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 2] == 'X')
                player = 1;
            else if (array[1, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[2, 2] == 'X')
                player = 1;
            else if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[2, 2] == 'X')
                player = 1;
            else if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[2, 0] == 'X')
                player = 1;
            else if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[2, 1] == 'X')
                player = 1;

            //player 2
            if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 2] == '0')
                player = 1;
            else if (array[1, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[2, 0] == '0')
                player = 1;
            else if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 2] == '0')
                player = 1;
            else if (array[1, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[2, 2] == '0')
                player = 1;
            else if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[2, 2] == 'O')
                player = 1;
            else if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[2, 0] == 'O')
                player = 1;
            else if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[2, 1] == 'O')
                player = 2;

            return player;

        }
        static void Main(string[] args)
        {

            char rematch = 'j';




            do
            {
                char[,] layout = {
                            { '1', '2', '3' },
                            { '4', '5', '6'},
                             { '7', '8', '9'}
                  };
                Console.WriteLine($@" 
  __________________
 |                  |
 |   {layout[0, 0]}  |  {layout[0, 1]}  |  {layout[0, 2]}  |  
 | _____|_____|_____|
 |      |     |     |
 |   {layout[1, 0]}  |  {layout[1, 1]}  |  {layout[1, 2]}  |    
 | _____|_____|_____|
 |      |     |     |
 |   {layout[2, 0]}  |  {layout[2, 1]}  |  {layout[2, 2]}  |   
 |__________________|");


                int i = 1;
                bool end = true;
                while (i != 10 && end)
                {
                    int player = 1;
                    char sign = 'X';

                    if (i % 2 != 0)
                    {
                        player = 1;
                        sign = 'X';
                    }
                    else
                    {
                        player = 2;
                        sign = 'O';

                    }

                    Console.WriteLine($"Player {player} move");
                    string position = Console.ReadLine();
                    int posX = 0;
                    int posY = 0;
                    for (int j = 0; j < layout.GetLength(0); j++)
                    {
                        for (int l = 0; l < layout.GetLength(1); l++)
                        {
                            if (layout[j, l] == char.Parse(position))
                            {
                                posX = j;
                                posY = l;
                            }
                        }
                    }

                    layout[posX, posY] = sign;

                    Console.Clear();
                    Console.WriteLine($@" 
  __________________
 |                  |
 |   {layout[0, 0]}  |  {layout[0, 1]}  |  {layout[0, 2]}  |  
 | _____|_____|_____|
 |      |     |     |
 |   {layout[1, 0]}  |  {layout[1, 1]}  |  {layout[1, 2]}  |    
 | _____|_____|_____|
 |      |     |     |
 |   {layout[2, 0]}  |  {layout[2, 1]}  |  {layout[2, 2]}  |   
 |__________________|");

                    if (Winner(layout) != 0)
                    {
                        Console.WriteLine($"Player {Winner(layout)} won");
                        end = false;
                    }
                    else if (Winner(layout) == 0 && i == 9)
                        Console.WriteLine("Draw");
                    i++;
                }

                Console.WriteLine("rematch? y/n");
                rematch = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (rematch == 'y');

        }
    }
}
