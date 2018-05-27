namespace BullsAndCows.UserInterface
{
 using System.Windows.Forms;

    internal class BoardButton : Button
    {
        private int m_PositionX;
        private int m_PositionY;

        internal BoardButton()
            : base()
        {
        }

        internal BoardButton(int i_PositionX, int i_PositionY)
        {
            m_PositionX = i_PositionX;
            m_PositionY = i_PositionY;
        }

        public int PositionX
        {
            get { return m_PositionX; }
            set { m_PositionX = value; }
        }

        public int PositionY
        {
            get { return m_PositionY; }
            set { m_PositionY = value; }
        }
    }
}
