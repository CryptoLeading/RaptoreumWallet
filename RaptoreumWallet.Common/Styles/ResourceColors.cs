using RaptoreumWallet.Common.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RaptoreumWallet.Common.Styles
{
    public class Colors
    {
        public static Color TextPrimaryColor = Color.FromHex("#2E2E2E");
        public static Color TextEntrySecondaryColor = Color.FromHex("#FFE1B2"); 
        public static Color UnSelectedColor = Color.FromHex("#F8CE98");
        public static Color BorderColor = Color.FromHex("#473015"); 
        public static Color StoreTextColor = Color.FromHex("#1CE2F1");
        public static Color BackgroundClanFrameColor = Color.FromHex("#26001E");
        public static Color LabelButtonColor = Color.FromHex("#495A94");
        public static Color HeaderColor = Color.FromHex("#eddba9");
        public static Color BorderHeaderColor = Color.FromHex("#681527");
        public static Color EntryBackgroundColor = Color.FromHex("#FFF6D8");
        public static Color EntryBorderColor = Color.FromHex("#AD9958");
        public static Color SeparatorColor = Color.FromHex("#959595");
        public static Color IncorrectColor = Color.FromHex("#ed2724");
        public static Color CorrectColor = Color.FromHex("#30b34a"); 
    }

    public partial class ResourceColors : ResourceDictionary
    { 
        public ResourceColors()
        {  
            typeof(Colors).GetFieldValues<Color>().ForEach(d => Add(d.Key, d.Value));
        }
    }
}
