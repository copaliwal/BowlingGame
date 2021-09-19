namespace BowlingBall
{
    public interface IBowlingGame
    {
        void AddThrow(int pins);
        int ScoreForFrame();
    }
}