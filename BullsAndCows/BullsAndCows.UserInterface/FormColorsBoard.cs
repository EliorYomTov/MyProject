using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BullsAndCows.UserInterface
{
    public partial class FormColorsBoard : Form
    {
        private const int k_amountOfColors = 8;
        private const int k_ColorsRowsAmount = 2;
        private const int k_ColorsColumsAmount = 4;
        private Color m_CurrentPickedColor;
        private Button[] colorsArray = new Button[k_amountOfColors];

        public Color CurrentPickedColor
        {
            get { return m_CurrentPickedColor; }
            set { m_CurrentPickedColor = value; }
        }

        public FormColorsBoard()
        {
            ComponentsInitialization();
        }

        public void ComponentsInitialization()
        {
            this.Text = "Pick A Color:";
            this.Size = new Size(250, 150);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoSize = true;

            int index = 0;
            int spaceBetweenButtons = 10;
            int x = spaceBetweenButtons;
            int y = spaceBetweenButtons;
            int boardButtonWidth = 50;
            int boardButtonHeight = 50;

            for (int i = 0; i < k_ColorsRowsAmount; i++)
            {
                for (int j = 0; j < k_ColorsColumsAmount; j++)
                {
                    colorsArray[index] = new Button();
                    colorsArray[index].Size = new Size(boardButtonWidth, boardButtonHeight);
                    colorsArray[index].Location = new Point(x, y);
                    this.colorsArray[index].Click += new System.EventHandler(this.Color_Click);
                    this.Controls.Add(colorsArray[index]);
                    x += boardButtonWidth + spaceBetweenButtons;
                    index++;
                }

                y += boardButtonHeight + spaceBetweenButtons;
                x = spaceBetweenButtons;
            }

            colorsArray[0].BackColor = Color.Purple;
            colorsArray[1].BackColor = Color.Red;
            colorsArray[2].BackColor = Color.LimeGreen;
            colorsArray[3].BackColor = Color.Turquoise;
            colorsArray[4].BackColor = Color.Blue;
            colorsArray[5].BackColor = Color.Yellow;
            colorsArray[6].BackColor = Color.Brown;
            colorsArray[7].BackColor = Color.White;

            this.Size = new Size(this.Size.Width + spaceBetweenButtons, this.Size.Height + spaceBetweenButtons);
        }

        private void Color_Click(object sender, EventArgs e)
        {
            Button colorPickButton = sender as Button;
            m_CurrentPickedColor = colorPickButton.BackColor;
            this.Close();
        }
    }
}
