using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Logic
{
    public abstract class Observerable
    {
        public abstract void UpdateState();

        public abstract void buttonObserver_ButtonStateChangedEvent();
    }
}