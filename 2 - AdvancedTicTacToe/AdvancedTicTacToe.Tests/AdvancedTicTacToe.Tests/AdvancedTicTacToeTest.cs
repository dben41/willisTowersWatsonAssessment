using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdvancedTicTacToe.Tests
{
    [TestClass]
    public class AdvancedTicTacToeTest
    {
        [TestMethod]
        public void Winner1StraightRow()
        {
            //assuming that user will never play same piece twice... I'd return -1 if it was an invalid move
            var ticTacToeGame = new TicTacToe(3);
            var winner = ticTacToeGame.PlacePiece(0, 0, 1);
            winner = ticTacToeGame.PlacePiece(0, 1, 1);
            winner = ticTacToeGame.PlacePiece(0, 2, 1);
            var state = ticTacToeGame.returnBoardState(); //for debugging
            var expectedWinner = 1;
            Assert.AreEqual(expectedWinner, winner);

        }

        [TestMethod]
        public void Winner1StraightColumn()
        {
            //assuming that user will never play same piece twice... I'd return -1 if it was an invalid move
            var ticTacToeGame = new TicTacToe(3);
            var winner = ticTacToeGame.PlacePiece(0, 0, 1);
            winner = ticTacToeGame.PlacePiece(1, 0, 1);
            winner = ticTacToeGame.PlacePiece(2, 0, 1);
            var state = ticTacToeGame.returnBoardState(); //for debugging
            var expectedWinner = 1;
            Assert.AreEqual(expectedWinner, winner);

        }

        [TestMethod]
        public void Winner1Diagonal()
        {
            //assuming that user will never play same piece twice... I'd return -1 if it was an invalid move
            var ticTacToeGame = new TicTacToe(3);
            var winner = ticTacToeGame.PlacePiece(0, 0, 1);
            winner = ticTacToeGame.PlacePiece(1, 1, 1);
            winner = ticTacToeGame.PlacePiece(2, 2, 1);
            var state = ticTacToeGame.returnBoardState(); //for debugging
            var expectedWinner = 1;
            Assert.AreEqual(expectedWinner, winner);

        }

        [TestMethod]
        public void NoWinner()
        {
            //assuming that user will never play same piece twice... I'd return -1 if it was an invalid move
            var ticTacToeGame = new TicTacToe(5);
            var winner = ticTacToeGame.PlacePiece(0, 0, 1);
            winner = ticTacToeGame.PlacePiece(1, 1, 1);
            winner = ticTacToeGame.PlacePiece(2, 2, 1);
            var state = ticTacToeGame.returnBoardState(); //for debugging
            var expectedWinner = 0;
            Assert.AreEqual(expectedWinner, winner);

        }

        [TestMethod]
        public void Winner1ReverseDiagonal()
        {
            //assuming that user will never play same piece twice... I'd return -1 if it was an invalid move
            var ticTacToeGame = new TicTacToe(3);
            var winner = ticTacToeGame.PlacePiece(0, 2, 1);
            winner = ticTacToeGame.PlacePiece(2, 0, 1);
            winner = ticTacToeGame.PlacePiece(1, 1, 1);
            var state = ticTacToeGame.returnBoardState(); //for debugging
            var expectedWinner = 1;
            Assert.AreEqual(expectedWinner, winner);
        }

        [TestMethod]
        public void TwoPlayers3x3()
        {
            //assuming that user will never play same piece twice... I'd return -1 if it was an invalid move
            var ticTacToeGame = new TicTacToe(3);
            var winner = ticTacToeGame.PlacePiece(0, 0, 1);
            winner = ticTacToeGame.PlacePiece(1, 2, 2);
            winner = ticTacToeGame.PlacePiece(0, 1, 1);
            winner = ticTacToeGame.PlacePiece(0, 2, 2);
            winner = ticTacToeGame.PlacePiece(2, 2, 1);
            winner = ticTacToeGame.PlacePiece(1, 1, 2);
            winner = ticTacToeGame.PlacePiece(2, 1, 1);
            winner = ticTacToeGame.PlacePiece(2, 0, 2);
            var state = ticTacToeGame.returnBoardState(); //for debugging
            var expectedWinner = 2;
            Assert.AreEqual(expectedWinner, winner);
        }

        [TestMethod]
        public void Winner2_4x4()
        {
            //assuming that user will never play same piece twice... I'd return -1 if it was an invalid move
            var ticTacToeGame = new TicTacToe(4);
            var winner = ticTacToeGame.PlacePiece(0, 0, 2);
            winner = ticTacToeGame.PlacePiece(0, 1, 2);
            winner = ticTacToeGame.PlacePiece(0, 2, 2);
            winner = ticTacToeGame.PlacePiece(0, 3, 2);
            var state = ticTacToeGame.returnBoardState(); //for debugging
            var expectedWinner = 2;
            Assert.AreEqual(expectedWinner, winner);
        }

        [TestMethod]
        public void Winner2_5x5()
        {
            //assuming that user will never play same piece twice... I'd return -1 if it was an invalid move
            var ticTacToeGame = new TicTacToe(5);
            var winner = ticTacToeGame.PlacePiece(0, 0, 2);
            winner = ticTacToeGame.PlacePiece(0, 1, 2);
            winner = ticTacToeGame.PlacePiece(0, 2, 2);
            winner = ticTacToeGame.PlacePiece(0, 3, 2);
            winner = ticTacToeGame.PlacePiece(0, 4, 2);
            var state = ticTacToeGame.returnBoardState(); //for debugging
            var expectedWinner = 2;
            Assert.AreEqual(expectedWinner, winner);
        }
    }
}
