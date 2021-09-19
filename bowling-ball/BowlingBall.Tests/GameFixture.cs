using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            Roll(game, 0, 20);
            Assert.AreEqual(0, game.GetScore());
        }

        private void Roll(Game game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }

        [TestMethod]
        public void Gutter_game_score_should_be_133_test()
        {
            var game = new Game();
            game.Roll(1); game.Roll(4);
            game.Roll(4); game.Roll(5); 
            game.Roll(6); game.Roll(4); 
            game.Roll(5); game.Roll(5); 
            game.Roll(10); game.Roll(0); 
            game.Roll(1); game.Roll(7); 
            game.Roll(3); game.Roll(6); 
            game.Roll(4); game.Roll(10); 
            game.Roll(2); game.Roll(8); 
            game.Roll(6); 
            
            Assert.AreEqual(133, game.GetScore());
        }
    }
}
