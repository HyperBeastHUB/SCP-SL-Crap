using Exiled.API.Interfaces;
using System.ComponentModel;

namespace WelcomeMessage
{
    public class config : IConfig
    {
        [Description("Set the value to true or false whether you want the plugin to be enabled or not.")]
        public bool IsEnabled { get; set; } = true;
        [Description("Set the value to true or false whether you want the plugin to be debugged or not.")]
        public bool Debug { get; set; }
        [Description("Set where you want the text to appear, 'Top' part of the screen or 'Middle'. Default is 'Top'")]
        public string Position { get; set; } = "Top";
        [Description("Color of the text. Default is 'blue'")]
        public string Color { get; set; } = "Blue";
        [Description("Type in text you want to be displayed on screen.")]
        public string Text { get; set; } = "Welcome to the server!";
        [Description("Type in time the text will be on the screen. Default value is set to 3. (In Seconds)")]
        public ushort Time { get; set; } = 3;
    }
}
