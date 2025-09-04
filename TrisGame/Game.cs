namespace TrisGame
{
    public class Game
    {
        private Board board;
        private IPlayer[] players;
        private int currentPlayerIndex;

        public Game()
        {
            board = new Board();
            players = new IPlayer[]
            {
                new Human('X'),
                new Computer('O')
            };
            currentPlayerIndex = 0;
        }

        public void Start()
        {
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("Human: X, Computer: O\n");

            while (true)
            {
                PlayRound();
                
                Console.Write("Play again? (y/n): ");
                if (Console.ReadLine()?.ToLower() != "y")
                    break;
                    
                Reset();
            }
        }

        private void PlayRound()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tic Tac Toe\n");
                board.Print();

                var currentPlayer = players[currentPlayerIndex];
                var move = currentPlayer.GetNextMove(board);
                board.Set(move.Row, move.Col, currentPlayer.Symbol);

                if (board.HasWinner(out char winner))
                {
                    Console.Clear();
                    Console.WriteLine("Tic Tac Toe\n");
                    board.Print();
                    Console.WriteLine($"Player {winner} wins!");
                    break;
                }

                if (board.IsFull())
                {
                    Console.Clear();
                    Console.WriteLine("Tic Tac Toe\n");
                    board.Print();
                    Console.WriteLine("It's a tie!");
                    break;
                }

                currentPlayerIndex = 1 - currentPlayerIndex;
            }
        }

        private void Reset()
        {
            board.Clear();
            currentPlayerIndex = 0;
        }
    }
}