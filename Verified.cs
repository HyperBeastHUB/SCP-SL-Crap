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
            string ColoredText = $"<b><color={Class1.Instance.Config.Color.ToLower()}>{Class1.Instance.Config.Text}</color></b>";
            if(Class1.Instance.Config.Position.ToLower()=="middle")
                ev.Player.ShowHint(ColoredText, Class1.Instance.Config.Time);
            if (Class1.Instance.Config.Position.ToLower() == "top")
                ev.Player.Broadcast(Class1.Instance.Config.Time, ColoredText);
            if (Class1.Instance.Config.Position.ToLower() != "top" && Class1.Instance.Config.Position.ToLower()!= "middle")
                ev.Player.Broadcast(15,"<b><color=red>Welcome Text Error! Please Make sure that the position is set Correctly to 'Top' or 'Mid'!</color></b>");
        }
    }
}
