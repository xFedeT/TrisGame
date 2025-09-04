namespace TrisGame
{
    public class Computer : IPlayer
    {
        public char Symbol { get; private set; }
        private char opponentSymbol;

        public Computer(char symbol)
        {
            Symbol = symbol;
            opponentSymbol = symbol == 'X' ? 'O' : 'X';
        }

        public Move GetNextMove(Board board)
        {
            Console.WriteLine($"Player {Symbol} thinking...");
            Thread.Sleep(1000);

            var bestMove = FindOptimalMove(board);
            Console.WriteLine($"Player {Symbol} plays: {bestMove.Row} {bestMove.Col}");
            Thread.Sleep(500);
            
            return bestMove;
        }

        private Move FindOptimalMove(Board board)
        {
            int bestScore = int.MinValue;
            var bestMove = new Move(-1, -1);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.IsEmpty(i, j))
                    {
                        board.Set(i, j, Symbol);
                        int score = Minimax(board, 0, false);
                        board.Remove(i, j);

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove = new Move(i, j);
                        }
                    }
                }
            }

            return bestMove;
        }

        private int Minimax(Board board, int depth, bool maximizing)
        {
            if (board.HasWinner(out char winner))
            {
                if (winner == Symbol) return 10 - depth;
                if (winner == opponentSymbol) return depth - 10;
            }
            
            if (board.IsFull()) return 0;

            if (maximizing)
            {
                int maxEval = int.MinValue;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board.IsEmpty(i, j))
                        {
                            board.Set(i, j, Symbol);
                            int eval = Minimax(board, depth + 1, false);
                            board.Remove(i, j);
                            maxEval = Math.Max(maxEval, eval);
                        }
                    }
                }
                return maxEval;
            }
            else
            {
                int minEval = int.MaxValue;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board.IsEmpty(i, j))
                        {
                            board.Set(i, j, opponentSymbol);
                            int eval = Minimax(board, depth + 1, true);
                            board.Remove(i, j);
                            minEval = Math.Min(minEval, eval);
                        }
                    }
                }
                return minEval;
            }
        }
    }
}