Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("==== Welcome To MY BEST Ludo Game ====");

int[,] board = new int[15, 15];
board[0, 0] = 1;

for (int i = 0; i <= 14; i++)
{
    for (int j = 0; j <= 14; j++)
    {
        if (i <= 5 && j <= 5)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("R");
        }
        else if (i <= 5 && j >= 9)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("G");
        }
        else if (i >= 9 && j <= 5)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("B");
        }
        else if (i >= 9 && j >= 9)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("Y");
        }
        else if (i >= 6 && i <= 8 && j >= 6 && j <= 8)
        {
            if (i == 6 && j == 6)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (i == 7 && j == 8)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            } 
            else if (i == 7 && j == 6)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            } else if ( i == 8 && j == 6)
            Console.Write("F");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(board[i, j]);
        }
        Console.Write(" ");
    }
    Console.WriteLine();
}
