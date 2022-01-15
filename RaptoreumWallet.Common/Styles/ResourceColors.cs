using RaptoreumWallet.Common.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RaptoreumWallet.Common.Styles
{
    public class Colors
    {
        public static Color TextPrimaryColor = Color.FromHex("#000000");
        public static Color TextSecondaryColor = Color.FromHex("#98989D");
        public static Color BackgroundColor = Color.FromHex("#F8FAFC");
        public static Color SurfaceColor = Color.FromHex("#FFFFFF");
        public static Color BlueColor = Color.FromHex("#31CBD1");
        public static Color GreenColor = Color.FromHex("#4DB883");
        public static Color RedColor = Color.FromHex("#D30E0E");
        public static Color OrangeColor = Color.FromHex("#FFC480");
        public static Color ShadowColor = Color.FromRgba(0, 0, 0, 10);

        public static Brush PrimaryColor = new LinearGradientBrush
        {
            StartPoint = new Point(0.5, 0),
            EndPoint = new Point(0.5, 1),
            GradientStops = new GradientStopCollection { new GradientStop(Color.FromHex("#C53A17"), 0), new GradientStop(Color.FromHex("#EB9A20"), 1) }
        };
    }

    public partial class ResourceColors : ResourceDictionary
    {
        public ResourceColors()
        {
            typeof(Colors).GetFieldValues<Color>().ForEach(d => Add(d.Key, d.Value));
        }
    }
}
