using NUnit.Framework;

namespace GameOfLife.Core.Tests
{
    [TestFixture]
    public class TestGame
    {
        [Test]
        public void Initialise_InitialisesCells()
        {
            // Arrange
            var game = new Game();

            // Act
            game.Initialise(50);

            // Assert

        }

        [Test]
        public void Step_AliveCellWithOneLiveNeighbour_Dies()
        {
            // Arrange
            var game = new Game();
            game.Initialise(5);
            game.Cells[0, 0].Alive = true;
            game.Cells[0, 1].Alive = true;

            // Act
            game.Step();

            // Assert
            Assert.IsFalse(game.Cells[0,0].Alive);
        }

        [Test]
        public void Step_AliveCellWithTwoLiveNeighbour_StaysAlive()
        {
            // Arrange
            var game = new Game();
            game.Initialise(5);
            game.Cells[0, 0].Alive = true;
            game.Cells[0, 1].Alive = true;
            game.Cells[1, 0].Alive = true;

            // Act
            game.Step();

            // Assert
            Assert.IsTrue(game.Cells[0, 0].Alive);
        }

        [Test]
        public void Step_AliveCellWithThreeLiveNeighbours_StaysAlive()
        {
            // Arrange
            var game = new Game();
            game.Initialise(5);
            game.Cells[0, 0].Alive = true;
            game.Cells[0, 1].Alive = true;
            game.Cells[1, 0].Alive = true;
            game.Cells[1, 1].Alive = true;

            // Act
            game.Step();

            // Assert
            Assert.IsTrue(game.Cells[0, 0].Alive);
        }
        
        [Test]
        public void Step_AliveCellWithFourLiveNeighbours_Dies()
        {
            // Arrange
            var game = new Game();
            game.Initialise(5);
            game.Cells[1, 1].Alive = true;
            game.Cells[1, 0].Alive = true;
            game.Cells[0, 1].Alive = true;
            game.Cells[2, 1].Alive = true;
            game.Cells[1, 2].Alive = true;

            // Act
            game.Step();

            // Assert
            Assert.IsFalse(game.Cells[1, 1].Alive);
        }


        [Test]
        public void Step_DeadCellWithThreeLiveNeighbours_BecomesAlive()
        {
            // Arrange
            var game = new Game();
            game.Initialise(5);
            game.Cells[1, 0].Alive = true;
            game.Cells[0, 1].Alive = true;
            game.Cells[2, 1].Alive = true;

            // Act
            game.Step();

            // Assert
            Assert.IsTrue(game.Cells[1, 1].Alive);
        }

    }
}
