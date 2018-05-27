namespace BullsAndCows.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Table
    {
        private readonly int r_TableLength;
        private readonly int r_TableWidth;
        private LocationOnTheTable[,] TablePosition = new LocationOnTheTable[11, 2];

        public struct LocationOnTheTable
        {
            private string m_UserGuess;
            private string m_GuessResult;

            public string UserGuess
            {
                get { return m_UserGuess; }
                set { m_UserGuess = value; }
            }

            public string GuessResult
            {
                get { return m_GuessResult; }
                set { m_GuessResult = value; }
            }
        }

        public Table(int i_TableLenght, int i_Tablewidth)
        {
            r_TableLength = i_TableLenght;
            r_TableWidth = i_Tablewidth;
        }

        public int TableLenght
        {
            get { return r_TableLength; }
        }

        public int TableWidth
        {
            get { return r_TableWidth; }
        }
    }
}