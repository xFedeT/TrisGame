namespace TrisGame;

public interface IPlayer
{
    char Symbol { get; }
    Move GetNextMove(Board board);
}