using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Loader;
using player = Exiled.Events.Handlers.Player;

namespace scp_sl
{
    public class Class1 : Plugin<config>
    {
        public static Class1 Instance;
        public override void OnEnabled()
        {
            Instance = this;
            player.Verified += EventHandlers.Verified.OnVerified;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            player.Verified -= EventHandlers.Verified.OnVerified;
            base.OnDisabled();
        }
    }
}
