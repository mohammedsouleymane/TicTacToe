using System;

namespace TicTacToe
{
    class Program
    {
        static int Winner(char[] array)
        {
            int player = 0;
            if (array[0] == array[1] && array[1] == array[2] && array[2] == 'X')
                player = 1;
            else if (array[3] == array[4] && array[4] == array[5] && array[5] == 'X')
                player = 1;
            else if (array[6] == array[7] && array[7] == array[8] && array[8] == 'X')
                player = 1;
            else if (array[0] == array[3] && array[3] == array[6] && array[6] == 'X')
                player = 1;
            else if (array[1] == array[4] && array[4] == array[7] && array[7] == 'X')
                player = 1;
            else if (array[2] == array[5] && array[5] == array[8] && array[8] == 'X')
                player = 1;
            else if (array[0] == array[4] && array[4] == array[8] && array[8] == 'X')
                player = 1;
            else if (array[2] == array[4] && array[4] == array[6] && array[6] == 'X')
                player = 1;

            //player 2
            if (array[0] == array[1] && array[1] == array[2] && array[2] == 'O')
                player = 2;
            else if (array[3] == array[4] && array[4] == array[5] && array[5] == 'O')
                player = 2;
            else if (array[6] == array[7] && array[7] == array[8] && array[8] == 'O')
                player = 2;
            else if (array[0] == array[3] && array[3] == array[6] && array[6] == 'O')
                player = 2;
            else if (array[1] == array[4] && array[4] == array[7] && array[7] == 'O')
                player = 2;
            else if (array[2] == array[5] && array[5] == array[8] && array[8] == 'O')
                player = 2;
            else if (array[0] == array[4] && array[4] == array[8] && array[8] == 'O')
                player = 2;
            else if (array[2] == array[4] && array[4] == array[6] && array[6] == 'O')
                player = 2;
                

                    return player;

        }
        static void Main(string[] args)
        {

            char rematch = 'j';

            do
            {
                char[] layout = {'1', '2', '3','4', '5', '6','7', '8', '9'};
                Console.WriteLine($@" 
  __________________
 |                  |
 |   {layout[0]}  |  {layout[1]}  |  {layout[2]}  |  
 | _____|_____|_____|
 |      |     |     |
 |   {layout[3]}  |  {layout[4]}  |  {layout[5]}  |    
 | _____|_____|_____|
 |      |     |     |
 |   {layout[6]}  |  {layout[7]}  |  {layout[8]}  |   
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
                    char position = char.Parse(Console.ReadLine());
                    int posX = -1;
                    for (int j = 0; j < layout.Length; j++)
                    {
                        if (layout[j] == position)
                            posX = j;
                    }
                    
                    layout[posX] = sign;

                    Console.Clear();
                    Console.WriteLine($@" 
  __________________
 |                  |
 |   {layout[0]}  |  {layout[1]}  |  {layout[2]}  |  
 | _____|_____|_____|
 |      |     |     |
 |   {layout[3]}  |  {layout[4]}  |  {layout[5]}  |    
 | _____|_____|_____|
 |      |     |     |
 |   {layout[6]}  |  {layout[7]}  |  {layout[8]}  |   
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
