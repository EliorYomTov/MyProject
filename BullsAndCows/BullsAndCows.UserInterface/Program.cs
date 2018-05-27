namespace BullsAndCows.UserInterface
{
    using System;

    public class Program
    {
        public static void Main()
        {
            FormGameBoard gameBoard = new FormGameBoard();
            gameBoard.ShowDialog();
        }
    }
}
