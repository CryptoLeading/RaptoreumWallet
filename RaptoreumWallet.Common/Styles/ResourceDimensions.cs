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
        public static double FontSizeLarge = 32;
        public static double FontSizeNormal = 16;
        public static double FontSizeDescription = 14;
        public static double FontSizeSmall = 12;
        public static double ButtonHeight = 48;
        public static double ButtonWidth = 240;
        public static int ButtonRadius = 24;
        public static double ContainerRadius = 6;
        public static double SeparatorSize = 0.5;
        public static double ButtonSecondaryBorderWidth = 1;
        public static double DefaultIconSize = 24;
        public static double MediumIconSize = 16;
        public static double ShadowOffsetX = 0;
        public static double ShadowOffsetY = 0;
        public static double ShadowRadius = 12;
    }
    public class ResourceDimensions : ResourceDictionary
    {
        public ResourceDimensions()
        {
            typeof(Dimensions).GetFieldValues<double>().ForEach(d => Add(d.Key, d.Value));
        }
    }
}
