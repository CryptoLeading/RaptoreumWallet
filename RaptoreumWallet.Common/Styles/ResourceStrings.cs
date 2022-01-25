﻿using RaptoreumWallet.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RaptoreumWallet.Common.Styles
{
    public class Strings
    {
        public static string FontRegular = "RubikRegular";
        //public static string FontBold = "SourceSerifProBold";
        //public static string FontLight = "SourceSerifProLight"; 
    }
    public class ResourceStrings : ResourceDictionary
    {
        public ResourceStrings()
        { 
            typeof(Strings).GetFieldValues<string>().ForEach(d => Add(d.Key, d.Value));
        }
    }
}
