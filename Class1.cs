using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Loader;
using player=Exiled.Events.Handlers.Player;
using System;

namespace scp_sl
{
    public class Class1 : Plugin<WelcomeMessage.config>
    {
        public static Class1 Instance;
        public override string Author => "HyperBeast";
        public override Version Version => new Version(1, 2, 0);
        public override string Name => $"WelcomeText by{Author}";
        public override Version RequiredExiledVersion => new Version(9, 1, 0);
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
