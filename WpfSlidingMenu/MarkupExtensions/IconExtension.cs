using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace WpfSlidingMenu.MarkupExtensions
{

    public enum FontAwesomeIconEnum
    {
        /// <summary>
        /// home
        /// </summary>
        Home = 0xf015,
        /// <summary>
        /// file-import
        /// </summary>
        FileImport = 0xf56f,
        /// <summary>
        /// arrow-left
        /// </summary>
        ArrowLeft = 0xf060,
        /// <summary>
        /// circle
        /// </summary>
        Circle = 0xf111,
        /// <summary>
        /// cog
        /// </summary>
        Settings = 0xf013,
        /// <summary>
        /// history
        /// </summary>
        History = 0xf1da,
        /// <summary>
        /// power-off
        /// </summary>
        PowerOff = 0xf011,
        /// <summary>
        /// star
        /// </summary>
        Star = 0xf005,
        /// <summary>
        /// sync
        /// </summary>
        Sync = 0xf021,
        /// <summary>
        /// Tools
        /// </summary>
        Tools = 0xf7d9,
        /// <summary>
        /// hdd
        /// </summary>
        HDD = 0xf0a0,
        /// <summary>
        /// Bars
        /// </summary>
        Bars = 0xf0c9,
        /// <summary>
        /// Question circle
        /// </summary>
        QuestionCircle=0xf059,
        /// <summary>
        /// Envelope
        /// </summary>
        Envelope=0xf0e0


    }

    [MarkupExtensionReturnType(typeof(string))]
    public partial class IconExtension : MarkupExtension
    {
        public IconExtension()
        {
        }

        public IconExtension(FontAwesomeIconEnum icon)
        {
            Icon = icon;
        }

        [ConstructorArgument("icon")]
        public FontAwesomeIconEnum Icon { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return ((char)Icon).ToString();
        }
    }
}
