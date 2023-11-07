using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';
    static bool gameFinished = false;

    static void Main()
    {
        InitializeBoard();
        PrintBoard();

        while (!gameFinished)
        {
            Play();
            PrintBoard();
            if (CheckForWinner() || CheckForDraw())
            {
                gameFinished = true;
            }
        }

        if (CheckForWinner())
        {
            Console.WriteLine("Jogador " + currentPlayer + " venceu!");
        }
        else if (CheckForDraw())
        {
            Console.WriteLine("O jogo empatou!");
        }

        Console.ReadLine();
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    static void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            if (i < 2)
            {
                Console.WriteLine("  -+-+-");
            }
        }
        Console.WriteLine();
    }

    static void Play()
    {
        int row, col;
        do
        {
            Console.Write("Jogador " + currentPlayer + ", informe a linha (0-2): ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Jogador " + currentPlayer + ", informe a coluna (0-2): ");
            col = int.Parse(Console.ReadLine());
        } while (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ');

        board[row, col] = currentPlayer;
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    static bool CheckForWinner()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
            {
                return true;
            }
        }

        for (int j = 0; j < 3; j++)
        {
            if (board[0, j] == currentPlayer && board[1, j] == currentPlayer && board[2, j] == currentPlayer)
            {
                return true;
            }
        }

        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
        {
            return true;
        }

        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
        {
            return true;
        }

        return false;
    }

    static bool CheckForDraw()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    return false;
                }
            }
        }
        return true;
    }
}
