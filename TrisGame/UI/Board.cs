namespace TrisGame
{
    public class Board
    {
        private char[,] cells = new char[3, 3];

        public Board()
        {
            Clear();
        }

        public void Clear()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    cells[i, j] = ' ';
        }

        public bool IsEmpty(int row, int col)
        {
            return row >= 0 && row < 3 && col >= 0 && col < 3 && cells[row, col] == ' ';
        }

        public void Set(int row, int col, char symbol)
        {
            if (IsEmpty(row, col))
                cells[row, col] = symbol;
        }

        public void Remove(int row, int col)
        {
            cells[row, col] = ' ';
        }

        public char Get(int row, int col)
        {
            return cells[row, col];
        }

        public bool HasWinner(out char winner)
        {
            winner = ' ';

            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if (cells[i, 0] != ' ' && cells[i, 0] == cells[i, 1] && cells[i, 1] == cells[i, 2])
                {
                    winner = cells[i, 0];
                    return true;
                }
                if (cells[0, i] != ' ' && cells[0, i] == cells[1, i] && cells[1, i] == cells[2, i])
                {
                    winner = cells[0, i];
                    return true;
                }
            }

            // Check diagonals
            if (cells[0, 0] != ' ' && cells[0, 0] == cells[1, 1] && cells[1, 1] == cells[2, 2])
            {
                winner = cells[0, 0];
                return true;
            }
            if (cells[0, 2] != ' ' && cells[0, 2] == cells[1, 1] && cells[1, 1] == cells[2, 0])
            {
                winner = cells[0, 2];
                return true;
            }

            return false;
        }

        public bool IsFull()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (cells[i, j] == ' ')
                        return false;
            return true;
        }

        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(cells[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("---|---|---");
            }
            Console.WriteLine();
        }
    }
}