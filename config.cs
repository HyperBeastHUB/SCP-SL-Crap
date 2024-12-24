using Exiled.API.Interfaces;
using System.ComponentModel;

namespace scp_sl
{
    public class config : IConfig
    {
        [Description("Set the value to true or false whether you want the plugin to be enabled or not.")]
        public bool IsEnabled { get; set; } = true;
        [Description("Set the value to true or false whether you want the plugin to be debugged or not.")]
        public bool Debug { get; set; }
        [Description("Type in length of text appearing on screen. Default value is set to 3.")]
        public int Length { get; set; } = 3;
    }
}
