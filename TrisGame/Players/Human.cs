namespace TrisGame
{
    public class Human : IPlayer
    {
        public char Symbol { get; private set; }

        public Human(char symbol)
        {
            Symbol = symbol;
        }

        public Move GetNextMove(Board board)
        {
            while (true)
            {
                Console.Write($"Player {Symbol} - enter row and column (0-2): ");
                var input = Console.ReadLine()?.Split();
                
                if (input?.Length == 2 && 
                    int.TryParse(input[0], out int row) && 
                    int.TryParse(input[1], out int col) &&
                    board.IsEmpty(row, col))
                {
                    return new Move(row, col);
                }
                
                Console.WriteLine("Invalid move, try again.");
            }
        }
    }
}