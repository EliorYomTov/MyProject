using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BullsAndCows.Logic;

namespace BullsAndCows.UserInterface
{
    public partial class FormGameBoard : Form
    {
        private const int k_NumOfUserGuessButtons = 4;
        private static int s_userColorGuessIndex = 0;
        private static int s_DisplayResultArrayIndex = 0;
        private static int s_ArrayColumPosition = 0;
        private static int s_ArrayRowPosition = 0;
        private readonly BoardButton[,] r_UserGuessButtonsArray;
        private readonly Button[] r_TopPageResultsButtonsArray;
        private readonly Button[] r_DisplayResultsButtonsArray;
        private readonly int r_NumOfGussesChosenByUser;
        private string[] m_userColorGuess;
        private FormStartGame m_StartGameForm;
        private GameActivation m_GameActivation;

        public Button[] TopPageResultsButtonsArray
        {
            get { return r_TopPageResultsButtonsArray; }
        }

        public FormGameBoard()
        {
            componentsInitialization();
            m_StartGameForm = new FormStartGame();

            if (m_StartGameForm.ShowDialog() == DialogResult.OK)
            {
                r_NumOfGussesChosenByUser = m_StartGameForm.CurrentNumberOfChances;
                r_UserGuessButtonsArray = new BoardButton[r_NumOfGussesChosenByUser, k_NumOfUserGuessButtons + 1];
                r_TopPageResultsButtonsArray = new Button[k_NumOfUserGuessButtons];
                r_DisplayResultsButtonsArray = new Button[k_NumOfUserGuessButtons * r_NumOfGussesChosenByUser];
                runGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void componentsInitialization()
        {
            this.Text = "Bool Pgia";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoSize = true;
        }

        private void runGame()
        {
            m_GameActivation = new GameActivation();
            m_userColorGuess = new string[k_NumOfUserGuessButtons];
            m_GameActivation.RandomColorSuffle();
            boardCreation();
            enableAndFoucusBoardButtons();
        }

        private void boardCreation()
        {
            int spaceBetweenButtons = 10;
            int x = spaceBetweenButtons;
            int y = spaceBetweenButtons;
            int boardButtonWidth = 50;
            int boardButtonHeight = 50;
            int resultButtonWidth = 15;
            int resultButtonHeight = 15;
            int centerPositionOfButton = 0;
            int resultArrayIndex = 0;

            for (int i = 0; i < k_NumOfUserGuessButtons; i++)
            {
                Button topPageResultsButton = new Button();
                topPageResultsButton.BackColor = Color.Black;
                topPageResultsButton.Enabled = false;
                r_TopPageResultsButtonsArray[i] = topPageResultsButton;
                topPageResultsButton.Size = new Size(boardButtonWidth, boardButtonHeight);
                topPageResultsButton.Location = new Point(x, y);
                this.Controls.Add(topPageResultsButton);
                x += boardButtonWidth + spaceBetweenButtons;
                centerPositionOfButton = topPageResultsButton.Top + (topPageResultsButton.Height / 2);
            }

            x = spaceBetweenButtons;
            y = boardButtonHeight * 2;

            for (int i = 0; i < r_NumOfGussesChosenByUser; i++)
            {
                for (int j = 0; j < k_NumOfUserGuessButtons; j++)
                {
                    BoardButton userGuessButton = new BoardButton(i, j);
                    userGuessButton.Enabled = false;
                    r_UserGuessButtonsArray[i, j] = userGuessButton;
                    userGuessButton.Size = new Size(boardButtonWidth, boardButtonHeight);
                    userGuessButton.Location = new Point(x, y);
                    userGuessButton.Click += new EventHandler(this.boardButton_Click);
                    this.Controls.Add(userGuessButton);
                    x += boardButtonWidth + spaceBetweenButtons;
                    centerPositionOfButton = userGuessButton.Top + (userGuessButton.Height / 2);
                }

                BoardButton showResultButton = new BoardButton();
                showResultButton.Enabled = false;
                r_UserGuessButtonsArray[i, k_NumOfUserGuessButtons] = showResultButton;
                showResultButton.Text = "-->>";
                showResultButton.Size = new Size(boardButtonWidth, boardButtonHeight / 2);
                centerPositionOfButton -= showResultButton.Height / 2;
                showResultButton.Location = new Point(x, centerPositionOfButton);
                showResultButton.Click += new EventHandler(this.showResultButton_Click);
                this.Controls.Add(showResultButton);
                x += boardButtonWidth + spaceBetweenButtons;

                int moveX = 0;
                int moveY = 0;

                for (int k = 0; k < 2; k++)
                {
                    for (int t = 0; t < 2; t++)
                    {
                        Button resultButton = new Button();
                        resultButton.Enabled = false;
                        r_DisplayResultsButtonsArray[resultArrayIndex] = resultButton;
                        resultArrayIndex++;
                        resultButton.Size = new Size(resultButtonWidth, resultButtonHeight);
                        resultButton.Location = new Point(x + moveX, y + moveY);
                        this.Controls.Add(resultButton);
                        moveX += resultButtonWidth + spaceBetweenButtons;
                    }

                    moveX = 0;
                    moveY += resultButtonHeight + spaceBetweenButtons;
                }

                y += boardButtonHeight + spaceBetweenButtons;
                x = spaceBetweenButtons;
            }

            this.Size = new Size(this.Size.Width + spaceBetweenButtons, this.Size.Height + spaceBetweenButtons);
        }

        private void boardButton_Click(object sender, EventArgs e)
        {
            BoardButton currentButton = sender as BoardButton;
            FormColorsBoard colorBoradForm = new FormColorsBoard();

            colorBoradForm.ShowDialog();

            if (colorBoradForm.CurrentPickedColor != default(Color))
            {
                currentButton.BackColor = colorBoradForm.CurrentPickedColor;
                m_userColorGuess[currentButton.PositionY] = colorBoradForm.CurrentPickedColor.Name;
                s_userColorGuessIndex++;
                currentButton.Enabled = false;
                updateBoard(currentButton);
            }
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            BoardButton currentButton = sender as BoardButton;
            m_GameActivation.GameGenerator(m_userColorGuess);
            showAmountOfBullsAndCowsResult();
            currentButton.Enabled = false;
            s_userColorGuessIndex = 0;
            s_ArrayRowPosition = 0;
            s_ArrayColumPosition++;
            updateBoard(currentButton);

            if (m_GameActivation.IsGameOver(r_NumOfGussesChosenByUser))
            {
                showRightAnswer();

                DialogResult isRestartGame = MessageBox.Show(string.Format("{0} {1}Would you like to play again?", m_GameActivation.GameOverMassage, Environment.NewLine), "Bool Pgia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (isRestartGame == DialogResult.Yes)
                {
                    createNewGameAgaine(currentButton);
                }
                else
                {
                    MessageBox.Show("See you next time!", "Bool Pgia");
                    Application.Exit();
                }
            }
        }

        private void updateBoard(BoardButton currentButton)
        {
            if (s_ArrayRowPosition < 4 && s_ArrayRowPosition >= 0 && currentButton.Text != "-->>")
            {
                s_ArrayRowPosition++;
            }

            if (s_ArrayRowPosition == 4)
            {
                r_UserGuessButtonsArray[s_ArrayColumPosition, s_ArrayRowPosition].Enabled = true;
                r_UserGuessButtonsArray[s_ArrayColumPosition, s_ArrayRowPosition].Focus();
            }

            if (r_NumOfGussesChosenByUser > s_ArrayColumPosition && currentButton.Text == "-->>")
            {
                enableAndFoucusBoardButtons();
            }
        }

        private void enableAndFoucusBoardButtons()
        {
            for (int i = 0; i < k_NumOfUserGuessButtons; i++)
            {
                r_UserGuessButtonsArray[s_ArrayColumPosition, i].Enabled = true;
            }

            r_UserGuessButtonsArray[s_ArrayColumPosition, 0].Focus();
        }

        private void showAmountOfBullsAndCowsResult()
        {
            for (int i = 0; i < m_GameActivation.BullsCount; i++)
            {
                r_DisplayResultsButtonsArray[s_DisplayResultArrayIndex].BackColor = Color.Black;
                s_DisplayResultArrayIndex++;
            }

            for (int i = 0; i < m_GameActivation.CowsCount; i++)
            {
                r_DisplayResultsButtonsArray[s_DisplayResultArrayIndex].BackColor = Color.Yellow;
                s_DisplayResultArrayIndex++;
            }

            for (int i = 0; i < k_NumOfUserGuessButtons - m_GameActivation.CowsCount - m_GameActivation.BullsCount; i++)
            {
                r_DisplayResultsButtonsArray[s_DisplayResultArrayIndex].BackColor = default(Color);
                s_DisplayResultArrayIndex++;
            }
        }

        private void showRightAnswer()
        {
            for (int i = 0; i < k_NumOfUserGuessButtons; i++)
            {
                switch (m_GameActivation.ChosenColors[i])
                {
                    case "Purple":
                        r_TopPageResultsButtonsArray[i].BackColor = Color.Purple;
                        break;
                    case "Red":
                        r_TopPageResultsButtonsArray[i].BackColor = Color.Red;
                        break;
                    case "LimeGreen":
                        r_TopPageResultsButtonsArray[i].BackColor = Color.LimeGreen;
                        break;
                    case "Turquoise":
                        r_TopPageResultsButtonsArray[i].BackColor = Color.Turquoise;
                        break;
                    case "Blue":
                        r_TopPageResultsButtonsArray[i].BackColor = Color.Blue;
                        break;
                    case "Yellow":
                        r_TopPageResultsButtonsArray[i].BackColor = Color.Yellow;
                        break;
                    case "Brown":
                        r_TopPageResultsButtonsArray[i].BackColor = Color.Brown;
                        break;
                    case "White":
                        r_TopPageResultsButtonsArray[i].BackColor = Color.White;
                        break;
                    default:
                        break;
                }
            }
        }

        private void createNewGameAgaine(BoardButton i_CurrentButton)
        {
            foreach (BoardButton button in r_UserGuessButtonsArray)
            {
                button.BackColor = default(Color);
            }

            foreach (Button button in r_DisplayResultsButtonsArray)
            {
                button.BackColor = default(Color);
            }

            foreach (Button button in r_TopPageResultsButtonsArray)
            {
                button.BackColor = Color.Black;
            }

            s_DisplayResultArrayIndex = 0;
            s_ArrayColumPosition = 0;
            s_ArrayRowPosition = 0;
            m_GameActivation.GuessNumber = 0;
            m_GameActivation.RandomColorSuffle();
            enableAndFoucusBoardButtons();
        }
    }
}