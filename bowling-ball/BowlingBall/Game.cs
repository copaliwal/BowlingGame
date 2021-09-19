namespace BowlingBall
{
    public class Game
    {
        private readonly IBowlingGame bowlingGame;

        public Game()
        {
            bowlingGame = new BowlingGame();
        }

        public Game(IBowlingGame _bowlingGame)
        {
            bowlingGame = _bowlingGame;
        }

        public void Roll(int pins)
        {
            // Add your logic here. Add classes as needed.
            bowlingGame.AddThrow(pins);
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            return bowlingGame.ScoreForFrame();
        }
    }
}
