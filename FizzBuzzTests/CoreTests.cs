using FizzBuzzLib;
using NUnit.Framework;

namespace FizzBuzzTests
{
    public class CoreTests
    {
        Game _game;
        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void GameNotNull()
        {          
            Assert.NotNull(_game);
        }

        [Test]
        public void GameReturnsOne()
        {         
            var result = _game.Process(1);
            Assert.AreEqual("1", result);            
        }

        [Test]
        public void GameReturnsTwo()
        {
            var result = _game.Process(2);
            Assert.AreEqual("2", result);   
        }

        [Test]
        public void GameReturnsFour()
        {
            var result = _game.Process(4);
            Assert.AreEqual("4", result);
        }

        [Test]
        public void GameReturnsFizzFor3()
        {
            var result = _game.Process(3);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void GameReturnsBazzFor5()
        {
            var result = _game.Process(5);
            Assert.AreEqual("Bazz", result);
        }
    }
}