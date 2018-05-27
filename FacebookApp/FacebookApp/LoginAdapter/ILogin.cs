using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.LoginAdapter
{
    public interface ILogin
    {
        event EventHandler LoginFinished;

        void Login();

        void LoginAsync();
    }
}
