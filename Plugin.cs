using Exiled.API.Features;
using player = Exiled.Events.Handlers.Player;
using System;

namespace WelcomeMessage
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public override string Author => "HyperBeast"; 
        public override Version Version => new Version(1, 3, 0);
        public override string Name => "WelcomeText";  
        public override Version RequiredExiledVersion => new Version(9, 1, 0);

        public override void OnEnabled()
        {
            Instance = this;
            player.Verified += EventHandlers.Verified.OnVerified;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            player.Verified -= EventHandlers.Verified.OnVerified;
            Instance = null;
            base.OnDisabled();
        }
    }
}