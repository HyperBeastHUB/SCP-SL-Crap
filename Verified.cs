using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scp_sl.EventHandlers
{
    public static class Verified
    {    
        public static void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.ShowHint("Welcome to the server?", Class1.Instance.Config.Length);
        }
    }
}
