using System;
using System.Linq;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] field = new char[size][];

            //initial snake position
            int snakeRow = 0;
            int snakeCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] currentCol = Console.ReadLine().ToCharArray();

                field[row] = new char[size]; // set size inner array

                for (int col = 0; col < size; col++)
                {
                    char ch = currentCol[col];
                    if (ch == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    field[row][col] = ch;
                }
            }

            int stars = 0;

            while (true)
            {
                field[snakeRow][snakeCol] = '.';
                string command = Console.ReadLine();

                switch (command)  // snake direction
                {
                    case "right":
                        snakeCol++;
                        break;
                    case "left":
                        snakeCol--;
                        break;
                    case "up":
                        snakeRow--;
                        break;
                    case "down":
                        snakeRow++;
                        break;
                }
                if (IsOutside(size, snakeRow, snakeCol)) //check boundary field 
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                char element = field[snakeRow][snakeCol]; // get new position and check if is equal to 'B'
                if (element == 'B')
                {
                    field[snakeRow][snakeCol] = '.'; 

                    //check where is the next burrow
                    for (int row = 0; row < size; row++)
                    {
                        bool found = false;
                        for (int col = 0; col < size; col++)
                        {
                            char currMatrixElement = field[row][col];

                            if (currMatrixElement == 'B')
                            {
                                snakeRow = row;
                                snakeCol = col;

                                field[snakeRow][snakeCol] = 'S';

                                found = true;
                                break;
                            }
                        }
                        if (found)
                        {
                            break;
                        }
                    }
                }
                else if (element == '*')
                {
                    stars++;
                    field[snakeRow][snakeCol] = 'S';

                    if (stars >= 10)
                    {
                        Console.WriteLine("You won! You fed the snake.");
                        break;
                    }
                }
            }

            Console.WriteLine($"Food eaten: {stars}");

            // print final field 
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field.Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
        }


        private static bool IsOutside(int size, int snakeRow, int snakeCol)
        {
            return snakeRow >= size ||
                    snakeRow < 0 ||
                    snakeCol >= size ||
                    snakeCol < 0;
        }
    }
}
