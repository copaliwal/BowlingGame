namespace BowlingBall
{
    // Note: Not using this code for now but just added for sample of strategy pattern and factory pattern
    public interface IScoreStrategy
    {
        int GetScoreFrame(int[] throws, int ball);
    }

    public class StrikeScore : IScoreStrategy
    {
        public int GetScoreFrame(int[] throws, int ball)
        {
            return 10 + (throws[ball + 1] + throws[ball + 2]);
        }
    }

    public class SpareScore : IScoreStrategy
    {
        public int GetScoreFrame(int[] throws, int ball)
        {
            return 10 + throws[ball + 2];
        }
    }

    public class OpenScore : IScoreStrategy
    {
        public int GetScoreFrame(int[] throws, int ball)
        {
            return throws[ball] + throws[ball + 1];
        }
    }

    public static class FrameScoreFactory
    {
        public static IScoreStrategy GetScoreStratgery(int[] throws, int current)
        {
            if (Strike(throws, current))
            {
                return new StrikeScore();
            }
            else if (Spare(throws, current))
            {
                return new SpareScore();
            }
            else
            {
                return new OpenScore();
            }
        }

        private static bool Spare(int[] throws, int ball)
        {
            return throws[ball] + throws[ball + 1] == 10;
        }

        private static bool Strike(int[] throws, int ball)
        {
            return throws[ball] == 10;
        }
    }
}
