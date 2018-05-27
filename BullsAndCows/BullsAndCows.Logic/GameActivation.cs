namespace BullsAndCows.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GameActivation
    {
        private static int s_GuessNumber = 0;
        private static string[] chosenColors = new string[4];
        private int m_BullsCount = 0;
        private int m_CowsCount = 0;
        // $G$ NTT-999 (-5) This member should have been readonly.
        private string[] m_ArrayOfColors = new string[] { "Purple", "Red", "LimeGreen", "Turquoise", "Blue", "Yellow", "Brown", "White" };
        private string m_GameOverMassage;

        public int GuessNumber
        {
            get { return s_GuessNumber; }
            set { s_GuessNumber = value; }
        }

        public int BullsCount
        {
            get { return m_BullsCount; }
        }

        public int CowsCount
        {
            get { return m_CowsCount; }
        }

        public string[] ChosenColors
        {
            get { return chosenColors; }
        }

        public string GameOverMassage
        {
            get { return m_GameOverMassage; }
            set { m_GameOverMassage = value; }
        }

        private static void randomSuffle(string[] i_ArrayOfColors, ref string[] io_ChosenColors)
        {
            System.Random random = new System.Random();
            for (int i = 0; i < io_ChosenColors.Length; i++)
            {
                int randomIndex = random.Next(i, i_ArrayOfColors.Length - 1);

                string temp = i_ArrayOfColors[i];
                i_ArrayOfColors[i] = i_ArrayOfColors[randomIndex];
                i_ArrayOfColors[randomIndex] = temp;
                io_ChosenColors[i] = i_ArrayOfColors[i];
            }
        }

        public void RandomColorSuffle()
        {
            randomSuffle(m_ArrayOfColors, ref chosenColors);
        }

        public void GameGenerator(string[] i_UserGuess)
        {
            checksAmountOfBullsAndCows(i_UserGuess, chosenColors);
            s_GuessNumber++;
        }

        private void checksAmountOfBullsAndCows(string[] i_UserGuess, string[] i_ChosenLatters)
        {
            m_BullsCount = 0;
            m_CowsCount = 0;

            for (int i = 0; i < i_UserGuess.Length; i++)
            {
                if (i_UserGuess[i] == i_ChosenLatters[i])
                {
                    m_BullsCount++;
                }
                else
                {
                    for (int j = 0; j < i_UserGuess.Length; j++)
                    {
                        if (i_UserGuess[i] == i_ChosenLatters[j])
                        {
                            m_CowsCount++;
                        }
                    }
                }
            }
        }

        public bool IsGameOver(int i_NumOfGussesChosenByUser)
        {
            bool isGameOver = false;

            if (m_BullsCount == 4)
            {
                isGameOver = true;
                GameOverMassage = "You Won!";
            }
            else if (s_GuessNumber > i_NumOfGussesChosenByUser - 1)
            {
                isGameOver = true;
                GameOverMassage = "You Lost!";
            }

            return isGameOver;
        }
    }
}