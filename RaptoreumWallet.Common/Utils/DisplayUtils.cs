using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace RaptoreumWallet.Common.Utils
{
    public class DisplayUtils
    {
        public static double ScreenWidth => DisplayInfo.Width / DisplayInfo.Density;
        public static double ScreenHeight => DisplayInfo.Height / DisplayInfo.Density;
        public static DisplayInfo DisplayInfo => DeviceDisplay.MainDisplayInfo;
    }
}
