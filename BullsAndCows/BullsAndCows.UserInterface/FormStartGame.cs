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
    public partial class FormStartGame : Form
    {
        private const int k_MaxNumberOfChances = 10;
        private static int s_CurrentNumberOfChances = 4;
        private Button m_NumberOfChancesButton = new Button();
        private Button m_StartButton = new Button();

        public int CurrentNumberOfChances
        {
            get { return s_CurrentNumberOfChances; }
        }

        public int MaxNumberOfChances
        {
            get { return k_MaxNumberOfChances; }
        }

        public FormStartGame()
        {
            ComponentsInitialization();
        }

        private void ComponentsInitialization()
        {
            this.Text = "Bool Pgia";
            this.Size = new Size(300, 150);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            string buttonLabelMsg = string.Format("Number Of Chances: {0} ", s_CurrentNumberOfChances);
            m_NumberOfChancesButton.Text = buttonLabelMsg;
            m_NumberOfChancesButton.Location = new Point(10, 10);
            m_NumberOfChancesButton.Width = this.ClientSize.Width - 10;
            this.m_NumberOfChancesButton.Click += new EventHandler(m_NumberOfChancesButton_Click);
            this.Controls.Add(m_NumberOfChancesButton);

            m_StartButton.Text = "Start";
            m_StartButton.Location = new Point(this.ClientSize.Width - m_StartButton.Width, this.ClientSize.Height - m_StartButton.Height);
            this.m_StartButton.Click += new EventHandler(m_StartButton_Click);
            this.Controls.Add(m_StartButton);
        }

        private void m_NumberOfChancesButton_Click(object sender, EventArgs e)
        {
            s_CurrentNumberOfChances++;
            if (s_CurrentNumberOfChances > k_MaxNumberOfChances)
                {
                    s_CurrentNumberOfChances = 4;
                }

            string msg = string.Format("Number Of Chances: {0} ", s_CurrentNumberOfChances);
            m_NumberOfChancesButton.Text = msg;
        }

        private void m_StartButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}