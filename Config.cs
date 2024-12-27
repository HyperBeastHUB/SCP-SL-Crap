using Exiled.API.Interfaces;
using System.ComponentModel;

namespace WelcomeMessage
{
    public class Config : IConfig
    {
        [Description("Enable or disable the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enable or disable debug mode.")]
        public bool Debug { get; set; }

        [Description("Position of the welcome text. 'Top' or 'Middle'. Default is 'Top'.")]
        public string Position { get; set; } = "Top";

        [Description("Enable rainbow effect for the text.")]
        public bool RainbowEffect { get; set; } = false;

        [Description("Text displayed on the screen.")]
        public string Text { get; set; } = "Welcome to the server!";

        [Description("Color of the text if Rainbow effect is disabled.")]
        public string TextColor { get; set; } = "Blue";  

        [Description("Duration (in seconds) the text will be displayed.")]
        public ushort Time { get; set; } = 3;
    }
}