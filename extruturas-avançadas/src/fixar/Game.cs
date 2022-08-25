namespace fixar;
public enum GameType {
    Action,
    Adventure,
    Puzzle,
    Strategy,
    Simulation,
    Sports,
    Other
};
 public class Game
{
    public string? Name;
    public GameType Type = GameType.Other;
    public Game(GameType type)
    {
        Type = type;
    }
}