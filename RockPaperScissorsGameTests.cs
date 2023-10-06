using FluentAssertions;
using KataLogic;
using static KataLogic.RockPaperScissorsGame;

namespace Katas
{
    public class RockPaperScissorsGameTests
    {

        [Test]
        public void CheckForWinner_GivenPlayerPaperAndOpponentRock_PlayerShouldWin()
        {
            //Arrange
            var player = Moves.Paper;
            var opponent = Moves.Rock;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("player wins");
        }

        [Test]
        public void CheckForWinner_GivenPlayerPaperAndOpponentScissors_PlayerShouldLose()
        {
            //Arrange
            var player = Moves.Paper;
            var opponent = Moves.Scissors;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("player loses");
        }

        [Test]
        public void CheckForWinner_GivenPlayerPaperAndOpponentPaper_ShouldTie()
        {
            //Arrange
            var player = Moves.Paper;
            var opponent = Moves.Paper;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("tie");
        }  
        
        [Test]
        public void CheckForWinner_GivenPlayerRockAndOpponentScissors_PlayerShouldWin()
        {
            //Arrange
            var player = Moves.Rock;
            var opponent = Moves.Scissors;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("player wins");
        } 

        [Test]
        public void CheckForWinner_GivenPlayerRockAndOpponentPaper_PlayerShouldLose()
        {
            //Arrange
            var player = Moves.Rock;
            var opponent = Moves.Paper;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("player loses");
        }      
     

        [Test]
        public void CheckForWinner_GivenPlayerRockAndOpponentRock_ShouldTie()
        {
            //Arrange
            var player = Moves.Rock;
            var opponent = Moves.Rock;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("tie");
        }

        [Test]
        public void CheckForWinner_GivenPlayerScissorsAndOpponentPaper_PlayerShouldWin()
        {
            //Arrange
            var player = Moves.Scissors;
            var opponent = Moves.Paper;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("player wins");
        }
        
        [Test]
        public void CheckForWinner_GivenPlayerScissorsAndOpponentRock_PlayerShouldLose()
        {
            //Arrange
            var player = Moves.Scissors;
            var opponent = Moves.Rock;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("player loses");
        }

        [Test]
        public void CheckForWinner_GivenPlayerScissorsAndOpponentScissors_ShouldTie()
        {
            //Arrange
            var player = Moves.Scissors;
            var opponent = Moves.Scissors;

            var sut = CreateRockPaperScissorsGame();

            //Act
            var result = sut.Play(player, opponent);

            //Assert
            result.Should().Be("tie");
        }

        private static RockPaperScissorsGame CreateRockPaperScissorsGame()
        {
            return new RockPaperScissorsGame();
        }
    }
}