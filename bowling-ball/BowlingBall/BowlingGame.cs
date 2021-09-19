namespace BowlingBall
{
    public class BowlingGame : IBowlingGame
    {
        private const int MAX_THROWS = 21;
        private const int TOTAL_FRAMES = 10;
        private readonly int[] throws = new int[MAX_THROWS];
        private int ball;
        private int currentThrow;

        public void AddThrow(int pins)
        {
            throws[currentThrow++] = pins;
        }

        public virtual int ScoreForFrame()
        {
            ball = 0;
            int score = 0;
            for (int currentFrame = 0; currentFrame < TOTAL_FRAMES; currentFrame++)
            {
                // Note: We can use a strategry pattern here to calclulate score. 
                // Added Score Strategy class for the code sample. But I am going with the below simple solution
                if (Strike())
                {
                    score += 10 + NextTwoBallsForStrike;
                    ball++;
                }
                else if (Spare())
                {
                    score += 10 + NextBallForSpare;
                    ball += 2;
                }
                else
                {
                    score += TwoBallsInFrame;
                    ball += 2;
                }
            }
            return score;
        }

        private int NextTwoBallsForStrike
        {
            get
            {
                return (throws[ball + 1] + throws[ball + 2]);
            }
        }

        private int NextBallForSpare
        {
            get
            {
                return throws[ball + 2];
            }
        }

        private int TwoBallsInFrame
        {
            get
            {
                return throws[ball] + throws[ball + 1];
            }
        }

        private bool Spare()
        {
            return throws[ball] + throws[ball + 1] == 10;
        }

        private bool Strike()
        {
            return throws[ball] == 10;
        }
    }
}
