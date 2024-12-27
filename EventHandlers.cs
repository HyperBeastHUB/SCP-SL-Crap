using Exiled.Events.EventArgs.Player;
using System;

namespace WelcomeMessage.EventHandlers
{
    public static class Verified
    {
        public static void OnVerified(VerifiedEventArgs ev)
        {
            string coloredText;

            if (Plugin.Instance.Config.RainbowEffect)
            {
                coloredText = GenerateRainbowText(Plugin.Instance.Config.Text);
            }
            else
            {
                coloredText = $"<b><color={Plugin.Instance.Config.TextColor.ToLower()}>{Plugin.Instance.Config.Text}</color></b>";
            }

            switch (Plugin.Instance.Config.Position.ToLower())
            {
                case "middle":
                    ev.Player.ShowHint(coloredText, Plugin.Instance.Config.Time);
                    break;

                case "top":
                    ev.Player.Broadcast(Plugin.Instance.Config.Time, coloredText);
                    break;

                default:
                    ev.Player.Broadcast(15, "<b><color=red>Welcome Text Error! Please make sure the position is set correctly to 'Top' or 'Middle'!</color></b>");
                    break;
            }
        }

        private static string GenerateRainbowText(string text)
        {
            string[] colors = { "red", "orange", "yellow", "green", "blue", "purple" };
            string rainbowText = "";

            int colorIndex = 0;
            foreach (char c in text)
            {
                rainbowText += $"<color={colors[colorIndex]}>{c}</color>";
                colorIndex = (colorIndex + 1) % colors.Length;
            }

            return rainbowText;
        }
    }
}