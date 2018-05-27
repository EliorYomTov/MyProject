using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FacebookApp.Logic
{
    public class ButtonObserver : Observerable
    {
        private Button m_Button;
        private NotifierButton m_ObserverNotifier;

        public ButtonObserver(Button i_SpecificButton, NotifierButton i_ObserverNotifier)
        {
            m_ObserverNotifier = i_ObserverNotifier;
            m_ObserverNotifier.m_PressButtonNotifyEvent += new Action(buttonObserver_ButtonStateChangedEvent);
            m_Button = i_SpecificButton;
        }

        public override void UpdateState()
        {
            buttonObserver_ButtonStateChangedEvent();
        }

        public override void buttonObserver_ButtonStateChangedEvent()
        {
            if (NotifierButton.s_FetchAllInformationButtonState == true)
            {
                m_Button.Enabled = false;
            }
            else
            {
                m_Button.Enabled = true;
            }
        }
    }
}
