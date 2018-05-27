using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.Logic
{
    public class NotifierButton
    {
        public event Action m_PressButtonNotifyEvent;

        public static bool s_FetchAllInformationButtonState = false;
        private Button m_Notifier;

        public NotifierButton(Button i_Button)
        {
            m_Notifier = i_Button;
        }

        public void UpdateState()
        {
            if (s_FetchAllInformationButtonState == true)
            {
                m_Notifier.Text = "Clear All Information";
            }
            else
            {
                m_Notifier.Text = "Fetch All Information";
            }

            onNotify();
        }

        private void onNotify()
        {
            if (m_PressButtonNotifyEvent != null)
            {
                m_PressButtonNotifyEvent.Invoke();
            }
        }

        public void DetermineFetchAllInformationButtonState()
        {
            if (s_FetchAllInformationButtonState == false)
            {
                s_FetchAllInformationButtonState = true;
            }
            else
            {
                s_FetchAllInformationButtonState = false;
            }
        }
    }
}
