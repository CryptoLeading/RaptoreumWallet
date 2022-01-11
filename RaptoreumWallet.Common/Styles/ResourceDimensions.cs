using RaptoreumWallet.Common.Extensions; 
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RaptoreumWallet.Common.Styles
{
    public class Dimensions
    {
        public static double FontSizeHeader = 26;
        public static double FontSizeLarge = 24;
        public static double FontSizeSemiLarge = 20;
        public static double FontSizeTitle = 18;
        public static double FontSizeNormal = 16;
        public static double FontSizeMedium = 14;
        public static double FontSizeSmall = 12;
        public static double FontSizeXSmall = 11;
        public static double FontSizeTiny = 10;
        public static double EntryHeight = 48;
        public static double ButtonHeight = 48;
        public static double ButtonRadius = 24;
        public static double ButtonRoundedRadius = 6;
        public static double ContainerRadius = 6;
        public static double EntryRadius = 4;
        public static double SeparatorSize = 0.5;
        public static double ButtonSecondaryBorderWidth = 1;
        public static double DefaultIconSize = 24;
        public static double MediumIconSize = 16;
        public static double SmallIconSize = 12;
        public static double BorderWidthDefault = 0.8;
        public static double BorderText = 3;
    }
    public class ResourceDimensions : ResourceDictionary
    {
        public ResourceDimensions()
        { 
            typeof(Dimensions).GetFieldValues<double>().ForEach(d => Add(d.Key, d.Value));
        }
    }
}
